using SchoolManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities.Dtos
{
    public class TeacherSyllabusListDto :ContractBase
    {
        public int Id { get; set; }
        public int DayId { get; set; }
        public string Day { get; set; }
        public string? Lesson1 { get; set; }
        public string? Lesson2 { get; set; }
        public string? Lesson3 { get; set; }
        public string? Lesson4 { get; set; }
        public string? Lesson5 { get; set; }
        public string? Lesson6 { get; set; }
        public string? Lesson7 { get; set; }
        public string? Lesson8 { get; set; }
        public string? Lesson9 { get; set; }
        public string? Lesson10 { get; set; }
        public int LessonTimeId { get; set; }
        public int TeacherId { get; set; }
        public string TeacherNameSurname { get; set; }

    }
}
