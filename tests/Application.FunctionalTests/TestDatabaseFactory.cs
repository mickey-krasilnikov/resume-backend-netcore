namespace ResumeApp.Application.FunctionalTests;

public static class TestDatabaseFactory
{
    public static async Task<ITestDatabase> CreateAsync()
    {
        var database = new TestContainersTestDatabase();

        await database.InitialiseAsync();

        return database;
    }
}
