using SchoolManagement.Business.Abstract;
using SchoolManagement.Core.Constants;
using SchoolManagement.Core.Results;
using SchoolManagement.DataAccess.Abstract;
using SchoolManagement.DataAccess.Concrete;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        ITeacher _teacher;
        public TeacherManager(ITeacher iTeacher)
        {
            _teacher = iTeacher;
        }
        public IResult Add(Teacher teacher)
        {
            _teacher.Add(teacher);
            return new SuccessResult(Messages.TeacherAdded);
        }

        public IResult Delete(int teacherId)
        {
            if (teacherId == 0)
            {
                return new ErrorResult(ErrorMessages.TeacherIdIsNull);
            }
            else
            {
                Teacher teacherInformation = GetTeacherById(teacherId).Data;

                if (teacherInformation != null)
                {
                    _teacher.Delete(teacherInformation);
                    return new SuccessResult(Messages.TeacherDeleted);
                }
                else
                {
                    return new ErrorResult(ErrorMessages.TeacherInfoIsNotFind);
                }
            }
        }

        public IDataResult<List<Teacher>> GetAll()
        {
            List<Teacher> teachers =  _teacher.GetAll();
            return new SuccessDataResult<List<Teacher>>(teachers, Messages.TeachersListed);
        }

        public IDataResult<Teacher> GetTeacherById(int teacherId)
        {
            Teacher teacher = _teacher.GetTeacherById(teacherId);
            return new SuccessDataResult<Teacher>(teacher, Messages.GetTeacherInformation);
        }

        public IResult Update(Teacher teacher)
        {
            _teacher.Update(teacher);
            return new SuccessResult(Messages.TeacherInformationUpdated);
        }
    }
}
