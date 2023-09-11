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
        public static string SchoolAdded = "Okul sisteme başarılı olarak eklenmiştir.";
        public static string SchoolDeleted = "Okul bilgileri silinmiştir.";
        public static string SchoolUpdated = "Okul bilgileri güncellenmiştir.";
        public static string GetSchoolInformation = "Okul bilgileri getirilmiştir.";
        public static string SchoolListed = "Kayıtlı okullar listelenmiştir.";
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
    }
}
