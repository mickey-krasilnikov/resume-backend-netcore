using MediatR;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using ResumeApp.Application.Common.Behaviours;
using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Application.Contacts.Commands.CreateContact;
using ResumeApp.Domain.Enums;

namespace ResumeApp.Application.UnitTests.Common.Behaviours;

[TestFixture]
public class PerformanceBehaviourTests
{
    private Mock<ILogger<CreateContactCommand>> _logger = null!;
    private Mock<IUser> _user = null!;
    private Mock<IIdentityService> _identityService = null!;
    private PerformanceBehaviour<CreateContactCommand, Guid> _performanceBehaviour = null!;

    [SetUp]
    public void SetUp()
    {
        _logger = new Mock<ILogger<CreateContactCommand>>();
        _user = new Mock<IUser>();
        _identityService = new Mock<IIdentityService>();
        _performanceBehaviour = new PerformanceBehaviour<CreateContactCommand, Guid>(_logger.Object, _user.Object, _identityService.Object);
    }

    [Test]
    public async Task ShouldLogWarningForLongRunningRequest()
    {
        var request = new CreateContactCommand(ContactType.GitHub, "github", "@github-user", "https://theuselessweb.site/nooooooooooooooo/");
        var userId = Guid.NewGuid().ToString();
        var userName = "TestUser";

        _user.Setup(x => x.Id).Returns(userId);
        _identityService.Setup(x => x.GetUserNameAsync(userId)).ReturnsAsync(userName);

        // Mocking a long running request (more than 500 ms)
        var next = new RequestHandlerDelegate<Guid>(() =>
        {
            Thread.Sleep(600); // simulating delay
            return Task.FromResult(Guid.NewGuid());
        });

        await _performanceBehaviour.Handle(request, next, new CancellationToken());

        _logger.Verify(
            x => x.Log(
                LogLevel.Warning,
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((o, t) => 
                    o.ToString()!.Contains("Long Running Request") && 
                    o.ToString()!.Contains(userId) && 
                    o.ToString()!.Contains(userName)),
                It.IsAny<Exception>(),
                (Func<It.IsAnyType, Exception?, string>)It.IsAny<object>()),
            Times.Once);
    }
}
