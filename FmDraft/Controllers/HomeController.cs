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

            Debug.WriteLine(inputData.Division + "1" );

            Debug.WriteLine(inputData.FormationP1 + "2");

            Debug.WriteLine(inputData.FormationP2 + "3");

            Debug.WriteLine(inputData.PlayerOne + "4");


            Debug.WriteLine(inputData.PlayerTwo + "5");

            settings.InitializeGame(inputData);
            return RedirectToAction("Picking", "Picking"); 
        }

    }
}