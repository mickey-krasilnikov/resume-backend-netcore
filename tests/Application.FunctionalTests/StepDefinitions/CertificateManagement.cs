using ResumeApp.Application.Certificates.Commands.CreateCertificate;
using ResumeApp.Application.Certificates.Commands.DeleteCertificate;
using ResumeApp.Application.Certificates.Commands.PurgeCertificates;
using ResumeApp.Application.Certificates.Commands.UpdateCertificate;
using ResumeApp.Application.Certificates.Queries.GetCertificatesWithPagination;
using ResumeApp.Application.Common.Exceptions;
using ResumeApp.Application.Common.Models;
using ResumeApp.Application.FunctionalTests.Support.Builders;
using ResumeApp.Domain.Entities;
using TechTalk.SpecFlow;

namespace ResumeApp.Application.FunctionalTests.StepDefinitions;

using static Testing;

[Binding]
public sealed class CertificateManagement(ScenarioContext scenarioContext)
{
    [BeforeScenario]
    [AfterScenario]
    public static async Task TestSetUp() => await ResetState();

    [Given(@"I am a registered user")]
    public static async Task GivenIAmARegisteredDefaultUser() => await RunAsDefaultUserAsync();

    [Given(@"I am an administrative user")]
    public static async Task GivenIAmAnAdministrativeUser() => await RunAsAdministratorAsync();

    [Given(@"I am anonymous user")]
    public static async Task GivenIAmAnonymousUser() => await RunAsAnonymousUserAsync();

    [Given(@"a certificate with a given title already exists")]
    public async Task GivenACertificateWithAGivenTitleAlreadyExists()
    {
        var existingCertificateCommand = new CreateCertificateCommandBuilder().WithName("Attack of the Clones").Build();
        await SendAsync(existingCertificateCommand);
    }

    [When(@"I attempt to create a new certificate")]
    public void WhenIAttemptToCreateANewCertificate()
    {
        var command = new CreateCertificateCommandBuilder().Build();
        scenarioContext["CreateCommand"] = command;
    }

    [When(@"I attempt to create a new certificate with missing minimum fields")]
    public void WhenICreateANewCertificateWithMissingMinimumFields()
    {
        var command = new CreateCertificateCommandBuilder().WithName(string.Empty).WithIssuer(string.Empty).Build();
        scenarioContext["CreateCommand"] = command;
    }

    [When(@"I attempt to create a new certificate with the same title")]
    public void WhenICreateANewCertificateWithTheSameTitle()
    {
        var duplicateTitleCommand = new CreateCertificateCommandBuilder().WithName("Attack of the Clones").Build();
        scenarioContext["CreateCommand"] = duplicateTitleCommand;
    }

    [Then(@"the certificate should be successfully created")]
    public async Task ThenTheCertificateShouldBeSuccessfullyCreated()
    {
        var command = (CreateCertificateCommand)scenarioContext["CreateCommand"];
        var id = await SendAsync(command);
        var certificate = await FindAsync<Certificate>(id);
        certificate.Should().NotBeNull();
        certificate!.Name.Should().Be(command.Name);
        certificate.Issuer.Should().Be(command.Issuer);
        certificate.IssueDate.Should().Be(command.IssueDate);
        certificate.ExpirationDate.Should().Be(command.ExpirationDate);
        certificate.VerificationUrl.Should().Be(command.VerificationUrl);
    }

    [Then(@"the creation should be denied due to validation error")]
    public async Task ThenTheCreationShouldBeDeniedDueToValidationError()
    {
        var command = (CreateCertificateCommand)scenarioContext["CreateCommand"];
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<ValidationException>();
    }

    [Then(@"the creation should be denied due to unauthorized access error")]
    public async Task ThenTheCreationShouldBeDeniedDueToUnauthorizedAccessError()
    {
        var command = (CreateCertificateCommand)scenarioContext["CreateCommand"];
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<UnauthorizedAccessException>();
    }

    [Given(@"I have an existing certificate")]
    public async Task GivenIHaveAnExistingCertificate()
    {
        var certificate = new Certificate
        {
            Name = "The New Hope Architect",
            Issuer = "LucasFlicks",
            IssueDate = new DateOnly(1976, 03, 22),
            ExpirationDate = new DateOnly(1977, 05, 25),
            VerificationUrl = new Uri("https://theuselessweb.site/nooooooooooooooo/")
        };

        await AddAsync(certificate);
        scenarioContext["ExistingCertificateId"] = certificate.Id;
    }

    [When(@"I attempt to update a certificate")]
    public async Task WhenIAttemptToUpdateACertificate()
    {
        var id = (Guid)scenarioContext["ExistingCertificateId"];

        var command = new UpdateCertificateCommandBuilder()
            .WithId(id)
            .WithName("Updated Title")
            .WithIssuer("Updated Issuer")
            .WithIssueDate(new DateOnly(2023, 11, 30))
            .WithExpirationDate(new DateOnly(2023, 12, 31))
            .WithVerificationUrl(new Uri("https://www.nooo.me/"))
            .Build();

        scenarioContext["UpdateCommand"] = command;
        scenarioContext["CertificateToUpdate"] = await FindAsync<Certificate>(command.Id);
    }

    [Then(@"the certificate should be successfully updated")]
    public async Task ThenTheCertificateShouldBeSuccessfullyUpdated()
    {
        var existingCertificate = (Certificate)scenarioContext["CertificateToUpdate"];
        var command = (UpdateCertificateCommand)scenarioContext["UpdateCommand"];

        await SendAsync(command);

        var updatedCertificate = await FindAsync<Certificate>(command.Id);

        existingCertificate.Should().NotBeNull();
        updatedCertificate.Should().NotBeNull();

        updatedCertificate.Should().NotBeEquivalentTo(existingCertificate);

        updatedCertificate!.Id.Should().Be(existingCertificate!.Id);
        updatedCertificate.Name.Should().NotBe(existingCertificate.Name);
        updatedCertificate.Issuer.Should().NotBe(existingCertificate.Issuer);
        updatedCertificate.IssueDate.Should().NotBe(existingCertificate.IssueDate);
        updatedCertificate.ExpirationDate.Should().NotBe(existingCertificate.ExpirationDate);
        updatedCertificate.VerificationUrl.Should().NotBe(existingCertificate.VerificationUrl);
    }

    [Given(@"I have an invalid certificate id")]
    public void GivenIHaveAnInvalidCertificateId()
    {
        scenarioContext["ExistingCertificateId"] = Guid.NewGuid();
    }

    [Then(@"the update should be denied due to invalid certificate id")]
    public void ThenTheUpdateShouldBeDeniedDueToInvalidCertificateId()
    {
        var command = (UpdateCertificateCommand)scenarioContext["UpdateCommand"];
        FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Given(@"another certificate with a new title exists")]
    public async Task GivenAnotherCertificateWithANewTitleExists()
    {
        var id = await SendAsync(new CreateCertificateCommand(
            "New Unique Title",
            "New Issuer",
            new Uri("https://example.com/newunique"),
            new DateOnly(1981, 02, 02),
            new DateOnly(2007, 01, 01)));

        var certificate = await FindAsync<Certificate>(id);
        scenarioContext["ExistingCertificate"] = certificate;
    }

    [When(@"I update the certificate with the new title")]
    public async Task WhenIUpdateTheCertificateWithTheNewTitle()
    {
        var existingCertificate = (Certificate)scenarioContext["ExistingCertificate"];
        var newTitle = "New Unique Title";
        scenarioContext["DuplicateCertificateTitle"] = newTitle;
        var command = new UpdateCertificateCommandBuilder()
            .WithId(existingCertificate.Id)
            .WithName(newTitle)
            .WithIssuer(existingCertificate.Issuer)
            .WithIssueDate(existingCertificate.IssueDate)
            .WithExpirationDate(existingCertificate.ExpirationDate!.Value)
            .WithVerificationUrl(existingCertificate.VerificationUrl!)
            .Build();

        await SendAsync(command);
    }

    [Then(@"the update should be denied due to non-unique title")]
    public void ThenTheUpdateShouldBeDeniedDueToNonUniqueTitle()
    {
        var existingCertificate = (Certificate)scenarioContext["ExistingCertificate"];
        var command = new UpdateCertificateCommand(
            existingCertificate.Id,
            (string)scenarioContext["DuplicateCertificateTitle"],
            "Updated Issuer",
            new Uri("https://example.com/updated"),
            new DateOnly(1980, 01, 01),
            new DateOnly(2006, 12, 31));
        scenarioContext["DuplicateTitleUpdateCommand"] = command;

        FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<ValidationException>();
    }

    [Then(@"the update should be denied due to unauthorized access error")]
    public async Task ThenTheUpdateShouldBeDeniedDueToUnauthorizedAccessError()
    {
        var command = (UpdateCertificateCommand)scenarioContext["UpdateCommand"];
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<UnauthorizedAccessException>();
    }

    [When(@"I attempt to delete a certificate")]
    public void WhenIAttemptToDeleteACertificate()
    {
        var id = (Guid)scenarioContext["ExistingCertificateId"];
        var command = new DeleteCertificateCommand(id);
        scenarioContext["DeleteCommand"] = command;
    }

    [Then(@"the certificate should be successfully deleted")]
    public async Task ThenTheCertificateShouldBeSuccessfullyDeleted()
    {
        var command = (DeleteCertificateCommand)scenarioContext["DeleteCommand"];
        await SendAsync(command);
        var existingCertificate = await FindAsync<Certificate>(command.Id);
        existingCertificate.Should().BeNull();
    }

    [Then(@"the deletion should be denied due to invalid certificate id")]
    public void ThenTheDeletionShouldBeDeniedDueToInvalidCertificateId()
    {
        var command = (DeleteCertificateCommand)scenarioContext["DeleteCommand"];
        FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Then(@"the deletion should be denied due to unauthorized access error")]
    public void ThenTheDeletionShouldBeDeniedDueToUnauthorizedAccessError()
    {
        var command = (DeleteCertificateCommand)scenarioContext["DeleteCommand"];
        FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<UnauthorizedAccessException>();
    }

    [When(@"I purge all certificates")]
    public async Task WhenIPurgeAllCertificates()
    {
        await SendAsync(new CreateCertificateCommandBuilder()
            .WithName("The New Hope Architect")
            .WithIssueDate(new DateOnly(1976, 03, 22))
            .WithExpirationDate(new DateOnly(1977, 05, 25))
            .Build());

        await SendAsync(new CreateCertificateCommandBuilder()
            .WithName("The DevOps Strikes Back")
            .WithIssueDate(new DateOnly(1979, 03, 05))
            .WithExpirationDate(new DateOnly(1980, 05, 21))
            .Build());

        await SendAsync(new CreateCertificateCommandBuilder()
            .WithName("Return of Jedi Developer")
            .WithIssueDate(new DateOnly(1982, 01, 11))
            .WithExpirationDate(new DateOnly(1983, 05, 25))
            .Build());

        var count = await CountAsync<Certificate>();
        count.Should().Be(3);

        await SendAsync(new PurgeCertificatesCommand());
    }

    [Then(@"all certificates should be successfully purged")]
    public async Task ThenAllCertificatesShouldBeSuccessfullyPurged()
    {
        var count = await CountAsync<Certificate>();
        count.Should().Be(0);
    }

    [When(@"I attempt to purge all certificates as an anonymous user")]
    public void WhenIAttemptToPurgeAllCertificatesAsAnAnonymousUser()
    {
        var command = new PurgeCertificatesCommand();
        scenarioContext["AnonymousPurgeCommand"] = command;
    }

    [Then(@"I should be denied access to purge")]
    public void ThenIShouldBeDeniedAccessToPurge()
    {
        var command = (PurgeCertificatesCommand)scenarioContext["AnonymousPurgeCommand"];
        FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<UnauthorizedAccessException>();
    }

    [When(@"I attempt to purge all certificates as a non-administrator")]
    public void WhenIAttemptToPurgeAllCertificatesAsANonAdministrator()
    {
        var command = new PurgeCertificatesCommand();
        scenarioContext["NonAdminPurgeCommand"] = command;
    }

    [Then(@"I should be denied access to purge due to lack of administrative privileges")]
    public void ThenIShouldBeDeniedAccessToPurgeDueToLackOfAdministrativePrivileges()
    {
        var command = (PurgeCertificatesCommand)scenarioContext["NonAdminPurgeCommand"];
        FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<ForbiddenAccessException>();
    }

    [When(@"I retrieve the list of certificates")]
    public async Task WhenIRetrieveTheListOfCertificates()
    {
        await SendAsync(new CreateCertificateCommandBuilder()
            .WithName("The New Hope Architect")
            .WithIssueDate(new DateOnly(1976, 03, 22))
            .WithExpirationDate(new DateOnly(1977, 05, 25))
            .Build());

        await SendAsync(new CreateCertificateCommandBuilder()
            .WithName("The DevOps Strikes Back")
            .WithIssueDate(new DateOnly(1979, 03, 05))
            .WithExpirationDate(new DateOnly(1980, 05, 21))
            .Build());

        await SendAsync(new CreateCertificateCommandBuilder()
            .WithName("Return of Jedi Developer")
            .WithIssueDate(new DateOnly(1982, 01, 11))
            .WithExpirationDate(new DateOnly(1983, 05, 25))
            .Build());

        var query = new GetCertificatesWithPaginationQuery { PageNumber = 1, PageSize = 10 };
        scenarioContext["AllExistingCertificates"] = await SendAsync(query);
    }

    [Then(@"I should see all the certificates")]
    public void ThenIShouldSeeAllTheCertificates()
    {
        var list = (PaginatedList<CertificateDto>)scenarioContext["AllExistingCertificates"];
        list.Should().NotBeNull();
        list.TotalCount.Should().Be(3);
    }
}
