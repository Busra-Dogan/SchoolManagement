using SchoolManagement.Core.DataAccess;
using SchoolManagement.Core.Results;
using SchoolManagement.Entities.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Abstract
{
    public interface ITeacherSyllabus : IEntityRepository<TeacherSyllabus>
    {
        IDataResult<List<TeacherSyllabus>> GetAllLessonsByTeacherId(int teacherId);
    }
}
