using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestoranHesap.ViewModel
{
    public class ItemViewModel
    {
        public int ItemId { get; set; }
        public string ItemAd { get; set; }

        public decimal Itemucret { get; set; }
    }
}