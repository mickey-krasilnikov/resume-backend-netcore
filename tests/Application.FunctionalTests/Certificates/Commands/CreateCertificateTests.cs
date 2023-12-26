using ResumeApp.Application.Certificates.Commands.CreateCertificate;
using ResumeApp.Application.Common.Exceptions;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.FunctionalTests.Certificates.Commands;

using static Testing;

public class CreateCertificateTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireMinimumFields()
    {
        var command = new CreateCertificateCommand(
            String.Empty, 
            String.Empty, 
            new Uri("https://theuselessweb.site/nooooooooooooooo/"),
            new DateOnly(1977,05,25),
            new DateOnly(2005,05,19));
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<ValidationException>();
    }

    [Test]
    public async Task ShouldRequireUniqueTitle()
    {
        await SendAsync(new CreateCertificateCommand(
            "ACME Cloud Architect",
            "ACME", 
            new Uri("https://theuselessweb.site/nooooooooooooooo/"),
            new DateOnly(1977,05,25),
            new DateOnly(2005,05,19)));

        var command = new CreateCertificateCommand(
            "ACME Cloud Architect",
            "ACME", 
            new Uri("https://theuselessweb.site/nooooooooooooooo/"),
            new DateOnly(1977,05,25),
            new DateOnly(2005,05,19));

        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<ValidationException>();
    }

    [Test]
    public async Task ShouldCreateCertificate()
    {
        var userId = await RunAsDefaultUserAsync();
        var command = new CreateCertificateCommand(
            "ACME Cloud Architect",
            "ACME", 
            new Uri("https://theuselessweb.site/nooooooooooooooo/"),
            new DateOnly(1977,05,25),
            new DateOnly(2005,05,19));

        var id = await SendAsync(command);

        var certificate = await FindAsync<Certificate>(id);

        certificate.Should().NotBeNull();
        certificate!.Name.Should().Be(command.Name);
        certificate.Issuer.Should().Be(command.Issuer);
        certificate.ExpirationDate.Should().Be(command.ExpirationDate);
        certificate.IssueDate.Should().Be(command.IssueDate);
        certificate.VerificationUrl.Should().Be(command.VerificationUrl);
        certificate.CreatedBy.Should().Be(userId);
        certificate.Created.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
    }
}
