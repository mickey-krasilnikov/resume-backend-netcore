using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class SkillSqlEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

		public string Name { get; set; }

		public string AdditionalInfo { get; set; }

		public string SkillGroup { get; set; }


		public long ResumeId { get; internal set; }

		public ResumeSqlEntity Resume { get; set; }
	}
}
