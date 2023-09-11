using SchoolManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities
{
    public class Student : ContractBase
    {
        private int studentId;
        private string? studentName;
        private string? studentSurname;
        private int classId;

        public int StudentId
        {
            get => studentId;
            set => studentId = value;
        }
        public string? StudentName
        {
            get => studentName;
            set => studentName = value;
        }
        public string? StudentSurname
        {
            get => studentSurname;
            set => studentSurname = value;
        }
        public int ClassId
        {
            get => classId;
            set => classId = value;
        }
    }
}
