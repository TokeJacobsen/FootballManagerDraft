using FmDraft.Models;
using FmDraft.Models.Generator;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FmDraft.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
       
            List<string> divisions = new List<string>();
            divisions.Add("Superliga");
            PlayerPoolFactory factory = new PlayerPoolFactory(divisions);
            Drafter drafter = new Drafter(factory.GetPlayerPool());

            for (int i = 0; i < 30; i++)
            {
                drafter.GetFive("GK");
                System.Diagnostics.Debug.WriteLine("!!!!");
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