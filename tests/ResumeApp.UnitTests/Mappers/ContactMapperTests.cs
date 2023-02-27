using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;

namespace ResumeApp.UnitTests.Mappers
{
	public class ContactMapperTests
	{
		public static IEnumerable<object[]> TestData => new List<object[]>
		{
			new object[] { Guid.Empty, null, null, null },
			new object[] { Guid.Empty, string.Empty, string.Empty, null },
			new object[] { Guid.NewGuid(), "TestContactKey", "TestContactValue", "http://fake_link" }
		};

		[Theory]
		[MemberData(nameof(TestData))]
		public void MongoEntityToDto(Guid id, string key, string value, string link)
		{
			//Arrange
			var entity = new ContactMongoEntity
            {
                Id = id,
                Key = key,
				Value = value,
				Link = link
            };

			//Act
			var result = entity.ToDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(key, result.Key);
			Assert.Equal(value, result.Value);
			Assert.Equal(link, result.Link);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void SqlEntityToDto(Guid id, string key, string value, string link)
		{
			//Arrange
			var entity = new ContactSqlEntity
            {
                Id = id,
                Key = key,
                Value = value,
                Link = link
            };

			//Act
			var result = entity.ToDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(key, result.Key);
			Assert.Equal(value, result.Value);
			Assert.Equal(link, result.Link);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void ContactDtoToMongoEntity(Guid id, string key, string value, string link)
		{
			//Arrange
			var dto = new ContactDto
            {
                Id = id,
                Key = key,
                Value = value,
                Link = link
            };

			//Act
			var result = dto.ToMongoEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(key, result.Key);
			Assert.Equal(value, result.Value);
			Assert.Equal(link, result.Link);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void ContactDtoToSqlEntity(Guid id, string key, string value, string link)
		{
			//Arrange
			var dto = new ContactDto
            {
                Id = id,
                Key = key,
                Value = value,
                Link = link
            };

			//Act
			var result = dto.ToSqlEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(key, result.Key);
			Assert.Equal(value, result.Value);
			Assert.Equal(link, result.Link);
		}
	}
}
