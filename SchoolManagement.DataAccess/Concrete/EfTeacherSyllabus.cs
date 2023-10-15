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
    public class EfTeacherSyllabus : EfEntityRepositoryBase<TeacherSyllabus, SchoolManagementDbContext>, ITeacherSyllabus
    {
        public IDataResult<List<TeacherSyllabus>> GetAllLessonsByTeacherId(int teacherId)
        {
            using (var context = new SchoolManagementDbContext())
            {
                var result = from teacherSyllabus in context.TEACHERSYLLABUS
                             where teacherSyllabus.TeacherId == teacherId
                             select new TeacherSyllabus
                             {
                                 Id = teacherSyllabus.Id,
                                 DayId = teacherSyllabus.DayId,
                                 Lesson1 = teacherSyllabus.Lesson1,
                                 Lesson2 = teacherSyllabus.Lesson2,
                                 Lesson3 = teacherSyllabus.Lesson3,
                                 Lesson4 = teacherSyllabus.Lesson4,
                                 Lesson5 = teacherSyllabus.Lesson5,
                                 Lesson6 = teacherSyllabus.Lesson6,
                                 Lesson7 = teacherSyllabus.Lesson7,
                                 Lesson8 = teacherSyllabus.Lesson8,
                                 Lesson9 = teacherSyllabus.Lesson9,
                                 Lesson10 = teacherSyllabus.Lesson10,
                                 LessonTimeId = teacherSyllabus.LessonTimeId,
                                 TeacherId = teacherSyllabus.TeacherId,
                                 SystemDate = teacherSyllabus.SystemDate,
                                 UpdateSystemDate = teacherSyllabus.UpdateSystemDate
                             };
                if (result == null || result.ToList().Count == 0)
                {
                    return new ErrorDataResult<List<TeacherSyllabus>>(ErrorMessages.TeacherSyllabusInfoNotFound);
                }
                else
                {
                    return new SuccessDataResult<List<TeacherSyllabus>>(result.ToList(), Messages.GetTeacherSyllabus);
                }

            }
        }
    }
}
