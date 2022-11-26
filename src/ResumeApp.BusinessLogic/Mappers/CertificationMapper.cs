using ResumeApp.DataAccess.Abstractions.Entities;
using ResumeApp.DataAccess.Abstractions.Enums;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
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

		internal static ICertificationEntity ToCertificationEntity(this Certification dto, SupportedDbType dbType)
		{
			return dbType switch
			{
				SupportedDbType.Mongo => dto.ToCertificationMongoEntity(),
				SupportedDbType.MsSql => dto.ToCertificationSqlEntity(),
				_ => throw new NotSupportedException($"{dbType} DB type is not supported"),
			};
		}

		private static ICertificationEntity ToCertificationMongoEntity(this Certification dto)
		{
			if (dto == null) return null;
			return new CertificationMongoEntity
			{
				Name = dto.Name,
				Issuer = dto.Issuer,
				IssueDate = dto.IssueDate,
				ExpirationDate = dto.ExpirationDate,
				VerificationUrl = dto.VerificationUrl
			};
		}

		private static ICertificationEntity ToCertificationSqlEntity(this Certification dto)
		{
			if (dto == null) return null;
			return new CertificationSqlEntity
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
