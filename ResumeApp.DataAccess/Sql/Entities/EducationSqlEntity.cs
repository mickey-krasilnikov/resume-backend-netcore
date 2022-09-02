using System.ComponentModel.DataAnnotations;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class EducationSqlEntity : SqlEntityBase
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Degree { get; set; }
		public string FieldOfStudy { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public Uri Url { get; set; }
	}
}
