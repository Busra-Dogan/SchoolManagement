using SchoolManagement.Core.DataAccess;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Abstract
{
    public interface IClass : IEntityRepository<Class>
    {
        List<ClassListDto> GetAllClass();
        Class GetClassById(int classId);

    }
}
