using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.Models;

namespace ResumeApp.WebApi.Controllers
{
	[ApiController]
	[Consumes("application/json")]
	[Produces("application/json")]
	[Route("api/ResumeService/[controller]")]
	public class EducationController : ControllerBase
	{
		private readonly ICrudService<EducationDto> _crudService;
		private readonly ILogger _logger;

		public EducationController(
			ICrudService<EducationDto> crudService,
			ILogger<EducationController> logger)
		{
			_crudService = crudService;
			_logger = logger;
		}

		[HttpOptions]
		public IActionResult GetOptions()
		{
			Response.Headers.Add(HeaderNames.Allow, $"{HttpMethods.Options},{HttpMethods.Get},{HttpMethods.Head},{HttpMethods.Post}");
			return Ok();
		}

		[HttpGet]
		[HttpHead]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesDefaultResponseType]
		public async Task<ActionResult<IEnumerable<EducationDto>>> GetAllItems()
		{
			return Ok(await _crudService.GetAllItemsAsync());
		}

		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesDefaultResponseType]
		public async Task<ActionResult<EducationDto>> GetItemById([FromRoute] string id)
		{
			if (!Guid.TryParse(id, out var CertificationId)) return BadRequest();
			var isExists = await _crudService.CheckIfItemExistsAsync(CertificationId);
			return isExists
				? Ok(await _crudService.GetItemByIdAsync(CertificationId))
				: NotFound();
		}

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesDefaultResponseType]
		public async Task<ActionResult<EducationDto>> CreateItem([FromBody] EducationDto item)
		{
			if (item == null) return BadRequest();
			var newItem = await _crudService.CreateItemAsync(item);
			return CreatedAtAction(nameof(GetItemById), newItem.Id, newItem);
		}

		[HttpPut("{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesDefaultResponseType]
		public async Task<ActionResult<EducationDto>> UpdateItem([FromRoute] string id, [FromBody] EducationDto item)
		{
			if (!Guid.TryParse(id, out var guidId)) return BadRequest();
			var isExists = await _crudService.CheckIfItemExistsAsync(guidId);
			if (!isExists) return NotFound();

			await _crudService.UpdateItemAsync(item);
			return NoContent();
		}

		[HttpDelete("{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesDefaultResponseType]
		public async Task<ActionResult<EducationDto>> DeleteItem([FromRoute] string id)
		{
			if (!Guid.TryParse(id, out var guidId)) return BadRequest();
			var isExists = await _crudService.CheckIfItemExistsAsync(guidId);
			if (!isExists) return NotFound();

			await _crudService.DeleteItemAsync(guidId);
			return NoContent();
		}
	}
}