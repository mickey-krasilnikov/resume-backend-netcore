using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Mongo.Entities;

namespace ResumeApp.DataAccess.Mongo.Repositories
{
	public interface IMongoResumeRepository : IRepository<ResumeMongoEntity> { }
}