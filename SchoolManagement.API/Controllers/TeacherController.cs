using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstract;

namespace SchoolManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : Controller
    {
        ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _teacherService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("deleteTeacher/{id:int}")]
        public IActionResult DeleteTeacherById(int id)
        {
            var result = _teacherService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
