using SchoolManagement.Core.Results;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Abstract
{
    public interface IParameterService
    {
        //IDataResult<List<Parameter>> GetAll();
        IDataResult<List<Parameter>> GetParameterByParamType(string paramType);
        IResult Add(Parameter parameter);
        //IResult Update(Class category);
        IResult Delete(Parameter parameter);
    }
}
