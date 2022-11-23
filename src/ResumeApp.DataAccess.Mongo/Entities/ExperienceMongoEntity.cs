using ResumeApp.DataAccess.Abstractions.Entities;

namespace ResumeApp.DataAccess.Mongo.Entities
{
	public class ExperienceMongoEntity : IExperienceEntity
	{
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Company { get; set; }

		public DateOnly StartDate { get; set; }

		public DateOnly? EndDate { get; set; }

		public bool IsCurrentCompany { get; set; }

		public IEnumerable<IProjectEntity> Projects { get; set; } = new HashSet<ProjectMongoEntity>();
	}
}