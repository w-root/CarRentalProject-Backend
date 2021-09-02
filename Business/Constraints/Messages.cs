using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constraints
{
    public static class Messages
    {
        public static string DataListed = "Veri Getirildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";



        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandListed = "Markalar Listelendi";
        public static string BrandUpdated = "Marka Güncellendi";

  
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorListed = "Renkler Listelendi";
        public static string ColorUpdated = "Renk Güncellendi";


        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarListed = "Arabalar Getirildi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarDetailListed = "Araba Detayları Getirildi";
  

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserListed = "Kullanıcılar Getirildi";
        public static string UserUpdated = "Kullanıcı Güncellendi";


        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerListed = "Müşteriler Listelendi";


        public static string RentalAdded = "Kiralama Eklendi";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string RentalListed = "Kiralamalar Getirildi";
        public static string RentalUpdated = "Kiralama Güncellendi";

        public static string CarCantRent = "Araba Önceden Kiralanmış!";
        public static string CheckDates = "Araba Kiralanamadı ! Lütfen Tarihleri Kontrol Ediniz.";

        public static string OverflowCarImageMessage = "Aracın 5 ten fazla Resmi olamaz";
        public static string CarImageAdded = "Araç Resmi Başarı İle Eklendi";
        public static string CarImageNotFound = "Resim Bulunamadı";
        public static string CarImageDeleted = "Araç Resmi Silindi";
        public static string CarImageListed = "Araç Resimi Getirildi";
        public static string CarImageUpdated = "Araç Resmi Güncellendi";
    }
}
