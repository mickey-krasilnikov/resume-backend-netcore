namespace ResumeApp.Poco
{
    public class Contact : IHasId
    {
        public Guid Id { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}