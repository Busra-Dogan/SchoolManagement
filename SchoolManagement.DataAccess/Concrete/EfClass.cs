using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Core.DataAccess;
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
        public List<ClassListDto> GetAllClass()
        {
            //List<SqlParameter> sqlParms = new List<SqlParameter>
            //{
            //    new SqlParameter { ParameterName = "@EmployeeId", Value = employee.EmployeeID },
            //    new SqlParameter { ParameterName = "@FirstName ", Value = employee.FirstName },
            //    new SqlParameter { ParameterName = "@LastName", Value = employee.LastName},
            //    new SqlParameter { ParameterName = "@MiddleInitial", Value = employee.MiddleName }
            //};
            //SchoolManagementDbContext db = new SchoolManagementDbContext();
            //List<ClassListDto> classList = db.Database.FromSql($"EXEC SCH.sel_Class");
            //List<ClassListDto> classList = (List<ClassListDto>)db.Set<ClassListDto>().FromSql($"EXEC SCH.sel_Class");

            using (SchoolManagementDbContext context = new SchoolManagementDbContext())
            {
                var result = from c in context.CLASS
                             join f in context.PARAMETER
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
