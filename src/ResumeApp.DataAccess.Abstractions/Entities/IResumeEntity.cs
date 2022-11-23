namespace ResumeApp.DataAccess.Abstractions.Entities
{
	public interface IResumeEntity
	{
		Guid Id { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		string Title { get; set; }
		string Summary { get; set; }
		IEnumerable<IContactEntity> Contacts { get; set; }
		IEnumerable<ISkillEntity> Skills { get; set; }
		IEnumerable<IExperienceEntity> Experience { get; set; }
		IEnumerable<ICertificationEntity> Certifications { get; set; }
		IEnumerable<IEducationEntity> Education { get; set; }
	}
}