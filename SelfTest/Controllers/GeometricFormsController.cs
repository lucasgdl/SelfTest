using Microsoft.AspNetCore.Mvc;
using SelfTest.Commands.Handlers;
using SelfTest.Commands.Requests;

namespace API.Controllers.GeometricForms
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GeometricFormsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] GetGeometricFormRequest request)
        {
            var response = new GetGeometricFormHandler().Handle(request);

            return Ok(response);
        }
    }
}
