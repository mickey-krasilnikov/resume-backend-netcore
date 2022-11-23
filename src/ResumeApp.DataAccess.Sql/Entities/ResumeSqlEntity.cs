using ResumeApp.DataAccess.Abstractions.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ResumeSqlEntity : IResumeEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		[Required]
		public string Title { get; set; }

		public string Summary { get; set; }

		public IEnumerable<IContactEntity> Contacts { get; set; } = new HashSet<ContactSqlEntity>();

		public IEnumerable<ISkillEntity> Skills { get; set; } = new HashSet<SkillSqlEntity>();

		public IEnumerable<IExperienceEntity> Experience { get; set; } = new HashSet<ExperienceSqlEntity>();

		public IEnumerable<ICertificationEntity> Certifications { get; set; } = new HashSet<CertificationSqlEntity>();

		public IEnumerable<IEducationEntity> Education { get; set; } = new HashSet<EducationSqlEntity>();
	}
}
