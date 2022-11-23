using ResumeApp.DataAccess.Abstractions.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ExperienceSqlEntity : IExperienceEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Company { get; set; }

		public DateOnly StartDate { get; set; }

		public DateOnly? EndDate { get; set; }

		public bool IsCurrentCompany { get; set; }

		public Guid ResumeId { get; internal set; }

		public ResumeSqlEntity Resume { get; set; }

		public IEnumerable<IProjectEntity> Projects { get; set; } = new HashSet<ProjectSqlEntity>();
	}
}
