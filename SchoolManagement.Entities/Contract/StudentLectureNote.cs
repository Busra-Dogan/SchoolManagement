using SchoolManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities.Contract
{
    public class StudentLectureNote : ContractBase
    {
        private int id;
        private int studentId;
        private int lessonId;
        private float note1;
        private float note2;
        private float note3;
        private float average;
        private bool isPassed;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public int StudentId
        {
            get => studentId;
            set => studentId = value;
        }
        public int LessonId
        {
            get => lessonId;
            set => lessonId = value;
        }
        public float Note1
        {
            get => note1; 
            set => note1 = value;
        }
        public float Note2
        {
            get => note2;
            set => note2 = value;
        }
        public float Note3
        {
            get => note3; 
            set => note3 = value;
        }
        public float Average
        {
            get => average; 
            set => average = value;
        }
        public bool IsPassed
        {
            get => isPassed; 
            set => isPassed = value;
        }
    }
}
