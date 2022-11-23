using ResumeApp.DataAccess.Abstractions.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class SkillSqlEntity : ISkillEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string AdditionalInfo { get; set; }

		public string SkillGroup { get; set; }


		public Guid ResumeId { get; internal set; }

		public ResumeSqlEntity Resume { get; set; }
	}
}
