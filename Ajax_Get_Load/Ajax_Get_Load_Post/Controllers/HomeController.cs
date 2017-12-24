using Ajax_Get_Load.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax_Get_Load.Controllers
{
    public class HomeController : Controller
    {
        static List<string> kisi = new List<string> {"Ergün","TOPRAK","1993","Izmir","Konak", };
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult VeriGetir()
        {
            return PartialView("_VeriGetir",kisi);
        }
        [HttpPost]
        public PartialViewResult VeriGonder(string yas)
        {
            kisi.Add(yas);
            return PartialView("_VeriGetir", kisi);
        }

        public ActionResult AjaxApplicationPage()
        {
            return View();
        }

        public ActionResult AjaxJsonVerilerIndex()
        {
            return View();
        }

        public JsonResult AjaxJsonVerilerDonme()
        {
            Kisi kisi = new Kisi();
            kisi.Ad = "Ergün";
            kisi.Soyad = "TOPRAK";
            kisi.Aile = new List<Aile>() { new Aile {AnneAdSoyad="S",BabaAdSoyad="B" }, new Aile {AnneAdSoyad = "S", BabaAdSoyad = "B" } };
            return Json(kisi,JsonRequestBehavior.AllowGet);
        }

    }
}