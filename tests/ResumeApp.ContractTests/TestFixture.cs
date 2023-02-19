using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using ResumeApp.DataAccess.Sql.Context;
using ResumeApp.WebApi;

namespace ResumeApp.ContractTests.Controllers
{
    public class TestFixture : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddDbContext<ISqlDbContext, SqlDbContext>(o =>
                {
                    o.UseInMemoryDatabase(databaseName: "sqldb-resume");
                });

                services.AddSingleton<ISqlDbContext>(provider =>
                {
                    var options = new DbContextOptionsBuilder<SqlDbContext>()
                        .UseInMemoryDatabase("test-db")
                        .Options;

                    return new SqlDbContext(options);
                });
            });
        }
    }

}