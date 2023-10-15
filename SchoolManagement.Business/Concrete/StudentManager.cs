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
    public class StudentManager : IStudentService
    {
        //dependecy injection
        IStudent _student;
        public StudentManager(IStudent iStudet)
        {
            _student = iStudet;
        }
        public IResult Add(Student studentforAdd)
        {
            if (String.IsNullOrEmpty(studentforAdd.IdentityNumber))
            {
                return new ErrorResult(ErrorMessages.QutoaNotSmallOrEqualZero);
            }
            _student.Add(studentforAdd);
            return new SuccessResult(Messages.ClassAdded);
        }

        public IResult Delete(int studentId)
        {
            if (studentId == 0)
            {
                return new ErrorResult(ErrorMessages.QutoaNotSmallOrEqualZero);
            }
            else
            {
                Student getStudentforDelete = GetStudentById(studentId).Data;

                if (getStudentforDelete != null)
                {
                    _student.Delete(getStudentforDelete);
                    return new SuccessResult(Messages.ClassDeleted);
                }
                else
                {
                    return new ErrorResult(ErrorMessages.ClassContractNotBeNull);
                }
            }
        }

        public IDataResult<List<Student>> GetAll()
        {
            List<Student> students = _student.GetAll();

            if (students != null && students.Count != 0)
            {
                return new SuccessDataResult<List<Student>>(students, Messages.ClassListed);
            }
            else
            {
                return new ErrorDataResult<List<Student>>(students, ErrorMessages.NoRegisteredClass);
            }
        }

        public IDataResult<Student> GetStudentById(int studentId)
        {
            Student student = _student.Get(p => p.Id == studentId);
            if (student == null)
            {
                return new ErrorDataResult<Student>(ErrorMessages.StudentInfoNotFound);
            }
            else
            {
                return new SuccessDataResult<Student>(student,Messages.GetStudentInformation);
            }
        }
    }
}
