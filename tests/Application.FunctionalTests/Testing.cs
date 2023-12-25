using ResumeApp.Domain.Constants;
using ResumeApp.Infrastructure.Data;
using ResumeApp.Infrastructure.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ResumeApp.Application.FunctionalTests;

[SetUpFixture]
public partial class Testing
{
    private static ITestDatabase s_database = null!;
    private static CustomWebApplicationFactory s_factory = null!;
    private static IServiceScopeFactory s_scopeFactory = null!;
    private static string? s_userId;

    [OneTimeSetUp]
    public async Task RunBeforeAnyTests()
    {
        s_database = await TestDatabaseFactory.CreateAsync();
        s_factory = new CustomWebApplicationFactory(s_database.GetConnection());
        s_scopeFactory = s_factory.Services.GetRequiredService<IServiceScopeFactory>();
    }

    public static async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request)
    {
        using var scope = s_scopeFactory.CreateScope();
        var mediator = scope.ServiceProvider.GetRequiredService<ISender>();
        return await mediator.Send(request);
    }

    public static async Task SendAsync(IBaseRequest request)
    {
        using var scope = s_scopeFactory.CreateScope();
        var mediator = scope.ServiceProvider.GetRequiredService<ISender>();
        await mediator.Send(request);
    }

    public static string? GetUserId()
    {
        return s_userId;
    }

    public static async Task<string> RunAsDefaultUserAsync()
    {
        return await RunAsUserAsync("test@local", "Testing1234!", Array.Empty<string>());
    }

    public static async Task<string> RunAsAdministratorAsync()
    {
        return await RunAsUserAsync("administrator@local", "Administrator1234!", [Roles.Administrator]);
    }

    public static async Task<string> RunAsUserAsync(string userName, string password, string[] roles)
    {
        using var scope = s_scopeFactory.CreateScope();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        var user = new ApplicationUser { UserName = userName, Email = userName };
        var result = await userManager.CreateAsync(user, password);

        if (roles.Any())
        {
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            foreach (var role in roles)
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }

            await userManager.AddToRolesAsync(user, roles);
        }

        if (result.Succeeded)
        {
            s_userId = user.Id;
            return s_userId;
        }

        var errors = string.Join(Environment.NewLine, result.ToApplicationResult().Errors);
        throw new Exception($"Unable to create {userName}.{Environment.NewLine}{errors}");
    }

    public static async Task ResetState()
    {
        try
        {
            await s_database.ResetAsync();
        }
        catch (Exception) 
        {
        }

        s_userId = null;
    }

    public static async Task<TEntity?> FindAsync<TEntity>(params object[] keyValues)
        where TEntity : class
    {
        using var scope = s_scopeFactory.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        return await context.FindAsync<TEntity>(keyValues);
    }

    public static async Task AddAsync<TEntity>(TEntity entity)
        where TEntity : class
    {
        using var scope = s_scopeFactory.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        context.Add(entity);
        await context.SaveChangesAsync();
    }

    public static async Task<int> CountAsync<TEntity>() where TEntity : class
    {
        using var scope = s_scopeFactory.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        return await context.Set<TEntity>().CountAsync();
    }

    [OneTimeTearDown]
    public async Task RunAfterAnyTests()
    {
        await s_database.DisposeAsync();
        await s_factory.DisposeAsync();
    }
}
