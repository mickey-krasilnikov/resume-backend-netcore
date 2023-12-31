
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Moq;
using NUnit.Framework;
using ResumeApp.Application.Common.Behaviours;
using ResumeApp.Application.Contacts.Commands.CreateContact;
using ResumeApp.Domain.Enums;
using ValidationException = ResumeApp.Application.Common.Exceptions.ValidationException;

namespace ResumeApp.Application.UnitTests.Common.Behaviours;

[TestFixture]
public class ValidationBehaviourTests
{
    private Mock<IValidator<CreateContactCommand>> _validator = null!;
    private ValidationBehaviour<CreateContactCommand, Guid> _validationBehaviour = null!;

    [SetUp]
    public void SetUp()
    {
        _validator = new Mock<IValidator<CreateContactCommand>>();
        _validationBehaviour = new ValidationBehaviour<CreateContactCommand, Guid>(new[] { _validator.Object });
    }

    [Test]
    public void ShouldProceedNextWhenNoValidationErrors()
    {
        _validator.Setup(v => v.ValidateAsync(It.IsAny<ValidationContext<CreateContactCommand>>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        var next = new RequestHandlerDelegate<Guid>(() => Task.FromResult(new Guid()));

        Assert.DoesNotThrowAsync(() => _validationBehaviour.Handle(
            new CreateContactCommand(ContactType.GitHub, "github", "@github-user", "https://theuselessweb.site/nooooooooooooooo/"), 
            next, 
            new CancellationToken()));
    }

    [Test]
    public void ShouldThrowValidationExceptionWhenValidationErrorsExist()
    {
        var validationFailures = new List<ValidationFailure> { new ValidationFailure("Property", "Error") };
        _validator.Setup(v => v.ValidateAsync(It.IsAny<ValidationContext<CreateContactCommand>>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(validationFailures));
        var next = new RequestHandlerDelegate<Guid>(() => Task.FromResult(new Guid()));

        Assert.ThrowsAsync<ValidationException>(() => _validationBehaviour.Handle(
            new CreateContactCommand(ContactType.GitHub, "github", "@github-user", "https://theuselessweb.site/nooooooooooooooo/"), 
            next, 
            new CancellationToken()));
    }
}
