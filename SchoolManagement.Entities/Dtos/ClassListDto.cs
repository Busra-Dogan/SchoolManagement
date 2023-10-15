using SchoolManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities.Dtos
{
    public class ClassListDto : ContractBase
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int Quota { get; set; }
        public string SchoolName { get; set; }
        public int WhichGrade { get; set; }
        public DateTime SystemDate { get; set; }
    }
}
