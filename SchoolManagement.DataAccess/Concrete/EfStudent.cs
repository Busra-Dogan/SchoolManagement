using SchoolManagement.Core.DataAccess;
using SchoolManagement.Core.Results;
using SchoolManagement.DataAccess.Abstract;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Concrete
{
    public class EfStudent : EfEntityRepositoryBase<Student, SchoolManagementDbContext>, IStudent
    {
        //public IDataResult<Student> GetStudentById(int studentId)
        //{
        //    using (var context = new SchoolManagementDbContext())
        //    {
        //        var result = from studentTable in context.STUDENT
        //                     where studentTable.Id == studentId
        //                     select new Student
        //                     {
        //                         Id = studentTable.Id,
        //                         NameSurname = teacherTable.NameSurname,
        //                         LessonId = teacherTable.LessonId,
        //                         SchoolId = teacherTable.SchoolId,
        //                         SystemDate = teacherTable.SystemDate
        //                     };

        //        return result.FirstOrDefault();
        //    }
        //}
    }
}
