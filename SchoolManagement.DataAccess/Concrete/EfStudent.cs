using SchoolManagement.Core.DataAccess;
using SchoolManagement.DataAccess.Abstract;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Concrete
{
    public class EfStudent : EfEntityRepositoryBase<Student, SchoolManagementDbContext>, IStudent
    {
    }
}
