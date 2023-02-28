using ResumeApp.BusinessLogic.Validations;
using ResumeApp.Models;

namespace ResumeApp.UnitTests.Validations
{
    public class ContactValidatorTests
    {
        public static IEnumerable<object[]> ValidCases => new List<object[]>
        {
            new object[] { new ContactDto() { Key = "TestContact", Value = "TestVal" } },
            new object[] { new ContactDto() { Key = "TestContact", Value = "TestVal", Id = Guid.NewGuid(), Link = "https://test.com" } }
        };

        public static IEnumerable<object[]> InvalidCases => new List<object[]>
        {
            new object[] { 2, new ContactDto() },
            new object[] { 1, new ContactDto() { Key = "TestContact" } },
            new object[] { 1, new ContactDto() { Value = "TestVal" } }
        };

        [Theory]
        [MemberData(nameof(ValidCases))]
        public void WhenValidCases_ValidationSuccess(ContactDto dto)
        {
            // Arrange
            var validator = new ContactValidator();

            // Act
            var result = validator.Validate(dto);

            //Assert
            Assert.True(result.IsValid);
            Assert.Empty(result.Errors);
        }

        [Theory]
        [MemberData(nameof(InvalidCases))]
        public void WhenInvalidCases_ReturnsValidationFailure(int expectederrorCount, ContactDto dto)
        {
            // Arrange
            var validator = new ContactValidator();

            // Act
            var result = validator.Validate(dto);

            //Assert
            Assert.False(result.IsValid);
            Assert.Equal(expectederrorCount, result.Errors.Count);
        }
    }
}

