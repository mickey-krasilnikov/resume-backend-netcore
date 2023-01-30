using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using ResumeApp.Poco;
using ResumeApp.BusinessLogic.Services;

namespace ResumeApp.WebApi.Controllers
{
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("api/resumeservice/{controller}")]
    public class CertificationController : CrudControllerBase<Certification>
    {
        public CertificationController(
            ICrudService<Certification> crudService,
            ILogger<CertificationController> logger) : base(crudService, logger)
        { }
    }
}