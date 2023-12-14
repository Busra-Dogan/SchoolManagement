using SchoolManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities.Dtos
{
    public class StudentLectureNoteDto : ContractBase
    {
        public int Id {  get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public string? StudentName { get; set; }
        public string? LessonName { get; set; }
        public string? ClassName { get; set; }
        public double?  Note1 { get; set; }
        public double? Note2 { get; set; }
        public double? Note3 { get; set; }
        public double Average { get; set; }
        public bool? IsPassed { get; set; }
    }
}
