using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstract;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Contract;

namespace SchoolManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherSyllabusController : Controller
    {
        ITeacherSyllabusService _teacherSyllabusService;
        public TeacherSyllabusController(ITeacherSyllabusService teacherSyllabusService)
        {
            _teacherSyllabusService = teacherSyllabusService;
        }

        [HttpDelete("deleteTeacherSyllabus/{teacherId:int}")]
        public IActionResult DeleteTeacherSyllabusById(int teacherId)
        {
            var result = _teacherSyllabusService.Delete(teacherId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addTeacherSyllabus")]
        public IActionResult AddTeacherSyllabus(TeacherSyllabus teacherSyllabus)
        {
            var result = _teacherSyllabusService.Add(teacherSyllabus);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("updateTeacherSyllabus")]
        public IActionResult UpdateTeacherSyllabus(TeacherSyllabus teacherSyllabus)
        {
            var result = _teacherSyllabusService.Update(teacherSyllabus);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getAllLessonsByTeacherId/{teacherId:int}")]
        public IActionResult GetAllLessonsByTeacherId(int teacherId)
        {
            var result = _teacherSyllabusService.GetAllLessonsByTeacherId(teacherId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
