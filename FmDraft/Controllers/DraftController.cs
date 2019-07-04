using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FmDraft.Controllers
{
    public class DraftController : Controller
    {
        public ActionResult New()
        {
            return View();
        }
    }
}