using FmDraft.Models;
using FmDraft.Models.Init;
using FmDraft.Models.ViewModels;
using System.Collections.Generic;
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
            settings.InitializeGame(inputData);
            return RedirectToAction("Picking", "Picking"); 
        }

    }
}