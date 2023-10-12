using SchoolManagement.Business.Abstract;
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
    public class TeacherManager : ITeacherService
    {
        ITeacher _iTeacher;
        public TeacherManager(ITeacher iTeacher)
        {
            _iTeacher = iTeacher;
        }
        public IResult Add(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Teacher>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Teacher> GetSchoolById(int teacherId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
