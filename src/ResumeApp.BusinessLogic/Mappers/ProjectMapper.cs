//using ResumeApp.DataAccess.Abstractions.Entities;
//using ResumeApp.Poco;

//namespace ResumeApp.BusinessLogic.Mappers
//{
//	internal static class ProjectMapper
//	{
//		internal static Project ToProjectDto(this IProjectEntity entity)
//		{
//			if (entity == null) return null!;

//			return new Project
//			{
//				Client = entity.Client,
//				StartDate = entity.StartDate,
//				EndDate = entity.EndDate,
//				Envirnment = entity.Envirnment,
//				ProjectRole = entity.ProjectRole,
//				TaskPerformed = entity.TaskPerformed
//			};
//		}

//		internal static IProjectEntity ToProjectEntity(this Project dto)
//		{
//			if (dto == null) return null!;

//			return new IProjectEntity
//			{
//				Client = dto.Client,
//				StartDate = dto.StartDate,
//				EndDate = dto.EndDate,
//				Envirnment = dto.Envirnment,
//				ProjectRole = dto.ProjectRole,
//				TaskPerformed = dto.TaskPerformed
//			};
//		}
//	}
//}
