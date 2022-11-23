using ResumeApp.DataAccess.Abstractions.Entities;

namespace ResumeApp.DataAccess.Mongo.Entities
{
	public class ContactMongoEntity : IContactEntity
	{
		public string Key { get; set; }

		public string Value { get; set; }
	}
}
