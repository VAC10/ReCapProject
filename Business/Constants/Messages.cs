using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages // business katmanımda string ifadeye yer vermemek için bütün string ifadelerimi bu class'ta toplayacağım
    {
        public static string BrandAdded = "Ürün Eklendi";
        public static string BrandNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string BrandListed = "ürünler listelendi";
        public static string CarListed="ürünler listelendi";
        public static string İnvalidUserName="Geçersiz kullanıcı adı lütfen tekrar deneyiniz";
       public static string UserAdded="Kullanıcı Eklendi";
        public  static string İnvalidPassword="Parola en az 5 karakterli olmalıdır";
        public static string UserListed="Kullanıcılar listelendi";
       public static string DeletedSuccess="kullanıcı silindi";
        public static string NotDeleted="Böyle bir kullanıcı olmadığından silme işlemi gerçekleştirilemiyor.";
       public static string NotRetrieveCar="Araba teslim alınmadığından bu işlem gerçekleştirilemiyor. Lütfen arabayı teslim ettikten sonra tekrar deneyiniz.";
        public static string RentalAdded= " Kiralanacak Araba bilgileri eklendi";
        public static string CarAdded = "Araba Eklendi";
        public static string UpdateAvailable="Güncelleme gerçekleştirildi.";
        public static string NotUpdate="Güncelleme gerçekleştirilemedi. Lütfen tekrar deneyiniz.";
        public static string RentalListed="Kiralama bilgileri Listelendi.";
    }
}
