using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstract;
using SchoolManagement.Entities;

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

        [HttpPost("addTeacher")]
        public IActionResult AddTeacher(Teacher teacher)
        {
            var result = _teacherService.Add(teacher);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("updateTeacher")]
        public IActionResult UpdateTeacher(Teacher teacher)
        {
            var result = _teacherService.Update(teacher);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getTeacherById/{id:int}")]
        public IActionResult GetTeacherInfoById(int id)
        {
            var result = _teacherService.GetTeacherById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
