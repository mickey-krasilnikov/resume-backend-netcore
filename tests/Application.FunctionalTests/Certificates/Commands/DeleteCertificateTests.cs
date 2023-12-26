using ResumeApp.Application.Certificates.Commands.CreateCertificate;
using ResumeApp.Application.Certificates.Commands.DeleteCertificate;
using ResumeApp.Domain.Entities;

namespace ResumeApp.Application.FunctionalTests.Certificates.Commands;

using static Testing;

public class DeleteCertificateTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidCertificateId()
    {
        var command = new DeleteCertificateCommand(Guid.NewGuid());
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteCertificate()
    {
        var listId = await SendAsync(new CreateCertificateCommand(
            "ACME Cloud Architect",
            "ACME", 
            new Uri("https://theuselessweb.site/nooooooooooooooo/"),
            new DateOnly(1977,05,25),
            new DateOnly(2005,05,19)));

        await SendAsync(new DeleteCertificateCommand(listId));
        var list = await FindAsync<Certificate>(listId);
        list.Should().BeNull();
    }
}
