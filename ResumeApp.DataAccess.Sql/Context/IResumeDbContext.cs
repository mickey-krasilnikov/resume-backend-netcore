using Microsoft.EntityFrameworkCore;
using ResumeApp.DataAccess.Sql.Entities;

namespace ResumeApp.DataAccess.Sql.Context
{
	internal interface IResumeDbContext : IDisposable
	{
		public DbSet<ResumeSqlEntity> Resumes { get; set; }
	}
}