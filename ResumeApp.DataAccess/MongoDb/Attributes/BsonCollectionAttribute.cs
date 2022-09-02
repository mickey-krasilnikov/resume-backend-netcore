namespace ResumeApp.DataAccess.MongoDb.Attributes
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	internal sealed class BsonCollectionAttribute : Attribute
	{
		public string CollectionName { get; }

		public BsonCollectionAttribute(string collectionName)
		{
			CollectionName = collectionName;
		}
	}
}
