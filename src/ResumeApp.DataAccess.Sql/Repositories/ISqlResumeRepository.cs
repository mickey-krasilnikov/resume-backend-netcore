using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Sql.Entities;

namespace ResumeApp.DataAccess.Sql.Repositories
{
	public interface ISqlResumeRepository : IRepository<ResumeSqlEntity> { }
}