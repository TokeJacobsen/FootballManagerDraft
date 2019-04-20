using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FmDraft.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new FMDraftEntities())
            {
                var query = from b in db.Players select b;

                foreach(var item in query)
                {
                    System.Diagnostics.Debug.WriteLine(item.Name);
                }

            }
               
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}