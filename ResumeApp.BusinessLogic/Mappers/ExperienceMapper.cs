//using ResumeApp.DataAccess.Abstractions.Entities;
//using ResumeApp.Poco;

//namespace ResumeApp.BusinessLogic.Mappers
//{
//	internal static class ExperienceMapper
//	{
//		internal static Experience ToExperienceDto(this IExperienceEntity entity)
//		{
//			return new Experience
//			{
//				Title = entity.Title,
//				Company = entity.Company,
//				StartDate = entity.StartDate,
//				EndDate = entity.EndDate,
//				Projects = entity.Projects.ConvertAll(s => s.ToProjectDto())
//			};
//		}

//		internal static IExperienceEntity ToExperienceEntity(this Experience dto)
//		{
//			return new IExperienceEntity
//			{
//				Title = dto.Title,
//				Company = dto.Company,
//				StartDate = dto.StartDate,
//				EndDate = dto.EndDate,
//				Projects = dto.Projects.ConvertAll(s => s.ToProjectEntity())
//			};
//		}
//	}
//}
