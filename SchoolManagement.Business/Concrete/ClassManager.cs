using SchoolManagement.Business.Abstract;
using SchoolManagement.Core.Constants;
using SchoolManagement.Core.Results;
using SchoolManagement.DataAccess.Abstract;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Concrete
{
    public class ClassManager : IClassService
    {
        //dependecy injection
        IClass _class;
        public ClassManager(IClass iClass)
        {
            _class = iClass;
        }

        public IResult Add(Class classContract)
        {
            if (classContract.Quota <= 0)
            {
                return new ErrorResult(ErrorMessages.QutoaNotSmallOrEqualZero);
            }
            _class.Add(classContract);
            return new SuccessResult(Messages.ClassAdded);
        }

        public IResult Delete(int classId)
        {
            if (classId <= 0)
            {
                return new ErrorResult(ErrorMessages.ClassContractNotBeNull);
            }
            else
            {
                Class getClassforDelete = GetClassById(classId).Data;

                if (getClassforDelete != null)
                {
                    _class.Delete(getClassforDelete);
                    return new SuccessResult(Messages.ClassDeleted);
                }
                else
                {
                    return new ErrorResult(ErrorMessages.ClassContractNotBeNull);
                }
            }
        }

        public IDataResult<List<Class>> GetAll()
        {
            List<Class> classes = _class.GetAll();

            if (classes != null && classes.Count != 0)
            {
                return new SuccessDataResult<List<Class>>(classes, Messages.ClassListed);
            }
            else
            {
                return new ErrorDataResult<List<Class>>(classes, ErrorMessages.NoRegisteredClass);
            }
        }

        public IDataResult<List<ClassListDto>> GetAllClass()
        {
            List<ClassListDto> AllClasses = _class.GetAllClass();

            if (AllClasses != null && AllClasses.Count != 0)
            {
                return new SuccessDataResult<List<ClassListDto>>(AllClasses, Messages.ClassListed);
            }
            else
            {
                return new ErrorDataResult<List<ClassListDto>>(AllClasses, ErrorMessages.NoRegisteredClass);
            }
        }

        public IDataResult<Class> GetClassById(int classId)
        {
            Class getClassbyId = _class.GetClassById(classId);
            
            if (getClassbyId != null)
            {
                return new SuccessDataResult<Class>(getClassbyId, Messages.ClassListed);
            }
            else
            {
                return new ErrorDataResult<Class>(getClassbyId, ErrorMessages.NoRegisteredClass);
            }
        }
    }
}
