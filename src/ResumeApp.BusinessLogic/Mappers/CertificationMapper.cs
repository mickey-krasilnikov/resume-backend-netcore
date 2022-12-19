using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ResumeApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class CertificationMapper
	{
		internal static Certification ToCertificationDto(this CertificationSqlEntity entity)
		{
			if (entity == null) return null;
			return new Certification
			{
				Id = entity.Id,
				Name = entity.Name,
				Issuer = entity.Issuer,
				IssueDate = entity.IssueDate,
				ExpirationDate = entity.ExpirationDate,
				VerificationUrl = entity.VerificationUrl
			};
		}

		internal static Certification ToCertificationDto(this CertificationMongoEntity entity)
		{
			if (entity == null) return null;
			return new Certification
			{
				Id = entity.Id,
				Name = entity.Name,
				Issuer = entity.Issuer,
				IssueDate = entity.IssueDate,
				ExpirationDate = entity.ExpirationDate,
				VerificationUrl = entity.VerificationUrl
			};
		}

		internal static CertificationMongoEntity ToCertificationMongoEntity(this Certification dto)
		{
			if (dto == null) return null;
			return new CertificationMongoEntity
			{
				Id = dto.Id,
				Name = dto.Name,
				Issuer = dto.Issuer,
				IssueDate = dto.IssueDate,
				ExpirationDate = dto.ExpirationDate,
				VerificationUrl = dto.VerificationUrl
			};
		}

		internal static CertificationSqlEntity ToCertificationSqlEntity(this Certification dto)
		{
			if (dto == null) return null;
			return new CertificationSqlEntity
			{
				Id = dto.Id,
				Name = dto.Name,
				Issuer = dto.Issuer,
				IssueDate = dto.IssueDate,
				ExpirationDate = dto.ExpirationDate,
				VerificationUrl = dto.VerificationUrl
			};
		}
	}
}
