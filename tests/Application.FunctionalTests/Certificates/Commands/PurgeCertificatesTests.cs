using ResumeApp.Application.Certificates.Commands.CreateCertificate;
using ResumeApp.Application.Certificates.Commands.PurgeCertificates;
using ResumeApp.Application.Common.Exceptions;
using ResumeApp.Application.Common.Security;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.FunctionalTests.Certificates.Commands;

using static Testing;

public class PurgeCertificatesTests : BaseTestFixture
{
    [Test]
    public async Task ShouldDenyAnonymousUser()
    {
        var command = new PurgeCertificatesCommand();
        command.GetType().Should().BeDecoratedWith<AuthorizeAttribute>();
        var action = () => SendAsync(command);
        await action.Should().ThrowAsync<UnauthorizedAccessException>();
    }

    [Test]
    public async Task ShouldDenyNonAdministrator()
    {
        await RunAsDefaultUserAsync();
        var command = new PurgeCertificatesCommand();
        var action = () => SendAsync(command);
        await action.Should().ThrowAsync<ForbiddenAccessException>();
    }

    [Test]
    public async Task ShouldAllowAdministrator()
    {
        await RunAsAdministratorAsync();
        var command = new PurgeCertificatesCommand();
        var action = () => SendAsync(command);
        await action.Should().NotThrowAsync<ForbiddenAccessException>();
    }

    [Test]
    public async Task ShouldDeleteAllLists()
    {
        await RunAsAdministratorAsync();
        await SendAsync(new CreateCertificateCommand(
            "The New Hope Architect",
            "LucasFlicks", 
            new Uri("https://theuselessweb.site/nooooooooooooooo/"),
            new DateOnly(1976,03,22),
            new DateOnly(1977,05,25)));

        await SendAsync(new CreateCertificateCommand(
            "The DevOps Strikes Back",
            "LucasFlicks", 
            new Uri("https://theuselessweb.site/nooooooooooooooo/"),
            new DateOnly(1979,03,05),
            new DateOnly(1980,05,21)));

        await SendAsync(new CreateCertificateCommand(
            "Return of Jedi Developer",
            "LucasFlicks", 
            new Uri("https://theuselessweb.site/nooooooooooooooo/"),
            new DateOnly(1982,01,11),
            new DateOnly(1983,05,25)));

        await SendAsync(new PurgeCertificatesCommand());
        var count = await CountAsync<Certificate>();
        count.Should().Be(0);
    }
}
