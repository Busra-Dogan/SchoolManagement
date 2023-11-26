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
        public IDataResult<List<TeacherSyllabusListDto>> GetAllLessonsByTeacherId(int teacherId)
        {
            using (var context = new SchoolManagementDbContext())
            {
                var result = from teacherSyllabus in context.TEACHERSYLLABUS
                             join day in context.PARAMETER on teacherSyllabus.DayId equals day.ParamCode
                             join teacher in context.TEACHER on teacherSyllabus.TeacherId equals teacher.Id
                             where teacherSyllabus.TeacherId == teacherId
                             where day.ParamType == "DAY"

                             select new TeacherSyllabusListDto
                             {
                                 Id = teacherSyllabus.Id,
                                 DayId = teacherSyllabus.DayId,
                                 Day = day.ParamValue,
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
                                 TeacherNameSurname = teacher.NameSurname,
                                 SystemDate = teacherSyllabus.SystemDate,
                                 UpdateSystemDate = teacherSyllabus.UpdateSystemDate
                             };
                if (result == null || result.ToList().Count == 0)
                {
                    return new ErrorDataResult<List<TeacherSyllabusListDto>>(ErrorMessages.TeacherSyllabusInfoNotFound);
                }
                else
                {
                    return new SuccessDataResult<List<TeacherSyllabusListDto>>(result.ToList(), Messages.GetTeacherSyllabus);
                }

            }
        }
    }
}
