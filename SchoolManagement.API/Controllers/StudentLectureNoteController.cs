using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstract;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Contract;
using SchoolManagement.Entities.Dtos;

namespace SchoolManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentLectureNoteController : Controller
    {
        IStudentLectureNoteService _noteService;
        public StudentLectureNoteController(IStudentLectureNoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet("notesbystudent/{studentId:int}")]
        public IActionResult GetAllNotesByStudent(int studentId)
        {
            var result = _noteService.GetAllNotesByStudent(studentId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("updateStudentInfo")]
        public IActionResult UpdateNotes(List<StudentLectureNoteDto> notes)
        {
            SchoolManagement.Core.Results.IResult result = null;
            foreach (var item in notes)
            {
                StudentLectureNote note = new StudentLectureNote()
                {
                    Id = item.Id,
                    StudentId = item.StudentId,
                    LessonId = item.LessonId,
                    Note1 = (double)(item.Note1 == null ? 0 : item.Note1),
                    Note2 = (double)(item.Note2 == null ? 0 : item.Note2),
                    Note3 = (double)(item.Note3 == null ? 0 : item.Note3),
                    Average = (float)item.Average,
                    IsPassed = (bool)item.IsPassed
                };
                result = _noteService.Update(note);
                if (result.Success)
                {
                    continue;
                }
                else
                {
                    return BadRequest(result);
                }
            }
            return Ok(result);
        }
    }
}
