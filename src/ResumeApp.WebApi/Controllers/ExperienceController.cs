using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using ResumeApp.BusinessLogic.Services;
using ResumeApp.Poco;

namespace ResumeApp.WebApi.Controllers
{
	[ApiController]
	[Consumes("application/json")]
	[Produces("application/json")]
    [Route("api/resumeservice/{controller}")]
    public class ExperienceController : CrudControllerBase<Experience>
    {
        public ExperienceController(
            ICrudService<Experience> crudService,
            ILogger<ExperienceController> logger) : base(crudService, logger)
        { }
    }
}