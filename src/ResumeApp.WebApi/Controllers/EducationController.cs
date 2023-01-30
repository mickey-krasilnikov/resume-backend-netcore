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
    public class EducationController : CrudControllerBase<Education>
    {
        public EducationController(
            ICrudService<Education> crudService,
            ILogger<EducationController> logger) : base(crudService, logger)
        {
        }
    }
}