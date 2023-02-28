﻿using FluentValidation;
using Moq;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.DataAccess.Abstractions;
using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Models;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace ResumeApp.UnitTests.Services
{
    public class ExperienceServiceTests
    {
        #region HappyPath

        // To pass the Type to generic test
        public static IEnumerable<object[]> EntityTypes => new List<object[]>
        {
            new object[] { new ExperienceSqlEntity() },
            new object[] { new ExperienceMongoEntity() }
        };

        [Theory]
        [MemberData(nameof(EntityTypes))]
        [SuppressMessage("Usage", "xUnit1026:Theory methods should use all of their parameters", Justification = "Resolving Generic Type with MemberData")]
        public async Task WhenGetAllExperience_ThenItemsReturnedAndProjectCalledOnce<TEntity>(TEntity _) where TEntity : class
        {
            //Arrange
            var repoMock = new Mock<IRepository<TEntity>>();
            repoMock
                .Setup(r => r.ProjectAsync(It.IsAny<Expression<Func<TEntity, ExperienceDto>>>()))
                .ReturnsAsync(new List<ExperienceDto> { new ExperienceDto() });

            var validatorMock = new Mock<IValidator<ExperienceDto>>();
            var service = new ExperienceService<TEntity>(repoMock.Object, validatorMock.Object);

            //Act
            var items = await service.GetAllItemsAsync();

            //Assert
            Assert.NotNull(items);
            Assert.NotEmpty(items);
            repoMock.Verify(m => m.ProjectAsync(It.IsAny<Expression<Func<TEntity, ExperienceDto>>>()), Times.Once);
        }

        [Theory]
        [MemberData(nameof(EntityTypes))]
        [SuppressMessage("Usage", "xUnit1026:Theory methods should use all of their parameters", Justification = "Resolving Generic Type with MemberData")]
        public async Task WhenGetItemById_ThenCertificateReturnedAndFindByIdCalledOnce<TEntity>(TEntity _) where TEntity : class
        {
            //Arrange
            var id = Guid.NewGuid();
            var repoMock = new Mock<IRepository<TEntity>>();
            repoMock
                .Setup(r => r.FindByIdAsync(It.IsAny<Guid>(), It.IsAny<Expression<Func<TEntity, ExperienceDto>>>()))
                .ReturnsAsync(new ExperienceDto { Id = id });

            var validatorMock = new Mock<IValidator<ExperienceDto>>();
            var service = new ExperienceService<TEntity>(repoMock.Object, validatorMock.Object);

            //Act
            var item = await service.GetItemByIdAsync(id);

            //Assert
            Assert.NotNull(item);
            repoMock.Verify(m => m.FindByIdAsync(It.IsAny<Guid>(), It.IsAny<Expression<Func<TEntity, ExperienceDto>>>()), Times.Once);
        }

        [Theory]
        [MemberData(nameof(EntityTypes))]
        [SuppressMessage("Usage", "xUnit1026:Theory methods should use all of their parameters", Justification = "Resolving Generic Type with MemberData")]
        public async Task WhenCheckIfItemExistsAndItemExists_ThenTrueReturnedAndCheckIfItemExistsCalledOnce<TEntity>(TEntity _) where TEntity : class
        {
            //Arrange
            var id = Guid.NewGuid();
            var repoMock = new Mock<IRepository<TEntity>>();
            repoMock
                .Setup(r => r.CheckIfItemExistsAsync(It.IsAny<Guid>()))
                .ReturnsAsync(true);

            var validatorMock = new Mock<IValidator<ExperienceDto>>();
            var service = new ExperienceService<TEntity>(repoMock.Object, validatorMock.Object);

            //Act
            var isItemExists = await service.CheckIfItemExistsAsync(id);

            //Assert
            Assert.True(isItemExists);
            repoMock.Verify(m => m.CheckIfItemExistsAsync(It.IsAny<Guid>()), Times.Once);
        }

        [Theory]
        [MemberData(nameof(EntityTypes))]
        [SuppressMessage("Usage", "xUnit1026:Theory methods should use all of their parameters", Justification = "Resolving Generic Type with MemberData")]
        public async Task WhenCreateItem_ThenNewItemReturnedAndInsertOneCalledOnce<TEntity>(TEntity _) where TEntity : class
        {
            //Arrange
            var itemToCreate = new ExperienceDto();
            var repoMock = new Mock<IRepository<TEntity>>();
            repoMock
                .Setup(r => r.InsertOneAsync(It.IsAny<TEntity>()))
                .Returns<TEntity>(r => Task.FromResult(r));

            var validatorMock = new Mock<IValidator<ExperienceDto>>();
            var service = new ExperienceService<TEntity>(repoMock.Object, validatorMock.Object);

            //Act
            var createdItem = await service.CreateItemAsync(itemToCreate);

            //Assert
            Assert.NotNull(createdItem);
            repoMock.Verify(m => m.InsertOneAsync(It.IsAny<TEntity>()), Times.Once);
        }


        [Theory]
        [MemberData(nameof(EntityTypes))]
        [SuppressMessage("Usage", "xUnit1026:Theory methods should use all of their parameters", Justification = "Resolving Generic Type with MemberData")]
        public async Task WhenUpdateItem_ThenReplaceOneCalledOnce<TEntity>(TEntity _) where TEntity : class
        {
            //Arrange
            var itemForUpdate = new ExperienceDto();
            var repoMock = new Mock<IRepository<TEntity>>();
            repoMock
                .Setup(r => r.ReplaceOneAsync(It.IsAny<TEntity>()))
                .Returns(Task.CompletedTask);

            var validatorMock = new Mock<IValidator<ExperienceDto>>();
            var service = new ExperienceService<TEntity>(repoMock.Object, validatorMock.Object);

            //Act
            await service.UpdateItemAsync(itemForUpdate);

            //Assert
            repoMock.Verify(m => m.ReplaceOneAsync(It.IsAny<TEntity>()), Times.Once);
        }


        [Theory]
        [MemberData(nameof(EntityTypes))]
        [SuppressMessage("Usage", "xUnit1026:Theory methods should use all of their parameters", Justification = "Resolving Generic Type with MemberData")]
        public async Task WhenCreateItem_ThenDeleteByIdCalledOnce<TEntity>(TEntity _) where TEntity : class
        {
            //Arrange
            var itemToDeleteId = Guid.NewGuid();
            var repoMock = new Mock<IRepository<TEntity>>();
            repoMock
                .Setup(r => r.DeleteByIdAsync(It.IsAny<Guid>()))
                .Returns(Task.CompletedTask);

            var validatorMock = new Mock<IValidator<ExperienceDto>>();
            var service = new ExperienceService<TEntity>(repoMock.Object, validatorMock.Object);

            //Act
            await service.DeleteItemAsync(itemToDeleteId);

            //Assert
            repoMock.Verify(m => m.DeleteByIdAsync(It.IsAny<Guid>()), Times.Once);
        }

        #endregion HappyPath
    }
}