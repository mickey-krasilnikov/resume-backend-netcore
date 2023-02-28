using ResumeApp.BusinessLogic.Validations;
using ResumeApp.Models;

namespace ResumeApp.UnitTests.Validations
{
    public class EducationValidatorTests
    {
        public static IEnumerable<object[]> ValidCases => new List<object[]>
        {
            new object[] { new EducationDto() { Name = "TestUniv", Degree = "TestDegree", StartDate = DateOnly.FromDateTime(DateTime.UtcNow) } },
            new object[] { new EducationDto() { Name = "TestUniv", Degree = "TestDegree", StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-5)), Id = Guid.NewGuid(), EndDate = DateOnly.FromDateTime(DateTime.UtcNow), FieldOfStudy= "TestFieldOfStudy", Url = new Uri("https://test.com") } }
        };

        public static IEnumerable<object[]> InvalidCases => new List<object[]>
        {
            new object[] { 3, new EducationDto() },
            new object[] { 2, new EducationDto() { Name = "TestUniv"} },
            new object[] { 2, new EducationDto() { Degree = "TestDegree" } },
            new object[] { 2, new EducationDto() { StartDate = DateOnly.FromDateTime(DateTime.UtcNow) } },
            new object[] { 1, new EducationDto() { Degree = "TestDegree", StartDate = DateOnly.FromDateTime(DateTime.UtcNow) } },
            new object[] { 1, new EducationDto() { Name = "TestUniv", StartDate = DateOnly.FromDateTime(DateTime.UtcNow) } },
            new object[] { 1, new EducationDto() { Name = "TestUniv", Degree = "TestDegree" } },

        };

        [Theory]
        [MemberData(nameof(ValidCases))]
        public void WhenValidCases_ValidationSuccess(EducationDto dto)
        {
            // Arrange
            var validator = new EducationValidator();

            // Act
            var result = validator.Validate(dto);

            //Assert
            Assert.True(result.IsValid);
            Assert.Empty(result.Errors);
        }

        [Theory]
        [MemberData(nameof(InvalidCases))]
        public void WhenInvalidCases_ReturnsValidationFailure(int expectederrorCount, EducationDto dto)
        {
            // Arrange
            var validator = new EducationValidator();

            // Act
            var result = validator.Validate(dto);

            //Assert
            Assert.False(result.IsValid);
            Assert.Equal(expectederrorCount, result.Errors.Count);
        }
    }
}

