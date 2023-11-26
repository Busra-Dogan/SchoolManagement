using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Core.Constants;
using SchoolManagement.Core.DataAccess;
using SchoolManagement.Core.Results;
using SchoolManagement.DataAccess.Abstract;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DataAccess.Concrete
{
    public class EfClass : EfEntityRepositoryBase<Class, SchoolManagementDbContext>, IClass
    {
        public IDataResult<List<ClassListDto>> GetAllClass()
        {
            using (var context = new SchoolManagementDbContext())
            {
                var result = from classtable in context.CLASS
                                join school in context.SCHOOL
                                on classtable.SchoolId equals school.Id
                                select new ClassListDto { 
                                    Id = classtable.Id,
                                    ClassName = classtable.ClassName, 
                                    Quota = classtable.Quota, 
                                    SchoolName = school.Name,
                                    WhichGrade = classtable.WhichGrade,
                                    SystemDate = classtable.SystemDate};

                return new SuccessDataResult<List<ClassListDto>>(result.ToList(), Messages.StudentLectureNotesListed);
            }
        }

        public IDataResult<Class> GetClassById(int classId)
        {
            using (var context = new SchoolManagementDbContext())
            {
                var result = from classtable in context.CLASS
                             where classtable.Id == classId
                             select new Class
                             {
                                 Id = classtable.Id,
                                 ClassName = classtable.ClassName,
                                 Quota = classtable.Quota,
                                 WhichGrade = classtable.WhichGrade,
                                 SchoolId = classtable.SchoolId,
                                 SystemDate = classtable.SystemDate,
                                 UpdateSystemDate = classtable.UpdateSystemDate
                             };

                return new SuccessDataResult<Class>((Class)result, Messages.StudentLectureNotesListed);
            }
        }
    }
}
