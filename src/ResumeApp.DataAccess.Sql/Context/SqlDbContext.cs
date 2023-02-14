using Microsoft.EntityFrameworkCore;
using ResumeApp.DataAccess.Sql.Context.Converters;
using ResumeApp.DataAccess.Sql.Context.InitialData;
using ResumeApp.DataAccess.Sql.Entities;

namespace ResumeApp.DataAccess.Sql.Context
{
	public class SqlDbContext : DbContext, ISqlDbContext
	{
		public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options) { }

		public DbSet<CertificationSqlEntity> Certifications { get; set; }
		public DbSet<ContactSqlEntity> Contacts { get; set; }
		public DbSet<EducationSqlEntity> Educations { get; set; }
		public DbSet<ExperienceSqlEntity> Experiences { get; set; }
		public DbSet<SkillSqlEntity> Skills { get; set; }
		public DbSet<SkillExperienceMappingSqlEntity> SkillExperienceMappings { get; set; }

		protected override void ConfigureConventions(ModelConfigurationBuilder builder)
		{
			builder.Properties<DateOnly>()
				.HaveConversion<DateOnlyConverter>()
				.HaveColumnType("date");

			builder.Properties<DateOnly?>()
				.HaveConversion<NullableDateOnlyConverter>()
				.HaveColumnType("date");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SkillExperienceMappingSqlEntity>()
				.HasKey(bc => new { bc.SkillId, bc.ExperienceId });

			modelBuilder.Entity<SkillExperienceMappingSqlEntity>()
				.HasOne(bc => bc.Skill)
				.WithMany(b => b.SkillExperienceMapping)
				.HasForeignKey(bc => bc.SkillId);

			modelBuilder.Entity<SkillExperienceMappingSqlEntity>()
				.HasOne(bc => bc.Experience)
				.WithMany(c => c.SkillExperienceMapping)
				.HasForeignKey(bc => bc.ExperienceId);

			// seed the database with initial data
			var dataToSeed = InitialDataGenerator.GetDataToSeed();
			modelBuilder.Entity<CertificationSqlEntity>().HasData(dataToSeed.Certification);
			modelBuilder.Entity<ContactSqlEntity>().HasData(dataToSeed.Contacts);
			modelBuilder.Entity<EducationSqlEntity>().HasData(dataToSeed.Eduction);
			modelBuilder.Entity<ExperienceSqlEntity>().HasData(dataToSeed.Experience);
			modelBuilder.Entity<SkillSqlEntity>().HasData(dataToSeed.Skills);
			modelBuilder.Entity<SkillExperienceMappingSqlEntity>().HasData(dataToSeed.SkillExperienceMapping);

			base.OnModelCreating(modelBuilder);
		}
	}
}
