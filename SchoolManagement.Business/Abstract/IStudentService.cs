using SchoolManagement.Core.Results;
using SchoolManagement.Entities.Dtos;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Abstract
{
    public interface IStudentService
    {
        IDataResult<List<Student>> GetAll();
        IDataResult<Student> GetStudentById(int studentId);
        IDataResult<Student> Add(Student studentforAdd);
        IResult Delete(int studentId);
        IResult Update(Student student);

    }
}
