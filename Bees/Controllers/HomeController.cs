using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bees.Models;

namespace Bees.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Default()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bees ASP.NET Application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Details.";

            return View();
        }

        public ActionResult Index()
        {
            TempData["bees"] = null;

            ViewBag.Message = "Bees Page.";

            // Instantiate list of 10 for each type of Bee for rendering on the page
            var bees = new List<Bee>();
            for (int i = 1; i <= 10; i++)
            {
                bees.Add(new Drone(i));
            }
            for (int i = 11; i <= 20; i++)
            {
                bees.Add(new Worker(i));
            }
            for (int i = 21; i <= 30; i++)
            {
                bees.Add(new Queen(i));
            }

            TempData["bees"] = bees;

            return View(bees);
        }

        public ActionResult Update()
        {
            ViewBag.Message = "Bees Page.";

            // Update list of Bees by invoking Damage() method on each Bee
            var bees = (List<Bee>)TempData["bees"];

            Random r = new Random();
            List<int> randoms = new List<int>();

            // Determine random value (of damage) for each Bee in range (0, 80)
            for (int i = 0; i < 30; i++)
            {
                randoms.Add(r.Next(0, 80));
            }

            // Invoke Damage() method using correct random value
            for (int i = 0; i < 30; i++)
            {
                bees[i].Damage(randoms[i]);
            }

            TempData["bees"] = bees;

            return View(bees);
        }
    }
}