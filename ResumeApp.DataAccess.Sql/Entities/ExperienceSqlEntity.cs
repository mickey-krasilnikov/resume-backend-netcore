using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ExperienceSqlEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

		public string Title { get; set; }

		public string Company { get; set; }

		public DateOnly StartDate { get; set; }

		public DateOnly EndDate { get; set; }


		public long ResumeId { get; internal set; }

		public ResumeSqlEntity Resume { get; set; }

		public ICollection<ProjectSqlEntity> Projects { get; set; } = new HashSet<ProjectSqlEntity>();
	}
}
