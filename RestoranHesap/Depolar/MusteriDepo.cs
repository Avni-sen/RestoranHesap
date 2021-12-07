using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestoranHesap.Models;


namespace RestoranHesap.Depolar
{
    public class MusteriDepo
    {
        private DbRestoranEntities1 db;

        public MusteriDepo()
        {
            db = new DbRestoranEntities1();
        }

        public IEnumerable<SelectListItem> GetAllMusteri()
        {
            var dbSelectListItems = new List<SelectListItem>();
            dbSelectListItems = (from x in db.tbl_musteri
                                 select new SelectListItem()
                                 {
                                     Value = x.musteriId.ToString(),
                                    Text  = x.musteriad,
                                     Selected = true

                                 }).ToList();
            return dbSelectListItems;
        }

    }
}