using SchoolManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities
{
    public class School : ContractBase
    {
        private int id;
        private string? name;
        private string? province;
        private string? district;
        private int quota;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string? Name
        {
            get => name;
            set => name = value;
        }
        public string? Province
        {
            get => province;
            set => province = value;
        }
        public string? District
        {
            get => district;
            set => district = value;
        }
        public int Quota
        {
            get => quota;
            set => quota = value;
        }
    }
}
