using ResumeApp.Application.Certificates.Commands.CreateCertificate;
using ResumeApp.Application.Certificates.Commands.UpdateCertificate;
using ResumeApp.Application.Common.Exceptions;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.FunctionalTests.Certificates.Commands;

using static Testing;

public class UpdateCertificateTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidCertificateId()
    {
        var command = new UpdateCertificateCommand(
            Guid.NewGuid(), 
            "ACME Cloud Architect",
            "ACME",
            new Uri("https://theuselessweb.site/nooooooooooooooo/"),
            new DateOnly(1977,05,25),
            new DateOnly(2005,05,19));
        await FluentActions.Invoking((() => SendAsync(command))).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldRequireUniqueTitle()
    {
        var id = await SendAsync(new CreateCertificateCommand(
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

        var command = new UpdateCertificateCommand(
            id,
            "The DevOps Strikes Back",
            "LucasFlicks", 
            new Uri("https://theuselessweb.site/nooooooooooooooo/"),
            new DateOnly(1979,03,05),
            new DateOnly(1980,05,21));

        var assertion = FluentActions.Invoking((() => SendAsync(command)));
        
        (await FluentActions.Invoking((() => SendAsync(command)))
                .Should().ThrowAsync<ValidationException>().Where(ex => ex.Errors.ContainsKey("Name")))
                .And.Errors["Name"].Should().Contain("'Name' must be unique.");
    }

    [Test]
    public async Task ShouldUpdateCertificate()
    {
        var userId = await RunAsDefaultUserAsync();
        var id = await SendAsync(new CreateCertificateCommand(
            "ACME Cloud Architect",
            "ACME", 
            new Uri("https://theuselessweb.site/nooooooooooooooo/"),
            new DateOnly(1977,05,25),
            new DateOnly(2005,05,19)));

        var command = new UpdateCertificateCommand(
            id,
            "ACME Cloud Architect",
            "ACME",
            new Uri("https://theuselessweb.site/nooooooooooooooo/"),
            new DateOnly(1977,05,25),
            new DateOnly(2005,05,19));

        await SendAsync(command);

        var certificate = await FindAsync<Certificate>(id);

        certificate.Should().NotBeNull();
        certificate!.Name.Should().Be(command.Name);
        certificate.Issuer.Should().Be(command.Issuer);
        certificate.ExpirationDate.Should().Be(command.ExpirationDate);
        certificate.IssueDate.Should().Be(command.IssueDate);
        certificate.VerificationUrl.Should().Be(command.VerificationUrl);
        certificate.LastModifiedBy.Should().NotBeNull();
        certificate.LastModifiedBy.Should().Be(userId);
        certificate.LastModified.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
    }
}
