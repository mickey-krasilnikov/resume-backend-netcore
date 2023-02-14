using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
    public class SkillSqlEntity
	{
		public SkillSqlEntity()
		{
            SkillExperienceMapping = new HashSet<SkillExperienceMappingSqlEntity>();
		}

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string SkillGroup { get; set; }


		public virtual ICollection<SkillExperienceMappingSqlEntity> SkillExperienceMapping { get; set; }
	}
}
