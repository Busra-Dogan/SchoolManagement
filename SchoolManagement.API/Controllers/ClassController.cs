using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstract;
using SchoolManagement.Entities;

namespace SchoolManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : Controller
    {
        IClassService _classService;
        public ClassController(IClassService classService)
        {
            _classService = classService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _classService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallclass")]
        public IActionResult GetAllClass()
        {
            var result = _classService.GetAllClass();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("deleteClass/{id:int}")]
        public IActionResult DeleteClassById(int id)
        {
            var result = _classService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
