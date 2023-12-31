using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using ResumeApp.Application.Certificates.Commands.CreateCertificate;
using ResumeApp.Application.Common.Behaviours;
using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.UnitTests.Common.Behaviours;

public class LoggingBehaviourTests
{
    private Mock<ILogger<CreateCertificateCommand>> _logger = null!;
    private Mock<IUser> _user = null!;
    private Mock<IIdentityService> _identityService = null!;

    [SetUp]
    public void Setup()
    {
        _logger = new Mock<ILogger<CreateCertificateCommand>>();
        _user = new Mock<IUser>();
        _identityService = new Mock<IIdentityService>();
    }

    [Test]
    public async Task ShouldCallGetUserNameAsyncOnceIfAuthenticated()
    {
        _user.Setup(x => x.Id).Returns(Guid.NewGuid().ToString());

        var requestLogger = new LoggingBehaviour<CreateCertificateCommand>(_logger.Object, _user.Object, _identityService.Object);

        await requestLogger.Process(
            new CreateCertificateCommand(
                "LucasFlicks Cloud Architect",
                "LucasFlicks", 
                new Uri("https://theuselessweb.site/nooooooooooooooo/"),
                new DateOnly(1977,05,25),
                new DateOnly(2005,05,19)),
            new CancellationToken());

        _identityService.Verify(i => i.GetUserNameAsync(It.IsAny<string>()), Times.Once);
    }

    [Test]
    public async Task ShouldNotCallGetUserNameAsyncOnceIfUnauthenticated()
    {
        var requestLogger = new LoggingBehaviour<CreateCertificateCommand>(_logger.Object, _user.Object, _identityService.Object);

        await requestLogger.Process(
            new CreateCertificateCommand(
                "LucasFlicks Cloud Architect",
                "LucasFlicks", 
                new Uri("https://theuselessweb.site/nooooooooooooooo/"),
                new DateOnly(1977,05,25),
                new DateOnly(2005,05,19)), 
            new CancellationToken());

        _identityService.Verify(i => i.GetUserNameAsync(It.IsAny<string>()), Times.Never);
    }
}
