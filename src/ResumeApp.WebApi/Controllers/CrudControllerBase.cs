using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.Poco;

namespace ResumeApp.WebApi.Controllers
{
    public abstract class CrudControllerBase<TModel>: ControllerBase where TModel : IHasId
    {
        private readonly ICrudService<TModel> _crudService;
        private readonly ILogger _logger;

        public CrudControllerBase(
            ICrudService<TModel> crudService,
            ILogger logger)
        {
            _crudService = crudService;
            _logger = logger;
        }

        [HttpOptions]
        public IActionResult GetOptions()
        {
            Response.Headers.Add(HeaderNames.Allow, $"{HttpMethods.Get},{HttpMethods.Options},{HttpMethods.Post}");
            return Ok();
        }

        [HttpGet]
        [HttpHead]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<IEnumerable<TModel>>> GetAllItems()
        {
            return Ok(await _crudService.GetAllItemsAsync());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<TModel>> GetItemById([FromRoute] string id)
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
        public async Task<ActionResult<TModel>> CreateItem([FromBody] TModel item)
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
        public async Task<ActionResult<TModel>> UpdateItem([FromRoute] string id, [FromBody] TModel item)
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
        public async Task<ActionResult<TModel>> DeleteItem([FromRoute] string id)
        {
            if (!Guid.TryParse(id, out var guidId)) return BadRequest();
            var isExists = await _crudService.CheckIfItemExistsAsync(guidId);
            if (!isExists) return NotFound();

            await _crudService.DeleteItemAsync(guidId);
            return NoContent();
        }
    }
}