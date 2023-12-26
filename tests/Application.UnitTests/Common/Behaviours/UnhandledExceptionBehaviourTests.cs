using MediatR;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using ResumeApp.Application.Common.Behaviours;
using ResumeApp.Application.Contacts.Commands.CreateContact;
using ResumeApp.Domain.Enums;

namespace ResumeApp.Application.UnitTests.Common.Behaviours;

[TestFixture]
public class UnhandledExceptionBehaviourTests
{
    private Mock<ILogger<CreateContactCommand>> _logger = null!;
    private UnhandledExceptionBehaviour<CreateContactCommand, Guid> _unhandledExceptionBehaviour = null!;

    [SetUp]
    public void SetUp()
    {
        _logger = new Mock<ILogger<CreateContactCommand>>();
        _unhandledExceptionBehaviour = new UnhandledExceptionBehaviour<CreateContactCommand, Guid>(_logger.Object);
    }

    [Test]
    public void ShouldNotLogErrorForSuccessfulRequest()
    {
        var request = new CreateContactCommand(ContactType.GitHub, "github", "@github-user", "https://theuselessweb.site/nooooooooooooooo/");
        var next = new RequestHandlerDelegate<Guid>(() => Task.FromResult(new Guid()));

        Assert.DoesNotThrowAsync(() => _unhandledExceptionBehaviour.Handle(request, next, new CancellationToken()));
        _logger.Verify(
            x => x.Log(
                LogLevel.Error,
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((v, t) => true),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Never);
    }

    [Test]
    public void ShouldLogErrorAndRethrowExceptionForFailedRequest()
    {
        var request = new CreateContactCommand(ContactType.GitHub, "github", "@github-user", "https://theuselessweb.site/nooooooooooooooo/");
        var exception = new Exception("Test exception");
        var next = new RequestHandlerDelegate<Guid>(() => throw exception);

        var ex = Assert.ThrowsAsync<Exception>(() => _unhandledExceptionBehaviour.Handle(request, next, new CancellationToken()));
        Assert.That(ex, Is.EqualTo(exception));
        
        _logger.Verify(
            x => x.Log(
                LogLevel.Error,
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((v, t) => true),
                It.Is<Exception>(e => e == exception),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Once);
    }
}
