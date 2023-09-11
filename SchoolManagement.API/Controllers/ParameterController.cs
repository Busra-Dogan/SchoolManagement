using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstract;

namespace SchoolManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParameterController : Controller
    {
        IParameterService _parameterService;
        public ParameterController(IParameterService parameterService)
        {
            _parameterService = parameterService;
        }
        [HttpGet("getParameterByParamType")]
        public IActionResult GetParameterByParamType(string paramType)
        {
            var result = _parameterService.GetParameterByParamType(paramType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
