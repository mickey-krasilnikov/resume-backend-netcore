using ResumeApp.DataAccess.Abstractions.Entities;
using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class CertificationMapper
	{
		internal static Certification ToCertificationDto(this ICertificationEntity entity)
		{
			if (entity == null) return null;

			return new Certification
			{
				Name = entity.Name,
				Issuer = entity.Issuer,
				IssueDate = entity.IssueDate,
				ExpirationDate = entity.ExpirationDate,
				VerificationUrl = entity.VerificationUrl
			};
		}

		internal static TEntity ToCertificationEntity<TEntity>(this Certification dto) where TEntity : class, ICertificationEntity, new()
		{
			if (dto == null) return null;

			return new TEntity
			{
				Name = dto.Name,
				Issuer = dto.Issuer,
				IssueDate = dto.IssueDate,
				ExpirationDate = dto.ExpirationDate,
				VerificationUrl = dto.VerificationUrl
			};
		}

	}
}
