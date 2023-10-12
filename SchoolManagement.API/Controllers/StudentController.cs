using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstract;
using SchoolManagement.Entities;

namespace SchoolManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _studentService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addStudent")]
        public IActionResult AddStudent(Student student)
        {
            var result = _studentService.Add(student);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
