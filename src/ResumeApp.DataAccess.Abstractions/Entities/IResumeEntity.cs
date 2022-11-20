namespace ResumeApp.DataAccess.Abstractions.Entities
{
	public interface IResumeEntity
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Title { get; set; }

		public string Summary { get; set; }

		public ICollection<IContactEntity> Contacts { get; set; }

		public ICollection<ISkillEntity> Skills { get; set; }

		public ICollection<IExperienceEntity> Experience { get; set; }

		public ICollection<ICertificationEntity> Certifications { get; set; }

		public ICollection<IEducationEntity> Education { get; set; }
	}
}
