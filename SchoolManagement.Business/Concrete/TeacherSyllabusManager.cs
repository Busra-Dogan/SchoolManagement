using SchoolManagement.Business.Abstract;
using SchoolManagement.Core.Constants;
using SchoolManagement.Core.Results;
using SchoolManagement.DataAccess.Abstract;
using SchoolManagement.DataAccess.Concrete;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Concrete
{
    internal class TeacherSyllabusManager : ITeacherSyllabusService
    {
        ITeacherSyllabus _teacherSyllabus;
        public TeacherSyllabusManager(ITeacherSyllabus teacherSyllabus)
        {
            _teacherSyllabus = teacherSyllabus;
        }
        public IResult Add(TeacherSyllabus teacherSyllabus)
        {
            if (teacherSyllabus.DayId == 0 || teacherSyllabus.TeacherId == 0)
            {
                return new ErrorResult(ErrorMessages.DayOrTeacherIdIsNull);
            }
            _teacherSyllabus.Add(teacherSyllabus);
            return new SuccessResult(Messages.TeacherSyllabusAdded);
        }

        public IResult Delete(int teacherId)
        {
            if (teacherId == 0)
            {
                return new ErrorResult(ErrorMessages.TeacherIdIsNull);
            }
            else
            {
                List<TeacherSyllabus> getTeacherSyllabus = GetAllLessonsByTeacherId(teacherId).Data;
                foreach (var item in getTeacherSyllabus)
                {
                    _teacherSyllabus.Delete(item);
                }
                return new SuccessResult(Messages.TeacherSyllabusDeleted);

                //todo: burada hata yönetimi yapılması gerekiyor.
            }
        }

        public IDataResult<List<TeacherSyllabus>> GetAllLessonsByTeacherId(int teacherId)
        {
            if (teacherId == 0)
            {
                return new ErrorDataResult<List<TeacherSyllabus>>(ErrorMessages.TeacherIdIsNull);
            }
            return _teacherSyllabus.GetAllLessonsByTeacherId(teacherId);
        }

        public IResult Update(TeacherSyllabus teacherSyllabus)
        {
            if (teacherSyllabus.DayId == 0 || teacherSyllabus.TeacherId == 0)
            {
                return new ErrorResult(ErrorMessages.DayOrTeacherIdIsNull);
            }
            _teacherSyllabus.Update(teacherSyllabus);
            return new SuccessResult(Messages.TeacherSyllabusAdded);
        }
    }
}
