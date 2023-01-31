using Moq;
using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;

namespace ResumeApp.UnitTests.Mappers
{
	public class GenericMapperTests
	{
		[Fact]
		public void ToDto_WithCertificationSqlEntity_ReturnsCertificationDto()
		{
			// Arrange
			var mockEntity = new Mock<CertificationSqlEntity>();
			mockEntity.Setup(x => x.ToDto()).Returns(new CertificationDto());

			// Act
			var result = mockEntity.Object.ToDto<CertificationDto, CertificationSqlEntity>();

			// Assert
			Assert.IsType<CertificationDto>(result);
		}

		[Fact]
		public void ToDto_WithCertificationMongoEntity_ReturnsCertificationDto()
		{
			// Arrange
			var mockEntity = new Mock<CertificationMongoEntity>();
			mockEntity.Setup(x => x.ToDto()).Returns(new CertificationDto());

			// Act
			var result = mockEntity.Object.ToDto<CertificationDto, CertificationMongoEntity>();

			// Assert
			Assert.IsType<CertificationDto>(result);
		}

		[Fact]
		public void ToDto_WithEducationSqlEntity_ReturnsEducationDto()
		{
			// Arrange
			var mockEntity = new Mock<EducationSqlEntity>();
			mockEntity.Setup(x => x.ToDto()).Returns(new EducationDto());

			// Act
			var result = mockEntity.Object.ToDto<EducationDto, EducationSqlEntity>();

			// Assert
			Assert.IsType<EducationDto>(result);
		}

		[Fact]
		public void ToDto_WithEducationMongoEntity_ReturnsEducationDto()
		{
			// Arrange
			var mockEntity = new Mock<EducationMongoEntity>();
			mockEntity.Setup(x => x.ToDto()).Returns(new EducationDto());

			// Act
			var result = mockEntity.Object.ToDto<EducationDto, EducationMongoEntity>();

			// Assert
			Assert.IsType<EducationDto>(result);
		}

		[Fact]
		public void ToDto_WithExperienceSqlEntity_ReturnsExperienceDto()
		{
			// Arrange
			var mockEntity = new Mock<ExperienceSqlEntity>();
			mockEntity.Setup(x => x.ToDto()).Returns(new ExperienceDto());

			// Act
			var result = mockEntity.Object.ToDto<ExperienceDto, ExperienceSqlEntity>();

			// Assert
			Assert.IsType<ExperienceDto>(result);
		}
	}
}
