namespace ResumeApp.DataAccess.Sql.Entities
{
    public class SkillExperienceMappingSqlEntity
    {
        public Guid SkillId { get; set; }
        public SkillSqlEntity Skill { get; set; }
        public Guid ExperienceId { get; set; }
        public ExperienceSqlEntity Experience { get; set; }
    }
}
