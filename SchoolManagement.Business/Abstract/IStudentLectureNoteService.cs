using SchoolManagement.Core.Results;
using SchoolManagement.Entities.Dtos;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Entities.Contract;

namespace SchoolManagement.Business.Abstract
{
    public  interface IStudentLectureNoteService
    {
        IDataResult<List<StudentLectureNote>> GetAll();
        IDataResult<StudentLectureNote> GetById(int id);
        IResult Add(StudentLectureNote note);
        IResult Delete(int id);
        IResult Update(StudentLectureNote note);
        IDataResult<List<StudentLectureNoteDto>> GetAllNotesByStudent(int studentId);
    }
}
