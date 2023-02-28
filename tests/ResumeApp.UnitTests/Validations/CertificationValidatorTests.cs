using System;
using ResumeApp.BusinessLogic.Validations;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;

namespace ResumeApp.UnitTests.Validations
{
    public class CertificationValidatorTests
	{
        public static IEnumerable<object[]> ValidCases => new List<object[]>
        {
            new object[] { new CertificationDto() { Name = "TestCert", Issuer = "TestIssuer", IssueDate = DateOnly.FromDateTime(DateTime.UtcNow) } },
            new object[] { new CertificationDto() { Name = "TestCert", Issuer = "TestIssuer", IssueDate = DateOnly.FromDateTime(DateTime.UtcNow), Id = Guid.NewGuid(), ExpirationDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(2)), VerificationUrl = new Uri("https://test.com") } }
        };

        public static IEnumerable<object[]> InvalidCases => new List<object[]>
        {
            new object[] { 3, new CertificationDto() },
            new object[] { 2, new CertificationDto() { Name = "TestCert" } },
            new object[] { 2, new CertificationDto() { Issuer = "TestIssuer" } },
            new object[] { 2, new CertificationDto() { IssueDate = DateOnly.FromDateTime(DateTime.UtcNow) } },
            new object[] { 1, new CertificationDto() { Name = "TestCert", Issuer = "TestIssuer" } },
            new object[] { 1, new CertificationDto() { Issuer = "TestIssuer", IssueDate = DateOnly.FromDateTime(DateTime.UtcNow) } },
            new object[] { 1, new CertificationDto() { Name = "TestCert", IssueDate = DateOnly.FromDateTime(DateTime.UtcNow) } },
        };

        [Theory]
        [MemberData(nameof(ValidCases))]
        public void WhenValidCases_ValidationSuccess(CertificationDto dto)
        {
            // Arrange
            var validator = new CertificationValidator();

            // Act
            var result = validator.Validate(dto);

            //Assert
            Assert.True(result.IsValid);
            Assert.Empty(result.Errors);
        }

        [Theory]
        [MemberData(nameof(InvalidCases))]
        public void WhenInvalidCases_ReturnsValidationFailure(int expectederrorCount, CertificationDto dto)
        {
            // Arrange
            var validator = new CertificationValidator();

            // Act
            var result = validator.Validate(dto);

            //Assert
            Assert.False(result.IsValid);
            Assert.Equal(expectederrorCount, result.Errors.Count);
        }
    }
}

