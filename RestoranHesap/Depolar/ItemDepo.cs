using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestoranHesap.Models;


namespace RestoranHesap.Depolar
{
    public class ItemDepo
    {
        private DbRestoranEntities1 db;

        public ItemDepo()
        {
            db = new DbRestoranEntities1();
        }

        public IEnumerable<SelectListItem> GetAllItem()
        {
            var dbSelectListItems = new List<SelectListItem>();
            dbSelectListItems = (from x in db.tbl_item
                                 select new SelectListItem()
                                 {
                                     Value = x.ItemId.ToString(),
                                     Text = x.Itemname,
                                     Selected = true

                                 }).ToList();
            return dbSelectListItems;
        }

    }
}