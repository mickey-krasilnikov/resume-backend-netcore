using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CertificationApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class CertificationMapper
    {
        internal static CertificationDto ToDto(this CertificationSqlEntity entity)
		{
			if (entity == null) return null;
			return new CertificationDto
			{
				Id = entity.Id,
				Name = entity.Name,
				Issuer = entity.Issuer,
				IssueDate = entity.IssueDate,
				ExpirationDate = entity.ExpirationDate,
				VerificationUrl = entity.VerificationUrl
			};
		}

		internal static CertificationDto ToDto(this CertificationMongoEntity entity)
		{
			if (entity == null) return null;
			return new CertificationDto
			{
				Id = entity.Id,
				Name = entity.Name,
				Issuer = entity.Issuer,
				IssueDate = entity.IssueDate,
				ExpirationDate = entity.ExpirationDate,
				VerificationUrl = entity.VerificationUrl
			};
		}

        internal static CertificationMongoEntity ToMongoEntity(this CertificationDto dto)
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

		internal static CertificationSqlEntity ToSqlEntity(this CertificationDto dto)
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
