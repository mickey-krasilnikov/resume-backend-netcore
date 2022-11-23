using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
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

		[HttpOptions]
		public IActionResult GetResumesOptions()
		{
			Response.Headers.Add(HeaderNames.Allow, $"{HttpMethods.Get},{HttpMethods.Options},{HttpMethods.Post}");
			return Ok();
		}

		[HttpGet]
		[HttpHead]
		public async Task<ActionResult<IEnumerable<ShortResume>>> GetResumes()
		{
			return Ok(await _resumeService.GetAllResumesAsync());
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<FullResume>> GetResumeById([FromRoute] string id)
		{
			if(!Guid.TryParse(id, out var resumeId)) return BadRequest();
			var isExists = await _resumeService.CheckIfItemExistsAsync(resumeId);
			return isExists
				? Ok(await _resumeService.GetResumeByIdAsync(resumeId))
				: NotFound();
		}

		//[HttpPost]
		//public async Task<ActionResult<FullResume>> CreateResume([FromBody] FullResume resume)
		//{
		//	if (resume == null) return BadRequest();
		//	await _resumeService.CreateResumesAsync(resume);
		//	return CreatedAtAction(nameof(GetResumeById), resume.Id, null);
		//}

		//[HttpPut("{id}")]
		//public async Task<ActionResult<FullResume>> UpdateResume([FromRoute] string id, [FromBody] FullResume resume)
		//{
		//	if (!Guid.TryParse(id, out var resumeId)) return BadRequest();
		//	var isExists = await _resumeService.CheckIfItemExistsAsync(resumeId);
		//	if (!isExists) return NotFound();

		//	await _resumeService.UpdateResumesAsync(resume);
		//	return NoContent();
		//}

		[HttpDelete("{id}")]
		public async Task<ActionResult<FullResume>> DeleteResumeById([FromRoute] string id)
		{
			if (!Guid.TryParse(id, out var resumeId)) return BadRequest();
			var isExists = await _resumeService.CheckIfItemExistsAsync(resumeId);
			if (!isExists) return NotFound();

			await _resumeService.DeleteResumesAsync(resumeId);
			return NoContent();
		}
	}
}