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
    public class SchoolManager: ISchoolService
    {
        ISchool _school;
        public SchoolManager(ISchool school)
        {
            _school= school;
        }

        public IResult Add(School school)
        {
            if (school.Quota <= 0)
            {
                return new ErrorResult(ErrorMessages.QutoaNotSmallOrEqualZero);
            }
            _school.Add(school);
            return new SuccessResult(Messages.SchoolAdded);
        }

        public IResult Delete(School school)
        {
            if (school != null)
            {
                _school.Delete(school);
                return new SuccessResult(Messages.SchoolDeleted);
            }
            else
            {
                return new ErrorResult(ErrorMessages.SchoolNotDeleted);
            }
        }

        public IDataResult<List<School>> GetAll()
        {
            List<School> schools = _school.GetAll();

            if (schools != null && schools.Count != 0)
            {
                return new SuccessDataResult<List<School>>(schools, Messages.SchoolListed);
            }
            else
            {
                return new ErrorDataResult<List<School>>(schools, ErrorMessages.NoRegisteredSchool);
            }
        }

        public IDataResult<School> GetSchoolById(int schoolId)
        {
            School school = _school.Get(c => c.SchoolId == schoolId);
            if (school != null)
            {
                return new SuccessDataResult<School>(school, Messages.GetSchoolInformation);
            }
            else
            {
                return new ErrorDataResult<School>(school, ErrorMessages.SchoolInformationNotFound);
            }
        }

        public IResult Update(School school)
        {
            if (school != null)
            {
                _school.Update(school);
                return new SuccessResult(Messages.SchoolUpdated);
            }
            else
            {
                return new ErrorResult(ErrorMessages.SchoolInformationNotUpdated);
            }
        }
    }
}
