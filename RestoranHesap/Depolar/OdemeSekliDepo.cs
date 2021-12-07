using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestoranHesap.Models;
namespace RestoranHesap.Depolar
{
    public class OdemeSekliDepo
    {
        private DbRestoranEntities1 db;

        public OdemeSekliDepo()
        {
            db = new DbRestoranEntities1();
        }

        public IEnumerable<SelectListItem> GetAllOdemeSekli()
        {
            var dbSelectListItems = new List<SelectListItem>();
            dbSelectListItems = (from x in db.tbl_odemesekli
                                 select new SelectListItem()
                                 {
                                     Value = x.odemesekliId.ToString(),
                                     Text = x.odemesekliad,
                                     Selected = true

                                 }).ToList();
            return dbSelectListItems;
        }

    }
}