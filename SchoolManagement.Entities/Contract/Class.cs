using SchoolManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities
{
    public class Class : ContractBase
    {
        private int id;
        private string? className;
        private int quota;
        private int whichGrade;
        private int classType;
        private int schoolId;
        private DateTime systemDate;
        private DateTime updateSystemDate;


        [Required]
        public int Id
        {
            get => id;
            set => id = value;
        }
        [Required]
        public string? ClassName
        {
            get => className;
            set => className = value;
        }
        [Required]
        public int Quota
        {
            get => quota;
            set => quota = value;
        }

        public int ClassType
        {
            get => classType;
            set => classType = value;
        }

        public int SchoolId
        {
            get => schoolId;
            set => schoolId = value;
        }

        public int WhichGrade
        {
            get => whichGrade;
            set => whichGrade = value;
        }

        public DateTime SystemDate
        {
            get => systemDate;
            set => systemDate = value;
        }

        public DateTime UpdateSystemDate
        {
            get => updateSystemDate;
            set => updateSystemDate = value;
        }
    }
}
