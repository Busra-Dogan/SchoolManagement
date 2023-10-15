using SchoolManagement.Business.Abstract;
using SchoolManagement.Core.Constants;
using SchoolManagement.Core.Results;
using SchoolManagement.DataAccess.Abstract;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Concrete
{
    public class ParameterManager: IParameterService
    {
        //dependecy injection
        IParameter _parameter;
        public ParameterManager(IParameter parameter)
        {
            _parameter = parameter;
        }

        public IResult Add(Parameter parameterContract)
        {
            if (String.IsNullOrEmpty(parameterContract.ParamType))
            {
                return new ErrorResult(ErrorMessages.ParamTypeRequired);
            }
            _parameter.Add(parameterContract);
            return new SuccessResult(Messages.ParameterAdded);
        }

        public IResult Delete(Parameter parameterContract)
        {
            if (parameterContract != null)
            {
                _parameter.Delete(parameterContract);
                return new SuccessResult("Parametre tanımı başarılı bir şekilde silinmiştir.");
            }
            else
            {
                return new ErrorResult("Olmayan parametre silinemez.");
            }
        }

        public IDataResult<List<Parameter>> GetParameterByParamType(string paramType)
        {
            List<Parameter> parameters = _parameter.GetParametersByParamType(paramType);
            if (parameters != null && parameters.Count > 0)
            {
                return new SuccessDataResult<List<Parameter>>(parameters, "Parametre getirilmiştir.");
            }
            else
            {
                return new ErrorDataResult<List<Parameter>>(parameters, "İlgili parametre tanımı bulunamamıştır.");
            }
        }
    }
}
