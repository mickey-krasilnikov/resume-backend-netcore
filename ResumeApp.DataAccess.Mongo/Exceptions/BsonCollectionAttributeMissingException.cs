namespace ResumeApp.DataAccess.Mongo.Exceptions
{
	public class BsonCollectionAttributeMissingException : Exception
	{
		public BsonCollectionAttributeMissingException(string message) : base(message)
		{
		}

		public BsonCollectionAttributeMissingException(string message, Exception innerException) : base(message, innerException)
		{
		}

		public BsonCollectionAttributeMissingException()
		{
		}
	}
}
