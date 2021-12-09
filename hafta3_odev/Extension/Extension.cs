using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hafta3_odev_Api.Extension
{
    public static class Extension
    {
        public static void ToTurkishConvert(this Product p)
        {
            p.ProductPrice = $"{p.ProductPrice} ₺";
        }
    }
}
