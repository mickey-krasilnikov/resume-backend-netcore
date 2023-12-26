using MediatR;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using ResumeApp.Application.Common.Behaviours;
using ResumeApp.Application.Contacts.Commands.CreateContact;
using ResumeApp.Application.Skills.Commands.CreateSkill;
using ResumeApp.Domain.Enums;

namespace ResumeApp.Application.UnitTests.Common.Behaviours;

[TestFixture]
public class UnhandledExceptionBehaviourTests
{
    private Mock<ILogger<CreateSkillCommand>> _logger = null!;
    private UnhandledExceptionBehaviour<CreateSkillCommand, Guid> _unhandledExceptionBehaviour = null!;

    [SetUp]
    public void SetUp()
    {
        _logger = new Mock<ILogger<CreateSkillCommand>>();
        _unhandledExceptionBehaviour = new UnhandledExceptionBehaviour<CreateSkillCommand, Guid>(_logger.Object);
    }

    [Test]
    public void ShouldNotLogErrorForSuccessfulRequest()
    {
        var request = new CreateSkillCommand("Test Skill", "Test Skill Group", 1, true);
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
        var request = new CreateSkillCommand("Test Skill", "Test Skill Group", 1, true);
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
