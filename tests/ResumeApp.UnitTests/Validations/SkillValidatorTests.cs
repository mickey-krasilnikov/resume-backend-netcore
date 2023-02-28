using ResumeApp.BusinessLogic.Validations;
using ResumeApp.Models;

namespace ResumeApp.UnitTests.Validations
{
    public class SkillValidatorTests
    {
        public static IEnumerable<object[]> ValidCases => new List<object[]>
        {
            new object[] { new SkillDto() { Name = "TestSkill", SkillGroup = "TestGroup" } },
            new object[] { new SkillDto() { Name = "TestSkill", SkillGroup = "TestGroup", Id = Guid.NewGuid(), ExperienceIds = new List<Guid> { Guid.NewGuid() } } }
        };

        public static IEnumerable<object[]> InvalidCases => new List<object[]>
        {
            new object[] { 2, new SkillDto() },
            new object[] { 1, new SkillDto() { Name = "TestSkill" } },
            new object[] { 1, new SkillDto() { SkillGroup = "TestGroup" } }
        };

        [Theory]
        [MemberData(nameof(ValidCases))]
        public void WhenValidCases_ValidationSuccess(SkillDto dto)
        {
            // Arrange
            var validator = new SkillValidator();

            // Act
            var result = validator.Validate(dto);

            //Assert
            Assert.True(result.IsValid);
            Assert.Empty(result.Errors);
        }

        [Theory]
        [MemberData(nameof(InvalidCases))]
        public void WhenInvalidCases_ReturnsValidationFailure(int expectederrorCount, SkillDto dto)
        {
            // Arrange
            var validator = new SkillValidator();

            // Act
            var result = validator.Validate(dto);

            //Assert
            Assert.False(result.IsValid);
            Assert.Equal(expectederrorCount, result.Errors.Count);
        }
    }
}

