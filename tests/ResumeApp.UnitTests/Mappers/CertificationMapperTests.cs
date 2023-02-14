using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;

namespace ResumeApp.UnitTests.Mappers
{
	public class CertificationMapperTests
	{
		public static IEnumerable<object[]> TestData => new List<object[]>
		{
			new object[] { Guid.Empty, null, null, new DateOnly(), null, null },
			new object[] { Guid.Empty, string.Empty, string.Empty, new DateOnly(), new DateOnly(), null },
			new object[] { Guid.NewGuid(), "TestCertificate", "TestIssuer", DateOnly.FromDateTime(DateTime.UtcNow), DateOnly.FromDateTime(DateTime.UtcNow.AddYears(2)), new Uri("http://fake_url") }
		};

		[Theory]
		[MemberData(nameof(TestData))]
		public void MongoEntityToDto(Guid id, string name, string issuer, DateOnly issueDate, DateOnly? expirationDate, Uri verificationUrl)
		{
			//Arrange
			var entity = new CertificationMongoEntity
			{
				Id = id,
				Name = name,
				Issuer = issuer,
				IssueDate = issueDate,
				ExpirationDate = expirationDate,
				VerificationUrl = verificationUrl
			};

			//Act
			var result = entity.ToDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(name, result.Name);
			Assert.Equal(issuer, result.Issuer);
			Assert.Equal(issueDate, result.IssueDate);
			Assert.Equal(expirationDate, result.ExpirationDate);
			Assert.Equal(verificationUrl, result.VerificationUrl);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void SqlEntityToDto(Guid id, string name, string issuer, DateOnly issueDate, DateOnly? expirationDate, Uri verificationUrl)
		{
			//Arrange
			var entity = new CertificationSqlEntity
			{
				Id = id,
				Name = name,
				Issuer = issuer,
				IssueDate = issueDate,
				ExpirationDate = expirationDate,
				VerificationUrl = verificationUrl
			};

			//Act
			var result = entity.ToDto();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(name, result.Name);
			Assert.Equal(issuer, result.Issuer);
			Assert.Equal(issueDate, result.IssueDate);
			Assert.Equal(expirationDate, result.ExpirationDate);
			Assert.Equal(verificationUrl, result.VerificationUrl);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void CertificationDtoToMongoEntity(Guid id, string name, string issuer, DateOnly issueDate, DateOnly? expirationDate, Uri verificationUrl)
		{
			//Arrange
			var dto = new CertificationDto
			{
				Id = id,
				Name = name,
				Issuer = issuer,
				IssueDate = issueDate,
				ExpirationDate = expirationDate,
				VerificationUrl = verificationUrl
			};

			//Act
			var result = dto.ToMongoEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(name, result.Name);
			Assert.Equal(issuer, result.Issuer);
			Assert.Equal(issueDate, result.IssueDate);
			Assert.Equal(expirationDate, result.ExpirationDate);
			Assert.Equal(verificationUrl, result.VerificationUrl);
		}

		[Theory]
		[MemberData(nameof(TestData))]
		public void CertificationDtoToSqlEntity(Guid id, string name, string issuer, DateOnly issueDate, DateOnly? expirationDate, Uri verificationUrl)
		{
			//Arrange
			var dto = new CertificationDto
			{
				Id = id,
				Name = name,
				Issuer = issuer,
				IssueDate = issueDate,
				ExpirationDate = expirationDate,
				VerificationUrl = verificationUrl
			};

			//Act
			var result = dto.ToSqlEntity();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(id, result.Id);
			Assert.Equal(name, result.Name);
			Assert.Equal(issuer, result.Issuer);
			Assert.Equal(issueDate, result.IssueDate);
			Assert.Equal(expirationDate, result.ExpirationDate);
			Assert.Equal(verificationUrl, result.VerificationUrl);
		}
	}
}
