using ResumeApp.BusinessLogic.Mappers;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;

namespace ResumeApp.UnitTests.Mappers
{
    public class EducationMapperTests
    {
        public static IEnumerable<object[]> TestData => new List<object[]>
        {
            new object[] { Guid.Empty, null, null, null, new DateOnly(), null, null },
            new object[] { Guid.Empty, string.Empty, string.Empty, string.Empty, new DateOnly(), new DateOnly(), null },
            new object[] { Guid.NewGuid(), "TestUniversity", "TestDegree", "TestFieldOfStudy", DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-6)), DateOnly.FromDateTime(DateTime.UtcNow), new Uri("http://fake_university_url") }
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void MongoEntityToEducationDto(Guid id, string name, string degree, string fieldOfStudy, DateOnly startDate, DateOnly? endDate, Uri url)
        {
            //Arrange
            var entity = new EducationMongoEntity
            {
                Id = id,
                Name = name,
                Degree = degree,
                FieldOfStudy = fieldOfStudy,
                StartDate = startDate,
                EndDate = endDate,
                Url = url
            };

            //Act
            var result = entity.ToEducationDto();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(id, result.Id);
            Assert.Equal(name, result.Name);
            Assert.Equal(degree, result.Degree);
            Assert.Equal(fieldOfStudy, result.FieldOfStudy);
            Assert.Equal(startDate, result.StartDate);
            Assert.Equal(endDate, result.EndDate);
            Assert.Equal(url, result.Url);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void SqlEntityToEducationDto(Guid id, string name, string degree, string fieldOfStudy, DateOnly startDate, DateOnly? endDate, Uri url)
        {
            //Arrange
            var entity = new EducationSqlEntity
            {
                Id = id,
                Name = name,
                Degree = degree,
                FieldOfStudy = fieldOfStudy,
                StartDate = startDate,
                EndDate = endDate,
                Url = url
            };

            //Act
            var result = entity.ToEducationDto();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(id, result.Id);
            Assert.Equal(name, result.Name);
            Assert.Equal(degree, result.Degree);
            Assert.Equal(fieldOfStudy, result.FieldOfStudy);
            Assert.Equal(startDate, result.StartDate);
            Assert.Equal(endDate, result.EndDate);
            Assert.Equal(url, result.Url);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void EducationDtoToMongoEntity(Guid id, string name, string degree, string fieldOfStudy, DateOnly startDate, DateOnly? endDate, Uri url)
        {
            //Arrange
            var dto = new Education
            {
                Id = id,
                Name = name,
                Degree = degree,
                FieldOfStudy = fieldOfStudy,
                StartDate = startDate,
                EndDate = endDate,
                Url = url
            };

            //Act
            var result = dto.ToEducationMongoEntity();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(id, result.Id);
            Assert.Equal(name, result.Name);
            Assert.Equal(degree, result.Degree);
            Assert.Equal(fieldOfStudy, result.FieldOfStudy);
            Assert.Equal(startDate, result.StartDate);
            Assert.Equal(endDate, result.EndDate);
            Assert.Equal(url, result.Url);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void EducationDtoToSqlEntity(Guid id, string name, string degree, string fieldOfStudy, DateOnly startDate, DateOnly? endDate, Uri url)
        {
            //Arrange
            var dto = new Education
            {
                Id = id,
                Name = name,
                Degree = degree,
                FieldOfStudy = fieldOfStudy,
                StartDate = startDate,
                EndDate = endDate,
                Url = url
            };

            //Act
            var result = dto.ToEducationSqlEntity();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(id, result.Id);
            Assert.Equal(name, result.Name);
            Assert.Equal(degree, result.Degree);
            Assert.Equal(fieldOfStudy, result.FieldOfStudy);
            Assert.Equal(startDate, result.StartDate);
            Assert.Equal(endDate, result.EndDate);
            Assert.Equal(url, result.Url);
        }
    }
}
