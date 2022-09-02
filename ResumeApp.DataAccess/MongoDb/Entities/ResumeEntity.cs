using ResumeApp.DataAccess.MongoDb.Attributes;

namespace ResumeApp.DataAccess.MongoDb.Entities
{
	[BsonCollection("resumes")]
	public class ResumeEntity : MongoEntityBase
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public Dictionary<string, string> Contacts { get; set; }
		public List<string> Summary { get; set; }
		public List<SkillGroupEntity> Skills { get; set; }
		public List<ExperienceEntity> Experience { get; set; }
		public List<CertificationEntity> Certifications { get; set; }
		public List<EducationEntity> Education { get; set; }
	}
}