using SchoolManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities
{
    public class Teacher : ContractBase
    {
        private int teacherId;
        private string? teacherName;
        private string? teacherSurname;
        private int schoolId;
        private int lessonId;

        public int TeacherId
        {
            get => teacherId;
            set => teacherId = value;
        }
        public string? TeacherName
        {
            get => teacherName;
            set => teacherName = value;
        }
        public string? TeacherSurname
        {
            get => teacherSurname;
            set => teacherSurname = value;
        }
        public int LessonId
        {
            get => lessonId;
            set => lessonId = value;
        }
        public int SchoolId
        {
            get => schoolId;
            set => schoolId = value;
        }
    }
}
