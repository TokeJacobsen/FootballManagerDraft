﻿using FmDraft.Models;
using FmDraft.Models.Init;
using FmDraft.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FmDraft.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Formations formations = new Formations();
            Dictionary<string, Formation> formationDictionary = formations.GetFormations();
            ViewData["Formations"] = formationDictionary;

            User player1 = new User();
            User player2 = new User();
            ViewData["player1"] = player1;
            ViewData["player2"] = player2;



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