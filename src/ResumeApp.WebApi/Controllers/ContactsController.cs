using System;
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
    public class ContactsController : CrudControllerBase<Contact>
    {
        public ContactsController(
            ICrudService<Contact> crudService,
            ILogger<ContactsController> logger) : base(crudService, logger)
        { }
    }
}