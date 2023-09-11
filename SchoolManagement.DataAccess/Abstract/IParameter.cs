using SchoolManagement.Core.DataAccess;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Abstract
{
    public interface IParameter : IEntityRepository<Parameter>
    {
        List<Parameter> GetParametersByParamType(string paramType);
    }
}
