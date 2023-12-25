using System.Security.Claims;

using ResumeApp.Application.Common.Interfaces;

namespace ResumeApp.Web.Services;

public class CurrentUser(IHttpContextAccessor httpContextAccessor) : IUser
{
    public string? Id => httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
}
