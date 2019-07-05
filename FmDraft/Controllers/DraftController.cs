using FmDraft.Models.Init;
using FmDraft.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FmDraft.Controllers
{
    public class DraftController : Controller
    {
        public ActionResult New()
        {
            DraftViewModel model = new DraftViewModel();
            return View(model);
        }
        
        public ActionResult PickP1()
        {
            Debug.WriteLine("JAAAAAA");
            return View();
        }

        public void PickP2()
        {
            Debug.WriteLine("WUUU!");

        }
    }
}