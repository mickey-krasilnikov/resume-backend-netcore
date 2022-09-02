using Microsoft.AspNetCore.Mvc;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.Poco;

namespace ResumeApp.WebApi.Controllers
{
	[ApiController]
	[Consumes("application/json")]
	[Produces("application/json")]
	[Route("api/[controller]")]
	public class ResumesController : ControllerBase
	{
		private readonly IResumeService _resumeService;
		private readonly ILogger<ResumesController> _logger;

		public ResumesController(
			IResumeService resumeService,
			ILogger<ResumesController> logger)
		{
			_resumeService = resumeService;
			_logger = logger;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<FullResume>))]
		[ProducesDefaultResponseType]
		public async Task<ActionResult<IEnumerable<ConciseResume>>> GetAsync()
		{
			return Ok(await _resumeService.GetAllResumesAsync());
		}

		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FullResume))]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesDefaultResponseType]
		public async Task<ActionResult<FullResume>> GetByIdAsync([FromRoute] string id)
		{
			var isExists = await _resumeService.CheckIfItemExistsAsync(id);
			return isExists
				? Ok(await _resumeService.GetResumeByIdAsync(id))
				: NotFound();
		}
	}
}