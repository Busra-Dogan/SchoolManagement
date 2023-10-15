using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Core.Constants
{
    public static class Messages
    {
        public static string ClassAdded = "Sınıf sisteme başarılı olarak eklenmiştir.";
        public static string ClassDeleted = "Sınıf sistemden başarılı olarak silinmiştir.";
        public static string ClassListed = "Sınıflar listelenmiştir.";

        public static string ParametersListed = "Parametreler listelenmiştir.";
        public static string ParameterByParamCodeListed = "Parametre listelenmiştir.";
        public static string ParameterAdded = "Parametre tanımı yapılmıştır.";


        public static string SchoolAdded = "Okul sisteme başarılı olarak eklenmiştir.";
        public static string SchoolDeleted = "Okul bilgileri silinmiştir.";
        public static string SchoolUpdated = "Okul bilgileri güncellenmiştir.";
        public static string GetSchoolInformation = "Okul bilgileri getirilmiştir.";
        public static string SchoolListed = "Kayıtlı okullar listelenmiştir.";

        public static string StudentAddes = "Öğrenci sisteme başarılı bir şekilde kaydedilmiştir.";
        public static string StudentDeleted = "Öğrenci sistemden başarılı bir şekilde silinmiştir.";
        public static string StudentInformationUpdated = "Öğrenci bilgileri başarılı bir şekilde güncellenmiştir.";
        public static string GetStudentInformation = "Öğrenci bilgileri başarılı bir şekilde getirilmiştir.";
        public static string StudentsListed = "Öğrenciler başarılı bir şekilde listelenmiştir.";

        public static string TeacherAdded = "Öğretmen sisteme başarılı bir şekilde kaydedilmiştir.";
        public static string TeacherDeleted = "Öğretmen sistemden başarılı bir şekilde silinmiştir.";
        public static string TeacherInformationUpdated = "Öğretmen bilgileri başarılı bir şekilde güncellenmiştir.";
        public static string GetTeacherInformation = "Öğretmen bilgileri başarılı bir şekilde getirilmiştir.";
        public static string TeachersListed = "Öğretmenler başarılı bir şekilde listelenmiştir.";

        public static string TeacherSyllabusAdded = "İlgili öğretmenin ders programı sisteme başarılı bir şekilde kaydedilmiştir.";
        public static string TeacherSyllabusDeleted = "İlgili öğretmenin ders programı sistemden başarılı bir şekilde silinmiştir.";
        public static string GetTeacherSyllabus = "İlgili öğretmenin ders programı bilgileri başarılı bir şekilde getirilmiştir.";
        public static string TeacherSyllabusUpdated = "İlgili öğretmenin ders programı bilgileri başarılı bir şekilde güncellenmiştir.";

    }

    public static class ErrorMessages
    {
        public static string QutoaNotSmallOrEqualZero = "Sınıf kotası sıfırdan küçük veya eşit olamaz.";
        public static string ClassContractNotBeNull = "Sınıf seçimi yapmadan silme işlemi gerçekleştirilemez.";
        public static string NoRegisteredClass = "Sistemde kayıtlı bir sınıf yoktur.";

        public static string NoRegisteredSchool = "Sistemde kayıtlı bir okul yoktur.";
        public static string SchoolInformationNotFound = "Sistemde bu bilgiyle bir okul yoktur.";
        public static string SchoolInformationNotUpdated = "Okul bilgileri güncellenemedi. Tekrar deneyiniz.";
        public static string SchoolNotDeleted = "Okul bilgileri silinemedi. Geçerli bir okul girdiğinizden emin olunuz.";

        public static string ParamTypeRequired = "Parametre tanımlarken ParamType alanı zorunludur.";

        public static string DayOrTeacherIdIsNull = "Gün veya Öğretmen bilgisi boş gönderilemez.";
        public static string TeacherIdIsNull = "Öğretmen bilgisi boş gönderilemez.";
        public static string TeacherInfoIsNotFind = "Öğretmen bilgisi bulunamadı.";

        public static string TeacherSyllabusInfoNotFound = "Öğretmen ders programı bilgisi bulunamadı.";

        public static string StudentInfoNotFound = "Öğrenci bilgisi bulunamadı.";





    }
}
