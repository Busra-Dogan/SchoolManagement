using SchoolManagement.Core.DataAccess;
using SchoolManagement.Core.Results;
using SchoolManagement.DataAccess.Abstract;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Concrete
{
    public class EfTeacher : EfEntityRepositoryBase<Teacher, SchoolManagementDbContext>, ITeacher
    {
        public Teacher GetTeacherById(int teacherId)
        {
            using (var context = new SchoolManagementDbContext())
            {
                var result = from teacherTable in context.TEACHER
                             where teacherTable.Id == teacherId
                             select new Teacher
                             {
                                 Id = teacherTable.Id,
                                 NameSurname = teacherTable.NameSurname,
                                 LessonId = teacherTable.LessonId,
                                 SchoolId = teacherTable.SchoolId,
                                 SystemDate = teacherTable.SystemDate
                             };

                return result.FirstOrDefault();
            }
        }
    }
}
