namespace ResumeApp.DataAccess.Mongo.Attributes
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
