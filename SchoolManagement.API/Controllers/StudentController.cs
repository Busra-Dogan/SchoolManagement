using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstract;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Contract;

namespace SchoolManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        IStudentService _studentService;
        IParameterService _parameterService;
        IStudentLectureNoteService _studentLectureNoteService;
        public StudentController(IStudentService studentService, IParameterService parameterService, IStudentLectureNoteService studentLectureNoteService)
        {
            _studentService = studentService;
            _parameterService = parameterService;
            _studentLectureNoteService = studentLectureNoteService;
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
                var lessons = _parameterService.GetParameterByParamType("LESSON").Data;

                foreach (var item in lessons)
                {
                    StudentLectureNote studentLectureNote = new StudentLectureNote();
                    studentLectureNote.StudentId = result.Data.Id;
                    studentLectureNote.LessonId = item.ParamCode;

                    _studentLectureNoteService.Add(studentLectureNote);
                }
            }
            return Ok(result);
        }


        [HttpGet("getStudentById/{studentId:int}")]
        public IActionResult GetStudentById(int studentId)
        {
            var result = _studentService.GetStudentById(studentId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("updateStudentInfo")]
        public IActionResult UpdateStudentInfo(Student student)
        {
            var result = _studentService.Update(student);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
