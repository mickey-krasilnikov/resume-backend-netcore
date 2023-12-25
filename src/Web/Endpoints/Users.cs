using JetBrains.Annotations;
using ResumeApp.Infrastructure.Identity;

namespace ResumeApp.Web.Endpoints;

[UsedImplicitly]
public class Users : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this).MapIdentityApi<ApplicationUser>();
    }
}
