using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ResumeApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class ContactMapper
	{
        internal static ContactDto ToDto(this ContactMongoEntity entity)
		{
            if (entity == null) return null;

            return new ContactDto
            {
                Id = entity.Id,
                Key = entity.Key,
                Value = entity.Value,
                Link = entity.Link
            };
        }

		internal static ContactDto ToDto(this ContactSqlEntity entity)
		{
			if (entity == null) return null;

			return new ContactDto
            {
                Id = entity.Id,
                Key = entity.Key,
                Value = entity.Value,
                Link = entity.Link
            };
		}

		internal static ContactMongoEntity ToMongoEntity(this ContactDto dto)
		{
			if (dto == null) return null;
			return new ContactMongoEntity
			{
                Id = dto.Id,
                Key = dto.Key,
                Value = dto.Value,
                Link = dto.Link
            };
		}

		internal static ContactSqlEntity ToSqlEntity(this ContactDto dto)
		{
			if (dto == null) return null;
			return new ContactSqlEntity
			{
				Id = dto.Id,
				Key = dto.Key,
				Value = dto.Value,
                Link = dto.Link
			};
		}
	}
}
