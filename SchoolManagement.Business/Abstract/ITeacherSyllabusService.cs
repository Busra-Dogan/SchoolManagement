using SchoolManagement.Core.Results;
using SchoolManagement.Entities.Contract;
using SchoolManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Abstract
{
    public interface ITeacherSyllabusService
    {
        IDataResult<List<TeacherSyllabusListDto>> GetAllLessonsByTeacherId(int teacherId);
        IResult Add(TeacherSyllabus teacherSyllabus);
        IResult Update(TeacherSyllabus teacherSyllabus);
        IResult Delete(int teacherId);

    }
}
