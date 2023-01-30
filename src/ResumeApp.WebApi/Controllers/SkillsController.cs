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
    public class SkillsController : CrudControllerBase<Skill>
    {
        public SkillsController(
            ICrudService<Skill> crudService,
            ILogger<SkillsController> logger) : base(crudService, logger)
        { }
    }
}