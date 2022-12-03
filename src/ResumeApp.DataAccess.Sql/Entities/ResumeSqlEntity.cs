using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ResumeSqlEntity
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

		public IEnumerable<ContactSqlEntity> Contacts { get; set; } = new HashSet<ContactSqlEntity>();

		public IEnumerable<SkillSqlEntity> Skills { get; set; } = new HashSet<SkillSqlEntity>();

		public IEnumerable<ExperienceSqlEntity> Experience { get; set; } = new HashSet<ExperienceSqlEntity>();

		public IEnumerable<CertificationSqlEntity> Certifications { get; set; } = new HashSet<CertificationSqlEntity>();

		public IEnumerable<EducationSqlEntity> Education { get; set; } = new HashSet<EducationSqlEntity>();
	}
}
