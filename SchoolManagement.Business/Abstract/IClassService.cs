using SchoolManagement.Core.Results;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Abstract
{
    public interface IClassService
    {
        IDataResult<List<Class>> GetAll();
        IDataResult<Class> GetClassById(int classId);
        IResult Add(Class classforAdd);
        IResult Delete(int classId);
        IDataResult<List<ClassListDto>> GetAllClass();

    }
}
