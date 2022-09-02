using Microsoft.AspNetCore.Mvc;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.Poco;

namespace ResumeApp.WebApi.Controllers
{
	[ApiController]
	[Consumes("application/json")]
	[Produces("application/json")]
	[Route("api/resumes")]
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
		public async Task<ActionResult<IEnumerable<ConciseResume>>> GetAllResumes()
		{
			return Ok(await _resumeService.GetAllResumesAsync());
		}

		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FullResume))]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesDefaultResponseType]
		public async Task<ActionResult<FullResume>> GetResumeById([FromRoute] string id)
		{
			var isExists = await _resumeService.CheckIfItemExistsAsync(id);
			return isExists
				? Ok(await _resumeService.GetResumeByIdAsync(id))
				: NotFound();
		}

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created, Type = typeof(List<FullResume>))]
		[ProducesDefaultResponseType]
		public async Task<ActionResult<FullResume>> PostResume([FromBody] FullResume resume)
		{
			await _resumeService.CreateResumesAsync(resume);
			return Created(new Uri($"/{resume.ID}"), null);
		}

		[HttpPut("{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(List<FullResume>))]
		[ProducesDefaultResponseType]
		public async Task<ActionResult<FullResume>> PutResume([FromRoute] string id, [FromBody] FullResume resume)
		{
			var isExists = await _resumeService.CheckIfItemExistsAsync(id);
			if (!isExists) return NotFound();

			await _resumeService.UpdateResumesAsync(resume);
			return NoContent();
		}

		[HttpDelete("{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(List<FullResume>))]
		[ProducesDefaultResponseType]
		public async Task<ActionResult<FullResume>> DeleteResumeById([FromRoute] string id)
		{
			var isExists = await _resumeService.CheckIfItemExistsAsync(id);
			if (!isExists) return NotFound();

			await _resumeService.DeleteResumesAsync(id);
			return NoContent();
		}
	}
}