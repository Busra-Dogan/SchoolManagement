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
        private int schoolId;
        private string? schoolName;
        private string? province;
        private string? district;
        private int quota;

        public int SchoolId
        {
            get => schoolId;
            set => schoolId = value;
        }
        public string? SchoolName
        {
            get => schoolName;
            set => schoolName = value;
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
