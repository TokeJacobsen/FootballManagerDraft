using FmDraft.Models;
using FmDraft.Models.Generator;
using FmDraft.Models.Init;
using FmDraft.Models.ViewModels;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;

namespace FmDraft.Controllers
{
    public class HomeController : Controller
    {
        GameSettings settings = new GameSettings();

        public ActionResult Index()
        {

            InitViewModel model = new InitViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateGame(InitViewModel inputData)
        {

            if (settings.InitializeGame(inputData))
            {
                return RedirectToAction("New", "Draft");
            }

            return RedirectToAction("Index");
        }

    }
}