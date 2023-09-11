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
        //IDataResult<Class> GetById(int categoryId);
        IResult Add(Class category);
        //IResult Update(Class category);
        IResult Delete(Class category);
        IDataResult<List<ClassListDto>> GetAllClass();

    }
}
