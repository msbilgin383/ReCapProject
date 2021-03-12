using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarPriceInvalid = "Araç fiyatı geçersiz";
        public static string CarDeleted = "Araç silindi";
        public static string CarListed = "Araçlar listelendi";
        public static string InvalidCarRent = "Araç teslim edilmemiş";
        public static string RentalAdded = "Araç başarıya kiralandı";
        public static string SuccesfullyDeleted = "Başarıyla silindi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string AuthorizationDenied = "Erişim reddedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Yanlış parola";
    }
}
