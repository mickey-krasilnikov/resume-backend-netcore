using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ExperienceSqlEntity
	{
		public ExperienceSqlEntity()
		{
            SkillExperienceMapping = new HashSet<SkillExperienceMappingSqlEntity>();
		}

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Company { get; set; }

		public string Location { get; set; }

		public string TaskPerformed { get; set; }

		public DateOnly StartDate { get; set; }

		public DateOnly? EndDate { get; set; }


		public virtual ICollection<SkillExperienceMappingSqlEntity> SkillExperienceMapping { get; set; }
	}
}
