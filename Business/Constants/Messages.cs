using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersizdir";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün bulunabilir";
        public static string ProductNameAlreadyExist = "Ürün adı zaten kullanımda";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemez";
    }
}
