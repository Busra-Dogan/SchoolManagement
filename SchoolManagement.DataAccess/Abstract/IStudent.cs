using SchoolManagement.Core.DataAccess;
using SchoolManagement.Core.Results;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Abstract
{
    public interface IStudent : IEntityRepository<Student>
    {
        //List<ClassListDto> GetAllClass();
        //IDataResult<Student> GetStudentById(int studentId);
    }
}
