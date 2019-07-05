using FmDraft.Models;
using FmDraft.Models.Generator;
using FmDraft.Models.Init;
using FmDraft.Models.ViewModels;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace FmDraft.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {

            InitViewModel model = new InitViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateGame(InitViewModel inputData)
        {
            

            if (GameSettings.Instance.InitializeGame(inputData))
            {

                return RedirectToAction("New", "Draft");
            }

            return RedirectToAction("Index");
        }

    }
}