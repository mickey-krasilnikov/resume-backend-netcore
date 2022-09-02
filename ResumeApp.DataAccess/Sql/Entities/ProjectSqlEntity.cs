using System.ComponentModel.DataAnnotations;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ProjectSqlEntity : SqlEntityBase
	{
		[Key]
		public int Id { get; set; }
		public string Client { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public ICollection<string> ProjectRole { get; set; } = new List<string>(); // TODO: Separate table
		public ICollection<string> Envirnment { get; set; } = new List<string>();// TODO: Separate table
		public ICollection<string> TaskPerformed { get; set; } = new List<string>();// TODO: Separate table
	}
}
