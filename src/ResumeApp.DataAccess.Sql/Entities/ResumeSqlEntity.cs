using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ResumeSqlEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		[Required]
		public string Title { get; set; }

		public string Summary { get; set; }

		public ICollection<ContactSqlEntity> Contacts { get; set; } = new HashSet<ContactSqlEntity>();

		public ICollection<SkillSqlEntity> Skills { get; set; } = new HashSet<SkillSqlEntity>();

		public ICollection<ExperienceSqlEntity> Experience { get; set; } = new HashSet<ExperienceSqlEntity>();

		public ICollection<CertificationSqlEntity> Certifications { get; set; } = new HashSet<CertificationSqlEntity>();

		public ICollection<EducationSqlEntity> Education { get; set; } = new HashSet<EducationSqlEntity>();
	}
}
