using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Application.Skills.Commands.CreateSkill;

public class CreateSkillCommandValidator : AbstractValidator<CreateSkillCommand>
{
    private readonly IApplicationDbContext _context;
    
    public CreateSkillCommandValidator(IApplicationDbContext context)
    {
        _context = context;
        RuleFor(v => v.Name).MaximumLength(200).MustAsync(BeUniqueSkill).NotEmpty();
        RuleFor(v => v.SkillGroup).MaximumLength(200).NotEmpty();
    }
    
    private async Task<bool> BeUniqueSkill(string name, CancellationToken cancellationToken)
    {
        return await _context.Skills.AllAsync(l => l.Name != name, cancellationToken);
    }
}
