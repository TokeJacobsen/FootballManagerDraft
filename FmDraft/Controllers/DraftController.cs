using FmDraft.Models;
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
        Drafter drafter = new Drafter(GameSettings.Instance.GetPlayerPool());
        public ActionResult New()
        {
            DraftViewModel model = new DraftViewModel();
            return View(model);
        }
        
        public JsonResult PickP1(string position)
        {
            return Json(drafter.GetFive(position), JsonRequestBehavior.AllowGet);
        }

        public string PickP2(string position)
        {
            GameSettings.Instance.Round = GameSettings.Instance.Round+1;
            return drafter.GetFive(position)[0].Name;

        }
    }
}