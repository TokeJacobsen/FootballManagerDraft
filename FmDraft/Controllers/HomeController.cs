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
            using (var db = new FMDraftEntities1())
            {

                    var players = from p in db.Players
                                  where p.Clubs.Divisions.DivisionName.Equals("Superliga")
                                  select p;
                    foreach (var player in players)
                    {
                        System.Diagnostics.Debug.WriteLine("'"+player.Value+"'");
                    System.Diagnostics.Debug.WriteLine(Models.Generator.DataCleaner.ConvertValueToNumber(player.Value));


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