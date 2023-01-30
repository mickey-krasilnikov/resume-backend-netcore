using FluentValidation;
using Moq;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection;

namespace ResumeApp.UnitTests.Services
{
    public class ResumeServiceTests
    {
        #region HappyPath

        public static IEnumerable<object[]> EntityTypes => new List<object[]>
        {
            new object[] { new ResumeMongoEntity() },
            new object[] { new ResumeSqlEntity() }
        };

        [Theory]
        [MemberData(nameof(EntityTypes))]
        [SuppressMessage("Usage", "xUnit1026:Theory methods should use all of their parameters", Justification = "Resolving Generic Type with MemberData")]
        public async Task GetAllResumes_HappyPath<TEntity>(TEntity _)
        {
            //Arrange
            var repoMock = new Mock<IRepository<TEntity>>();
            repoMock
                .Setup(r => r.ProjectAsync(It.IsAny<Expression<Func<TEntity, ShortResume>>>()))
                .ReturnsAsync(new List<ShortResume> { new ShortResume() });

            var validatorMock = new Mock<IValidator<FullResume>>();
            IResumeService resumeService = new ResumeService<TEntity>(repoMock.Object, validatorMock.Object);

            //Act
            var resumes = await resumeService.GetAllResumesAsync();

            //Assert
            Assert.NotNull(resumes);
            Assert.NotEmpty(resumes);
            repoMock.Verify(m => m.ProjectAsync(It.IsAny<Expression<Func<TEntity, ShortResume>>>()), Times.Once);
        }


        [Fact]
        public void CheckIfItemExists_HappyPath()
        {
            //Arrange


            //Act


            //Assert


        }

        [Fact]
        public void GetResumeById_HappyPath()
        {
            //Arrange


            //Act


            //Assert


        }

        [Fact]
        public void DeleteResumes_HappyPath()
        {
            //Arrange


            //Act


            //Assert


        }

        [Fact]
        public void CreateResumes_HappyPath()
        {
            //Arrange


            //Act


            //Assert


        }

        [Fact]
        public void UpdateResumes_HappyPath()
        {
            //Arrange


            //Act


            //Assert


        }

        #endregion HappyPath
    }
}