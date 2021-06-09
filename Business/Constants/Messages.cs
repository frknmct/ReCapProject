using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar Listelendi";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka güncellendi.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorUpdated = "Renk güncellendi.";

        public static string CustomerAdded = "Customer eklendi.";
        public static string CustomerDeleted = "Customer silindi.";
        public static string CustomerUpdated = "Customer güncellendi.";

        public static string UserAdded = "User eklendi.";
        public static string UserDeleted = "User silindi.";
        public static string UserUpdated = "User güncellendi.";

        public static string RentalAdded = "Rental eklendi.";

        public static string CarImagesAdded = "Araba fotoğraflarına eklendi.";
        public static string CarImagesDeleted = "Araba fotoğrafı silindi.";
        public static string CarImagesUpdated = "Araba fotoğrafları güncellendi.";
        public static string CarImagesNotFound = "Fotoğraf bulunamadı.";

        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Kullanıcı kayıt oldu.";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Şifre hatalı.";
        public static string SuccessfulLogin="Giriş başarılı.";
        public static string UserAlreadyExists="Böyle bir kullanıcı var.";
        public static string AccessTokenCreated="Token oluşturuldu.";
    }
}
