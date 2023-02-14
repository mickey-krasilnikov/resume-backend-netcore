using Microsoft.EntityFrameworkCore;
using ResumeApp.DataAccess.Sql.Entities;

namespace ResumeApp.DataAccess.Sql.Context
{
	public interface ISqlDbContext : IDisposable
	{
		public DbSet<CertificationSqlEntity> Certifications { get; set; }
		public DbSet<ContactSqlEntity> Contacts { get; set; }
		public DbSet<EducationSqlEntity> Educations { get; set; }
		public DbSet<ExperienceSqlEntity> Experiences { get; set; }
		public DbSet<SkillSqlEntity> Skills { get; set; }

		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
	}
}