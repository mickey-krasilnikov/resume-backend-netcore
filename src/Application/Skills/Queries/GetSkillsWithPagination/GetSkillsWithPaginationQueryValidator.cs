namespace ResumeApp.Application.Skills.Queries.GetSkillsWithPagination;

public class GetSkillsWithPaginationQueryValidator : AbstractValidator<GetSkillsWithPaginationQuery>
{
    public GetSkillsWithPaginationQueryValidator()
    {
        RuleFor(x => x.PageNumber).GreaterThanOrEqualTo(1).WithMessage("PageNumber at least greater than or equal to 1.");
        RuleFor(x => x.PageSize).GreaterThanOrEqualTo(1).WithMessage("PageSize at least greater than or equal to 1.");
    }
}
