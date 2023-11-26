﻿using SchoolManagement.Entities.Abstract;
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
        private int note1 = 0;
        private int note2 = 0;
        private int note3 = 0;
        private float average = 0;
        private bool isPassed = false;

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
        public int Note1
        {
            get => note1; 
            set => note1 = value;
        }
        public int Note2
        {
            get => note2;
            set => note2 = value;
        }
        public int Note3
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
