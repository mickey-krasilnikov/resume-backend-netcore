using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CertificationApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class CertificationMapper
    {
        internal static Certification ToDto<TCertificationEntity>(this TCertificationEntity entity)
        {
            if (typeof(TCertificationEntity) == typeof(CertificationMongoEntity)) return (entity as CertificationMongoEntity).ToCertificationDto();
            else if (typeof(TCertificationEntity) == typeof(CertificationSqlEntity)) return (entity as CertificationSqlEntity).ToCertificationDto();
            else throw new NotSupportedException($"Type '{typeof(TCertificationEntity)}' is not supported by Certification mapper");
        }

        internal static TCertificationEntity ToEntity<TCertificationEntity>(this Certification dto)
        {
            if (typeof(TCertificationEntity) == typeof(CertificationMongoEntity)) return (TCertificationEntity)Convert.ChangeType(dto.ToCertificationMongoEntity(), typeof(TCertificationEntity));
            else if (typeof(TCertificationEntity) == typeof(CertificationSqlEntity)) return (TCertificationEntity)Convert.ChangeType(dto.ToCertificationSqlEntity(), typeof(TCertificationEntity));
            else throw new NotSupportedException($"Type '{typeof(TCertificationEntity)}' is not supported by Certification mapper");
        }


        internal static Certification ToDto(this CertificationSqlEntity entity)
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

		internal static Certification ToDto(this CertificationMongoEntity entity)
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


        internal static CertificationMongoEntity ToMongoEntity(this Certification dto)
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

		internal static CertificationSqlEntity ToSqlEntity(this Certification dto)
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
