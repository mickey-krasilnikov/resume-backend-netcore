using System.ComponentModel.DataAnnotations;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class SkillSqlEntity : SqlEntityBase
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string AdditionalInfo { get; set; }
		public SkillSqlEntity Parent { get; set; }
		public ICollection<SkillSqlEntity> Children { get; set; } = new List<SkillSqlEntity>();
	}
}
