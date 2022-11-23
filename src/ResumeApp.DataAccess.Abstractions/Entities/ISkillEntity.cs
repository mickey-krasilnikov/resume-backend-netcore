namespace ResumeApp.DataAccess.Abstractions.Entities
{
	public interface ISkillEntity
	{
		Guid Id { get; set; }
		string Name { get; set; }
		string AdditionalInfo { get; set; }
		string SkillGroup { get; set; }
	}
}