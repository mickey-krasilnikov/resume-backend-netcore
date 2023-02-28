using ResumeApp.BusinessLogic.Validations;
using ResumeApp.Models;

namespace ResumeApp.UnitTests.Validations
{
    public class ExperienceValidatorTests
    {
        public static IEnumerable<object[]> ValidCases => new List<object[]>
        {
            new object[] { new ExperienceDto() { Title = "TestExp", Company = "TestCompany", Location = "TestLocation", StartDate = DateOnly.FromDateTime(DateTime.UtcNow) } },
            new object[] { new ExperienceDto() { Title = "TestExp", Company = "TestCompany", Location = "TestLocation", StartDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-5)), Id = Guid.NewGuid(), EndDate = DateOnly.FromDateTime(DateTime.UtcNow), TaskPerformed=new List<string> { "task1", "task2" }, SkillIds = new List<Guid> { Guid.NewGuid() } } }
        };

        public static IEnumerable<object[]> InvalidCases => new List<object[]>
        {
            new object[] { 4, new ExperienceDto() },
            new object[] { 3, new ExperienceDto() { Title = "TestExp" } },
            new object[] { 2, new ExperienceDto() { Title = "TestExp", Company = "TestCompany" } },
            new object[] { 1, new ExperienceDto() { Title = "TestExp", Company = "TestCompany", Location = "TestLocation" } },
            new object[] { 1, new ExperienceDto() { Title = "TestExp", Company = "TestCompany", StartDate = DateOnly.FromDateTime(DateTime.UtcNow) } }
        };

        [Theory]
        [MemberData(nameof(ValidCases))]
        public void WhenValidCases_ValidationSuccess(ExperienceDto dto)
        {
            // Arrange
            var validator = new ExperienceValidator();

            // Act
            var result = validator.Validate(dto);

            //Assert
            Assert.True(result.IsValid);
            Assert.Empty(result.Errors);
        }

        [Theory]
        [MemberData(nameof(InvalidCases))]
        public void WhenInvalidCases_ReturnsValidationFailure(int expectederrorCount, ExperienceDto dto)
        {
            // Arrange
            var validator = new ExperienceValidator();

            // Act
            var result = validator.Validate(dto);

            //Assert
            Assert.False(result.IsValid);
            Assert.Equal(expectederrorCount, result.Errors.Count);
        }
    }
}

