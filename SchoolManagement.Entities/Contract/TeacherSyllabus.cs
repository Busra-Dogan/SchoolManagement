using SchoolManagement.Entities.Abstract;

namespace SchoolManagement.Entities.Contract
{
    public class TeacherSyllabus : ContractBase
    {
        private int id;
        private int dayId;
        private string? lesson1;
        private string? lesson2;
        private string? lesson3;
        private string? lesson4;
        private string? lesson5;
        private string? lesson6;
        private string? lesson7;
        private string? lesson8;
        private string? lesson9;
        private string? lesson10;
        private int lessonTimeId;
        private int teacherId;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public int DayId
        {
            get => dayId;
            set => dayId = value;
        }
        public string? Lesson1
        {
            get => lesson1;
            set => lesson1 = value;
        }
        public string? Lesson2
        {
            get => lesson2;
            set => lesson2 = value;
        }
        public string? Lesson3
        {
            get => lesson3;
            set => lesson3 = value;
        }
        public string? Lesson4
        {
            get => lesson4;
            set => lesson4 = value;
        }
        public string? Lesson5
        {
            get => lesson5;
            set => lesson5 = value;
        }
        public string? Lesson6
        {
            get => lesson6;
            set => lesson6 = value;
        }
        public string? Lesson7
        {
            get => lesson7;
            set => lesson7 = value;
        }
        public string? Lesson8
        {
            get => lesson8;
            set => lesson8 = value;
        }
        public string? Lesson9
        {
            get => lesson9;
            set => lesson9 = value;
        }
        public string? Lesson10
        {
            get => lesson10;
            set => lesson10 = value;
        }
        public int LessonTimeId
        {
            get => lessonTimeId;
            set => lessonTimeId = value;
        }
        public int TeacherId
        {
            get => teacherId;
            set => teacherId = value;
        }
    }
}
