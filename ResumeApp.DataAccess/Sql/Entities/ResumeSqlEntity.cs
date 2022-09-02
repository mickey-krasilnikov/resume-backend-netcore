using System.ComponentModel.DataAnnotations;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ResumeSqlEntity : SqlEntityBase
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		[Required]
		public string Title { get; set; }

		public ICollection<ContactSqlEntity> Contacts { get; set; } = new List<ContactSqlEntity>();

		public ICollection<SummarySqlEntity> Summary { get; set; } = new List<SummarySqlEntity>();

		public ICollection<SkillSqlEntity> Skills { get; set; } = new List<SkillSqlEntity>();

		public ICollection<ExperienceSqlEntity> Experience { get; set; } = new List<ExperienceSqlEntity>();

		public ICollection<CertificationSqlEntity> Certifications { get; set; } = new List<CertificationSqlEntity>();

		public ICollection<EducationSqlEntity> Education { get; set; } = new List<EducationSqlEntity>();
	}
}
