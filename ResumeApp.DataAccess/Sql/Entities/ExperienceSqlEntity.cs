using System.ComponentModel.DataAnnotations;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ExperienceSqlEntity : SqlEntityBase
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Company { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public ICollection<ProjectSqlEntity> Projects { get; set; } = new List<ProjectSqlEntity>();
	}
}
