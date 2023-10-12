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
        private int id;
        private string name;
        private string surname;
        private string identityNumber;
        private DateTime birthDate;
        private string motherName;
        private string fatherName;
        private string telephone;
        private string eMailAddress;
        private string address;
        private string parentPhoneNumber;
        private int? classId;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Surname
        {
            get => surname;
            set => surname = value;
        }
        public string IdentityNumber
        {
            get => identityNumber;
            set => identityNumber = value;
        }
        public DateTime BirthDate
        {
            get => birthDate;
            set => birthDate = value;
        }
        public string MotherName
        {
            get => motherName;
            set => motherName = value;
        }
        public string FatherName
        {
            get => fatherName;
            set => fatherName = value;
        }
        public string Telephone
        {
            get => telephone;
            set => telephone = value;
        }
        public string EMailAddress
        {
            get => eMailAddress;
            set => eMailAddress = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public string ParentPhoneNumber
        {
            get => parentPhoneNumber;
            set => parentPhoneNumber = value;
        }
        public int? ClassId
        {
            get => classId;
            set => classId = value;
        }
    }
}
