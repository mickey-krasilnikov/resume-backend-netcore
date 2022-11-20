using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ProjectSqlEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

		public string Client { get; set; }

		public DateOnly StartDate { get; set; }

		public DateOnly EndDate { get; set; }

		public string ProjectRoles { get; set; }

		public string Envirnment { get; set; }

		public string TaskPerformed { get; set; }


		public long ExperienceId { get; internal set; }

		public ExperienceSqlEntity Experience { get; set; }
	}
}
