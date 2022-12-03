using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class EducationSqlEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Degree { get; set; }

		public string FieldOfStudy { get; set; }

		public DateOnly StartDate { get; set; }

		public DateOnly EndDate { get; set; }

		public Uri Url { get; set; }


		public Guid ResumeId { get; internal set; }

		public ResumeSqlEntity Resume { get; set; }
	}
}
