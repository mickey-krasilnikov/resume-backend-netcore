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

			// Act
			var result = mockEntity.Object.ToDto<CertificationDto, CertificationSqlEntity>();

			// Assert
			Assert.IsType<CertificationDto>(result);
            Assert.NotNull(result);
        }

		[Fact]
		public void ToDto_WithCertificationMongoEntity_ReturnsCertificationDto()
		{
			// Arrange
			var mockEntity = new Mock<CertificationMongoEntity>();

			// Act
			var result = mockEntity.Object.ToDto<CertificationDto, CertificationMongoEntity>();

			// Assert
			Assert.IsType<CertificationDto>(result);
            Assert.NotNull(result);
        }

		[Fact]
		public void ToDto_WithEducationSqlEntity_ReturnsEducationDto()
		{
			// Arrange
			var mockEntity = new Mock<EducationSqlEntity>();

			// Act
			var result = mockEntity.Object.ToDto<EducationDto, EducationSqlEntity>();

			// Assert
			Assert.IsType<EducationDto>(result);
            Assert.NotNull(result);
        }

		[Fact]
		public void ToDto_WithEducationMongoEntity_ReturnsEducationDto()
		{
			// Arrange
			var mockEntity = new Mock<EducationMongoEntity>();

			// Act
			var result = mockEntity.Object.ToDto<EducationDto, EducationMongoEntity>();

			// Assert
			Assert.IsType<EducationDto>(result);
            Assert.NotNull(result);
        }

		[Fact]
		public void ToDto_WithExperienceSqlEntity_ReturnsExperienceDto()
		{
			// Arrange
			var mockEntity = new Mock<ExperienceSqlEntity>();

			// Act
			var result = mockEntity.Object.ToDto<ExperienceDto, ExperienceSqlEntity>();

			// Assert
			Assert.IsType<ExperienceDto>(result);
            Assert.NotNull(result);
        }

        [Fact]
        public void ToDto_WithExperienceMongoEntity_ReturnsExperienceDto()
        {
            // Arrange
            var mockEntity = new Mock<ExperienceMongoEntity>();

            // Act
            var result = mockEntity.Object.ToDto<ExperienceDto, ExperienceMongoEntity>();

            // Assert
            Assert.IsType<ExperienceDto>(result);
            Assert.NotNull(result);
        }

        [Fact]
        public void ToDto_WithSkillSqlEntity_ReturnsSkillDto()
        {
            // Arrange
            var mockEntity = new Mock<SkillSqlEntity>();

            // Act
            var result = mockEntity.Object.ToDto<SkillDto, SkillSqlEntity>();

            // Assert
            Assert.IsType<SkillDto>(result);
            Assert.NotNull(result);
        }

        [Fact]
        public void ToDto_WithSkillMongoEntity_ReturnsSkillDto()
        {
            // Arrange
            var mockEntity = new Mock<SkillMongoEntity>();

            // Act
            var result = mockEntity.Object.ToDto<SkillDto, SkillMongoEntity>();

            // Assert
            Assert.IsType<SkillDto>(result);
            Assert.NotNull(result);
        }

        [Fact]
        public void ToDto_WithContactSqlEntity_ReturnsContactDto()
        {
            // Arrange
            var mockEntity = new Mock<ContactSqlEntity>();

            // Act
            var result = mockEntity.Object.ToDto<ContactDto, ContactSqlEntity>();

            // Assert
            Assert.IsType<ContactDto>(result);
            Assert.NotNull(result);
        }

        [Fact]
        public void ToDto_WithContactMongoEntity_ReturnsContactDto()
        {
            // Arrange
            var mockEntity = new Mock<ContactMongoEntity>();

            // Act
            var result = mockEntity.Object.ToDto<ContactDto, ContactMongoEntity>();

            // Assert
            Assert.IsType<ContactDto>(result);
            Assert.NotNull(result);
        }
        
		[Fact]
		public void ToEntity_WithCertificationDto_ReturnsCertificationEntity()
		{
			// Arrange
			var mockDto = new Mock<CertificationDto>();

			// Act
			var resultSql = mockDto.Object.ToEntity<CertificationDto, CertificationSqlEntity>();
            var resultMongo = mockDto.Object.ToEntity<CertificationDto, CertificationMongoEntity>();

            // Assert
            Assert.IsType<CertificationSqlEntity>(resultSql);
            Assert.IsType<CertificationMongoEntity>(resultMongo);
            Assert.NotNull(resultSql);
            Assert.NotNull(resultMongo);
        }

		[Fact]
		public void ToEntity_WithEducationDto_ReturnsEducationEntity()
		{
			// Arrange
			var mockDto = new Mock<EducationDto>();

			// Act
			var resultSql = mockDto.Object.ToEntity<EducationDto, EducationSqlEntity>();
            var resultMongo = mockDto.Object.ToEntity<EducationDto, EducationMongoEntity>();

            // Assert
            Assert.IsType<EducationSqlEntity>(resultSql);
            Assert.IsType<EducationMongoEntity>(resultMongo);
            Assert.NotNull(resultSql);
            Assert.NotNull(resultMongo);
        }

		[Fact]
		public void ToEntity_WithExperienceDto_ReturnsExperienceEntity()
		{
			// Arrange
			var mockDto = new Mock<ExperienceDto>();

			// Act
			var resultSql = mockDto.Object.ToEntity<ExperienceDto, ExperienceSqlEntity>();
            var resultMongo = mockDto.Object.ToEntity<ExperienceDto, ExperienceMongoEntity>();

            // Assert
            Assert.IsType<ExperienceSqlEntity>(resultSql);
            Assert.IsType<ExperienceMongoEntity>(resultMongo);
            Assert.NotNull(resultSql);
            Assert.NotNull(resultMongo);
        }

        [Fact]
        public void ToEntity_WithSkillDto_ReturnsSkillEntity()
        {
            // Arrange
            var mockDto = new Mock<SkillDto>();

            // Act
            var resultSql = mockDto.Object.ToEntity<SkillDto, SkillSqlEntity>();
            var resultMongo = mockDto.Object.ToEntity<SkillDto, SkillMongoEntity>();

            // Assert
            Assert.IsType<SkillSqlEntity>(resultSql);
            Assert.IsType<SkillMongoEntity>(resultMongo);
            Assert.NotNull(resultSql);
            Assert.NotNull(resultMongo);
        }

        [Fact]
        public void ToEntity_WithContactDto_ReturnsContactEntity()
        {
            // Arrange
            var mockDto = new Mock<ContactDto>();

            // Act
            var resultSql = mockDto.Object.ToEntity<ContactDto, ContactSqlEntity>();
            var resultMongo = mockDto.Object.ToEntity<ContactDto, ContactMongoEntity>();

            // Assert
            Assert.IsType<ContactSqlEntity>(resultSql);
            Assert.IsType<ContactMongoEntity>(resultMongo);
            Assert.NotNull(resultSql);
            Assert.NotNull(resultMongo);
        }
    }
}
