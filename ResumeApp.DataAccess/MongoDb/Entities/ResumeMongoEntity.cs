using ResumeApp.DataAccess.MongoDb.Attributes;

namespace ResumeApp.DataAccess.MongoDb.Entities
{
	[BsonCollection("resumes")]
	public class ResumeMongoEntity : MongoEntityBase
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Title { get; set; }

		public Dictionary<string, string> Contacts { get; set; }

		public List<string> Summary { get; set; }

		public List<SkillMongoEntity> Skills { get; set; }

		public List<ExperienceMongoEntity> Experience { get; set; }

		public List<CertificationMongoEntity> Certifications { get; set; }

		public List<EducationMongoEntity> Education { get; set; }
	}
}