using ResumeApp.Domain.Enums;

namespace ResumeApp.Application.Contacts.Commands.UpdateContact;

public class UpdateContactCommandValidator : AbstractValidator<UpdateContactCommand>
{
    public UpdateContactCommandValidator()
    {
        RuleFor(v => v.Id).NotEqual(Guid.Empty);
        RuleFor(v => v.Type).NotEqual(ContactType.Undefined);
        RuleFor(v => v.Key).MaximumLength(200).NotEmpty();
        RuleFor(v => v.Value).MaximumLength(200).NotEmpty();
        RuleFor(v => v.Link).MaximumLength(200).NotEmpty();
    }
}
