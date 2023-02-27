using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;
using ResumeApp.BusinessLogic.Configs;
using ResumeApp.BusinessLogic.Extensions;
using System.Reflection;
using System.Text.Json.Serialization;
using OwaspHeaders.Core.Extensions;

namespace ResumeApp.WebApi;

public sealed class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

#if DEBUG
        builder.Configuration.AddUserSecrets(Assembly.GetExecutingAssembly());
#endif

        builder.Services.AddResponseCaching();

        builder.Services
            .AddControllers(setupAction => setupAction.ReturnHttpNotAcceptable = true)
            .AddJsonOptions(o => o.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);

        builder.Services.AddResumeServices(builder.Configuration);

        // Swagger
        var swaggerConfig = builder.Configuration.GetSection(SwaggerDocOptions.SectionName).Get<SwaggerDocOptions>();
        builder.Services
            .AddEndpointsApiExplorer()
            .AddSwaggerGen(options =>
            {
                options.SwaggerDoc(swaggerConfig.DocName, new OpenApiInfo
                {
                    Version = swaggerConfig.Version,
                    Title = swaggerConfig.Title,
                    Description = swaggerConfig.Description,
                    Contact = new OpenApiContact
                    {
                        Name = swaggerConfig.ContactName,
                        Email = swaggerConfig.ContactEmail
                    }
                });
            });

        //Cors
        var corsConfig = builder.Configuration.GetSection(CorsOptions.SectionName).Get<CorsOptions>();
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
            {
                policy.WithOrigins(corsConfig.AllowedOrigins.ToArray())
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        else
        {
            app.UseSecureHeadersMiddleware(SecureHeadersMiddlewareExtensions.BuildDefaultConfiguration());
        }

        app.UseHttpsRedirection();
        app.UseCors();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
