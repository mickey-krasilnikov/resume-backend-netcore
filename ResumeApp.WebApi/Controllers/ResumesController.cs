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
		private readonly ILogger<ResumesController> _logger;

		public ResumesController(
			IResumeService resumeService,
			ILogger<ResumesController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Resume>))]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesDefaultResponseType]
		public ActionResult<IEnumerable<Resume>> Get()
		{
			return Ok(new Resume());
		}

		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Resume))]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesDefaultResponseType]
		public ActionResult<Resume> GetById([FromRoute] string id)
		{
			var isParsed = Guid.TryParse(id, out var guidId);

			return isParsed
				? Ok(new Poco.Resume { ID = guidId })
				: BadRequest();
		}
	}
}