//using ResumeApp.DataAccess.Abstractions.Entities;
//using ResumeApp.Poco;

//namespace ResumeApp.BusinessLogic.Mappers
//{
//	internal static class EducationMapper
//	{
//		internal static Education ToEducationDto(this IEducationEntity entity)
//		{
//			if (entity == null) return null!;

//			return new Education
//			{
//				Name = entity.Name,
//				Degree = entity.Degree,
//				FieldOfStudy = entity.FieldOfStudy,
//				StartDate = entity.StartDate,
//				EndDate = entity.EndDate,
//				Url = entity.Url
//			};
//		}

//		internal static IEducationEntity ToEducationEntity(this Education dto)
//		{
//			if (dto == null) return null!;

//			return new IEducationEntity
//			{
//				Name = dto.Name,
//				Degree = dto.Degree,
//				FieldOfStudy = dto.FieldOfStudy,
//				StartDate = dto.StartDate,
//				EndDate = dto.EndDate,
//				Url = dto.Url
//			};
//		}
//	}
//}
