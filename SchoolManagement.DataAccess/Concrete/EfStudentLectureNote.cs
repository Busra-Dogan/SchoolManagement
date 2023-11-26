using SchoolManagement.Core.Constants;
using SchoolManagement.Core.DataAccess;
using SchoolManagement.Core.Results;
using SchoolManagement.DataAccess.Abstract;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Contract;
using SchoolManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Concrete
{
    public class EfStudentLectureNote : EfEntityRepositoryBase<StudentLectureNote, SchoolManagementDbContext>, IStudentLectureNote
    {
        public IDataResult<List<StudentLectureNoteDto>> GetAllNotesByStudent(int studentId)
        {
            using (var context = new SchoolManagementDbContext())
            {
                var result = from studentLectureNote in context.StudentLectureNote
                             join student in context.STUDENT on studentLectureNote.StudentId equals student.Id
                             join lesson in context.PARAMETER on studentLectureNote.LessonId equals lesson.ParamCode
                             join classTable in context.CLASS on student.ClassId equals classTable.Id
                             where studentLectureNote.StudentId == studentId
                             where lesson.ParamType == "LESSON"
                             select new StudentLectureNoteDto
                             {
                                 Id = studentLectureNote.Id,
                                 StudentId = studentId,
                                 LessonId = studentLectureNote.LessonId,
                                 StudentName = student.Name + " " + student.Surname,
                                 ClassName = classTable.ClassName,
                                 LessonName = lesson.ParamDescription,
                                 Note1 = studentLectureNote.Note1,
                                 Note2 = studentLectureNote.Note2,
                                 Note3 = studentLectureNote.Note3,
                                 Average = studentLectureNote.Average,
                                 IsPassed = studentLectureNote.IsPassed,
                                 SystemDate = studentLectureNote.SystemDate,
                                 UpdateSystemDate = studentLectureNote.UpdateSystemDate
                             };
                if (result == null || result.ToList().Count == 0)
                {
                    return new ErrorDataResult<List<StudentLectureNoteDto>>(ErrorMessages.StudentLectureNotesNotFound);
                }
                else
                {
                    return new SuccessDataResult<List<StudentLectureNoteDto>>(result.ToList(), Messages.StudentLectureNotesListed);
                }

            }
        }
    }
}
