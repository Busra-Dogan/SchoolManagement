using Microsoft.EntityFrameworkCore;
using SchoolManagement.Core.DataAccess;
using SchoolManagement.Core.Entities;
using SchoolManagement.DataAccess.Abstract;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Concrete
{
    public class EfParameter : EfEntityRepositoryBase<Parameter, SchoolManagementDbContext>, IParameter
    {
        public List<Parameter> GetParametersByParamType(string paramType)
        {
            using (SchoolManagementDbContext context = new())
            {
                return context.Set<Parameter>().Where(x =>x.ParamType == paramType).ToList();
            }
        }
    }
}
