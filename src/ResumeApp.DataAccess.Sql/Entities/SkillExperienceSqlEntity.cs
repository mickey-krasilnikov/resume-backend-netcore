namespace ResumeApp.DataAccess.Sql.Entities
{
    public class SkillExperienceSqlEntity
    {
        public int SkillId { get; set; }
        public SkillSqlEntity Skill { get; set; }
        public int ExperienceId { get; set; }
        public ExperienceSqlEntity Experience { get; set; }
    }
}
