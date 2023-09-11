using SchoolManagement.Core.Results;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Abstract
{
    public interface ISchoolService
    {
        IDataResult<List<School>> GetAll();
        IDataResult<School> GetSchoolById(int schoolId);
        IResult Add(School school);
        IResult Update(School school);
        IResult Delete(School school);
    }
}
