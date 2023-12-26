using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using ResumeApp.Application.Common.Behaviours;
using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Contacts.Commands.CreateContact;
using ResumeApp.Domain.Enums;

namespace ResumeApp.Application.UnitTests.Common.Behaviours;

public class LoggingBehaviourTests
{
    private Mock<ILogger<CreateContactCommand>> _logger = null!;
    private Mock<IUser> _user = null!;
    private Mock<IIdentityService> _identityService = null!;

    [SetUp]
    public void Setup()
    {
        _logger = new Mock<ILogger<CreateContactCommand>>();
        _user = new Mock<IUser>();
        _identityService = new Mock<IIdentityService>();
    }

    [Test]
    public async Task ShouldCallGetUserNameAsyncOnceIfAuthenticated()
    {
        _user.Setup(x => x.Id).Returns(Guid.NewGuid().ToString());

        var requestLogger = new LoggingBehaviour<CreateContactCommand>(_logger.Object, _user.Object, _identityService.Object);

        await requestLogger.Process(
            new CreateContactCommand(ContactType.GitHub, "github", "@github-user", "https://theuselessweb.site/nooooooooooooooo/"),
            new CancellationToken());

        _identityService.Verify(i => i.GetUserNameAsync(It.IsAny<string>()), Times.Once);
    }

    [Test]
    public async Task ShouldNotCallGetUserNameAsyncOnceIfUnauthenticated()
    {
        var requestLogger = new LoggingBehaviour<CreateContactCommand>(_logger.Object, _user.Object, _identityService.Object);

        await requestLogger.Process(
            new CreateContactCommand(ContactType.GitHub, "github", "@github-user", "https://theuselessweb.site/nooooooooooooooo/"), 
            new CancellationToken());

        _identityService.Verify(i => i.GetUserNameAsync(It.IsAny<string>()), Times.Never);
    }
}
