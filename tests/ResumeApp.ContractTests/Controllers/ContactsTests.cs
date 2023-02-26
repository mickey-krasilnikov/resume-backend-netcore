using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.ApiClient;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.DataAccess.Sql.Entities;

namespace ResumeApp.ContractTests.Controllers
{
    public class ContactsTests : IClassFixture<TestFixture>
    {
        private readonly IResumeApiClient _apiClient;
        private readonly ISqlDbContext _sqlDbContext;

        public ContactsTests(TestFixture testFixture)
        {
            _apiClient = new ResumeApiClient(testFixture.CreateClient());
            _sqlDbContext = testFixture.Services.CreateScope().ServiceProvider.GetService<ISqlDbContext>();
        }

        #region HappyPath

        [Fact]
        public async Task GetAllContacts_HappyPath()
        {
            // Arrange
            var expectedContact = new ContactSqlEntity()
            {
                Id = Guid.NewGuid(),
                Key = "testContactKey",
                Value = "testContactValue",
                Link = "https://testContact.com"
            };

            // Act
            _sqlDbContext.Contacts.Add(expectedContact);
            await _sqlDbContext.SaveChangesAsync();
            var contacts = await _apiClient.ContactsAllAsync();
            _sqlDbContext.Contacts.Remove(expectedContact);
            await _sqlDbContext.SaveChangesAsync();

            // Assert
            Assert.NotEmpty(contacts);
            Assert.Single(contacts);
            Assert.Equal(expectedContact.Id, contacts.Single().Id);
            Assert.Equal(expectedContact.Key, contacts.Single().Key);
            Assert.Equal(expectedContact.Value, contacts.Single().Value);
            Assert.Equal(expectedContact.Link, contacts.Single().Link);

        }

        [Fact]
        public async Task GetContactById_HappyPath()
        {
            // Arrange
            var contactId = Guid.NewGuid();
            var expectedContact = new ContactSqlEntity()
            {
                Id = contactId,
                Key = "testContactKey",
                Value = "testContactValue",
                Link = "https://testContact.com"
            };

            // Act
            _sqlDbContext.Contacts.Add(expectedContact);
            await _sqlDbContext.SaveChangesAsync();
            var contact = await _apiClient.ContactsGETAsync(contactId.ToString());
            _sqlDbContext.Contacts.Remove(expectedContact);
            await _sqlDbContext.SaveChangesAsync();

            // Assert
            Assert.NotNull(contact);
            Assert.Equal(expectedContact.Id, contact.Id);
            Assert.Equal(expectedContact.Key, contact.Key);
            Assert.Equal(expectedContact.Value, contact.Value);
            Assert.Equal(expectedContact.Link, contact.Link);
        }

        [Fact]
        public async Task PostContact_HappyPath()
        {
            // Arrange
            var contactToPost = new ContactDto()
            {
                Key = "testContactKey",
                Value = "testContactValue",
                Link = "https://testContact.com"
            };

            // Act
            var contactsBefore = _sqlDbContext.Contacts.AsNoTracking().SingleOrDefault();
            await _apiClient.ContactsPOSTAsync(contactToPost);
            var contactsAfter = _sqlDbContext.Contacts.AsNoTracking().Single();
            _sqlDbContext.Contacts.RemoveRange(_sqlDbContext.Contacts.ToList());
            await _sqlDbContext.SaveChangesAsync();

            // Assert
            Assert.Null(contactsBefore);
            Assert.NotNull(contactsAfter);
            Assert.Equal(Guid.Empty, contactToPost.Id);
            Assert.NotEqual(Guid.Empty, contactsAfter.Id);
            Assert.Equal(contactToPost.Key, contactsAfter.Key);
            Assert.Equal(contactToPost.Value, contactsAfter.Value);
            Assert.Equal(contactToPost.Link, contactsAfter.Link);
        }

        [Fact]
        public async Task PutContact_HappyPath()
        {
            // Arrange
            var contactId = Guid.NewGuid();
            var initialContact = new ContactSqlEntity()
            {
                Id = contactId,
                Key = "testContactKey1",
                Value = "testContactValue1",
                Link = "https://testContact1.com"
            };
            var contactToPut = new ContactDto()
            {
                Id = contactId,
                Key = "testContactKey2",
                Value = "testContactValue2",
                Link = "https://testContact2.com"
            };

            // Act
            _sqlDbContext.Contacts.Add(initialContact);
            await _sqlDbContext.SaveChangesAsync();
            var contactsBefore = _sqlDbContext.Contacts.AsNoTracking().Single();
            await _apiClient.ContactsPUTAsync(contactId.ToString(), contactToPut);
            var contactsAfter = _sqlDbContext.Contacts.AsNoTracking().Single();
            _sqlDbContext.Contacts.RemoveRange(_sqlDbContext.Contacts.ToList());
            await _sqlDbContext.SaveChangesAsync();

            // Assert
            Assert.NotNull(contactsBefore);
            Assert.NotNull(contactsAfter);
            Assert.Equal(contactsBefore.Id, contactsAfter.Id);
            Assert.NotEqual(contactsBefore.Key, contactsAfter.Key);
            Assert.NotEqual(contactsBefore.Value, contactsAfter.Value);
            Assert.NotEqual(contactsBefore.Link, contactsAfter.Link);

            Assert.Equal(contactToPut.Key, contactsAfter.Key);
            Assert.Equal(contactToPut.Value, contactsAfter.Value);
            Assert.Equal(contactToPut.Link, contactsAfter.Link);
        }

        [Fact]
        public async Task DeleteContact_HappyPath()
        {
            // Arrange
            var contactId = Guid.NewGuid();
            var ContactToDelete = new ContactSqlEntity()
            {
                Id = contactId,
                Key = "testContactKey",
                Value = "testContactValue",
                Link = "https://testContact.com"
            };

            // Act
            _sqlDbContext.Contacts.Add(ContactToDelete);
            await _sqlDbContext.SaveChangesAsync();
            var contactsBefore = _sqlDbContext.Contacts.AsNoTracking().Single();
            await _apiClient.ContactsDELETEAsync(contactId.ToString());
            var contactsAfter = _sqlDbContext.Contacts.AsNoTracking().SingleOrDefault();

            // Assert
            Assert.NotNull(contactsBefore);
            Assert.Null(contactsAfter);
        }
        #endregion HappyPath
    }
}