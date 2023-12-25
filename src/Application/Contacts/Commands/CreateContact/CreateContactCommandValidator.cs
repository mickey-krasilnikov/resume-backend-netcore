using ResumeApp.Application.Common.Interfaces;
using ResumeApp.Domain.Enums;

namespace ResumeApp.Application.Contacts.Commands.CreateContact;

public class CreateContactCommandValidator : AbstractValidator<CreateContactCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateContactCommandValidator(IApplicationDbContext context)
    {
        _context = context;
        RuleFor(v => v.Key).NotEmpty().MaximumLength(200).MustAsync(BeUniqueContact).WithMessage("'{PropertyName}' must be unique.").WithErrorCode("Unique");
        RuleFor(v => v.Type).NotEqual(ContactType.Undefined).NotEmpty();
        RuleFor(v => v.Value).MaximumLength(200).NotEmpty();
        RuleFor(v => v.Link).MaximumLength(200).NotEmpty();
    }
    
    private async Task<bool> BeUniqueContact(string key, CancellationToken cancellationToken)
    {
        return await _context.Contacts.AllAsync(l => l.Key != key, cancellationToken);
    }
}
