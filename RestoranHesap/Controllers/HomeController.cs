using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestoranHesap.Depolar;
using RestoranHesap.Models;
namespace RestoranHesap.Controllers
{
    public class HomeController : Controller
    {
        private DbRestoranEntities1 db;
        public HomeController()
        {
            db = new DbRestoranEntities1();
        }
        // GET: Home
        public ActionResult Index()
        {
            MusteriDepo dbMusteriDepo = new MusteriDepo();
            ItemDepo dbıtemDepo = new ItemDepo();
            OdemeSekliDepo dbodemeSekliDepo = new OdemeSekliDepo();

            var dbMultipleModels = new Tuple<IEnumerable<SelectListItem>,IEnumerable<SelectListItem>,IEnumerable<SelectListItem>>
                (dbMusteriDepo.GetAllMusteri(), dbıtemDepo.GetAllItem(), dbodemeSekliDepo.GetAllOdemeSekli());
            return View(dbMultipleModels);
        }
        [HttpGet]
        public JsonResult GetItemBirimFiyat(int ItemId)
        {
            decimal BirimFiyat = (decimal)db.tbl_item.Single(model => model.ItemId == ItemId).Itemucret;
            return Json(BirimFiyat, JsonRequestBehavior.AllowGet);
        }
    }
}