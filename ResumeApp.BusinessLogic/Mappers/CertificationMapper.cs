//using ResumeApp.DataAccess.Abstractions.Entities;
//using ResumeApp.Poco;

//namespace ResumeApp.BusinessLogic.Mappers
//{
//	internal static class CertificationMapper
//	{
//		internal static Certification ToCertificationDto(this ICertificationEntity entity)
//		{
//			if (entity == null) return null!;

//			return new Certification
//			{
//				Name = entity.Name,
//				Issuer = entity.Issuer,
//				IssueDate = entity.IssueDate,
//				ExpirationDate = entity.ExpirationDate,
//				VerificationURL = entity.VerificationURL
//			};
//		}

//		internal static ICertificationEntity ToCertificationEntity(this Certification dto)
//		{
//			if (dto == null) return null!;

//			return new ICertificationEntity
//			{
//				Name = dto.Name,
//				Issuer = dto.Issuer,
//				IssueDate = dto.IssueDate,
//				ExpirationDate = dto.ExpirationDate,
//				VerificationURL = dto.VerificationURL
//			};
//		}

//	}
//}
