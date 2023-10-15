using SchoolManagement.Core.Results;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Abstract
{
    public interface ITeacherService
    {
        IDataResult<List<Teacher>> GetAll();
        IDataResult<Teacher> GetTeacherById(int teacherId);
        IResult Add(Teacher teacher);
        IResult Update(Teacher teacher);
        IResult Delete(int id);
    }
}
