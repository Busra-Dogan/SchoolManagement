using SchoolManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities
{
    public class Parameter : ContractBase
    {
        private string? paramType;
        private string? paramCode;
        private string? paramDescription;
        private string? paramValue;
        private string? paramValue2;
        private string? paramValue3;
        private string? paramValue4;
        private string? paramValue5;
        private string? paramValue6;
        private string? paramValue7;
        private string? paramValue8;
        private string? paramValue9;
        private string? paramValue10;

        public string? ParamType
        {
            get => paramType;
            set => paramType = value;
        }
        public string? ParamCode
        {
            get => paramCode;
            set => paramCode = value;
        }
        public string? ParamDescription
        {
            get => paramDescription;
            set => paramDescription = value;
        }
        public string? ParamValue
        {
            get => paramValue;
            set => paramValue = value;
        }
        public string? ParamValue2
        {
            get => paramValue2;
            set => paramValue2 = value;
        }
        public string? ParamValue3
        {
            get => paramValue3;
            set => paramValue3 = value;
        }
        public string? ParamValue4
        {
            get => paramValue4;
            set => paramValue4 = value;
        }
        public string? ParamValue5
        {
            get => paramValue5;
            set => paramValue5 = value;
        }
        public string? ParamValue6
        {
            get => paramValue6;
            set => paramValue6 = value;
        }
        public string? ParamValue7
        {
            get => paramValue7;
            set => paramValue7 = value;
        }
        public string? ParamValue8
        {
            get => paramValue8;
            set => paramValue8 = value;
        }
        public string? ParamValue9
        {
            get => paramValue9;
            set => paramValue9 = value;
        }
        public string? ParamValue10
        {
            get => paramValue10;
            set => paramValue10 = value;
        }

    }
}
