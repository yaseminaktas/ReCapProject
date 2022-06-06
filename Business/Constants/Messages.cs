using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarnameInvalid = "Araaba ismi geçersiz";
        public static string CarUpdated = "Araba bilgileri başarıyla güncellendi";
        public static string CarDeleted = "Araba bilgileri başarıyla silindi";
        /////////////////////////////////////////////////////////////////////////
        public static string ColorAdded = "Renk eklendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorUpdated = "Renk bilgisi başarıyla güncellendi";
        public static string ColorDeleted = "Renk bilgisi başarıyla silindi";
        /////////////////////////////////////////////////////////////////////////
        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandUpdated = "Marka bilgisi başarıyla güncellendi";
        public static string BrandDeleted = "Marka bilgisi başarıyla silindi";
        /////////////////////////////////////////////////////////////////////////
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserListed = "Kullanıcılar listelendi";
        /////////////////////////////////////////////////////////////////////////
        public static string RentalAdded = "Araba kiralandı";
        public static string AuthorizationDenied;
        internal static string AccessTokenCreated;
        internal static string UserAlreadyExists;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static User UserNotFound;
        internal static string UserRegistered;
        /////////////////////////////////////////////////////////////////////////

    }
}
