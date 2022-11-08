namespace ResumeApp.DataAccess.Abstractions.Entities
{
	public interface ISkillEntity
	{
		public string Name { get; set; }
		public string AdditionalInfo { get; set; }
		public ICollection<ISkillEntity> Children { get; set; }
	}
}
