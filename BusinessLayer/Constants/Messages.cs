using Domain.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        internal static List<Product> MaintenanceTime;
        internal static string ProductListed;
        internal static string ProductUpdated;
        internal static string CategoryListed;
    }
}
