using AjaxHelperMetot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace AjaxHelperMetot.Controllers
{
    public class HomeController : Controller
    {
        static List<string> list;
        public ActionResult Index()
        {
            list= new List<string>() { "Ergün", "Toprak", "1993", "İzmir", "Buca", "35160", "Öğrenci" };
            Session["liste"] = list;
            return View();
        }
        public PartialViewResult LoadData()
        {
            Thread.Sleep(3000);
            return PartialView("LoadData", list);
        }
        public MvcHtmlString RemoveData(int id)
        {
            list.RemoveAt(id);
            return MvcHtmlString.Empty;
        }

        public ActionResult SaveItem()
        {
            return View();
        }
        [HttpPost]
        public PartialViewResult SaveItem(Kisi kisi)
        {
            List<Kisi> kisiList = null;
            if (Session["kisiler"] != null)
            {
                kisiList = Session["kisiler"] as List<Kisi>;
            }
            else
            {
                kisiList = new List<Kisi>();
            }
            kisi.Id = Guid.NewGuid();
            kisiList.Add(kisi);
            Session["kisiler"] = kisiList;
            return PartialView("NewItem",kisi);
        }


    }

}
    





