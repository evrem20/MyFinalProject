using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime = "Sistem bakımda";
        internal static string ProductsListed = "Ürünler listelemdi";
        internal static string ProductCountOfCategoryError= "Bir kategoride en fazla 10 ürün olabilir";
        internal static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        internal static string ProductUpdated = "Ürün güncellendi";
    }
}
