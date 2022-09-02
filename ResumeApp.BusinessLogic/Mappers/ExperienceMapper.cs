using ResumeApp.DataAccess.MongoDb.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ExperienceMapper
	{
		internal static Experience ToExperienceDto(this ExperienceMongoEntity entity)
		{
			return new Experience
			{
				Title = entity.Title,
				Company = entity.Company,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Projects = entity.Projects.ConvertAll(s => s.ToProjectDto())
			};
		}

		internal static ExperienceMongoEntity ToExperienceEntity(this Experience dto)
		{
			return new ExperienceMongoEntity
			{
				Title = dto.Title,
				Company = dto.Company,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Projects = dto.Projects.ConvertAll(s => s.ToProjectEntity())
			};
		}
	}
}
