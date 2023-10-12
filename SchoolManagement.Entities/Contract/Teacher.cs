using SchoolManagement.Entities.Abstract;

namespace SchoolManagement.Entities
{
    public class Teacher : ContractBase
    {
        private int id;
        private string? nameSurname;
        private int lessonId;
        private int schoolId;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string? NameSurname
        {
            get => nameSurname;
            set => nameSurname = value;
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
