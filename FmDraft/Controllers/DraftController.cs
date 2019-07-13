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
        Drafter drafter = GameSettings.Instance.GetDrafter();
        public ActionResult New()
        {
            DraftViewModel model = new DraftViewModel();
            return View(model);
        }
        
        public JsonResult GetFive(string position)
        {
            return Json(drafter.GetFive(position), JsonRequestBehavior.AllowGet);
        }

        public HttpStatusCodeResult Select(string playerId, int activePlayerId)
        {
            User user = null;
            if (activePlayerId == 1)
            {

                user = GameSettings.Instance.Player1;
            }
            else
            {
                user = GameSettings.Instance.Player2;
            }
            user.PickPlayer(drafter.FindByIdAndPick(playerId));
            return new HttpStatusCodeResult(200);
        }
    }
}