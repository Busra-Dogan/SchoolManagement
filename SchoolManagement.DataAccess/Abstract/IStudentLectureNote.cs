using SchoolManagement.Core.DataAccess;
using SchoolManagement.Core.Results;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Contract;
using SchoolManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Abstract
{
    public interface IStudentLectureNote : IEntityRepository<StudentLectureNote>
    {
        IDataResult<List<StudentLectureNoteDto>> GetAllNotesByStudent(int studentIds);
    }
}
