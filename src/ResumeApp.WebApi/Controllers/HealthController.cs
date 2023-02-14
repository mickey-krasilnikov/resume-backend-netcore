using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.Models;

namespace ResumeApp.WebApi.Controllers
{
	[ApiController]
	[Consumes("application/json")]
	[Produces("application/json")]
	[Route("api/resumeservice/[controller]")]
	public class HealthController : ControllerBase
	{
		[HttpGet]
		[HttpHead]
		public IActionResult HealthCheck()
		{
			return Ok("Healthy");
		}
	}
}