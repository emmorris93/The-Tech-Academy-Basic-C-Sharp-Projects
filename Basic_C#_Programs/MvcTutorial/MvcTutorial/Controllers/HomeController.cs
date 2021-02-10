using MvcTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return Content("Hello!");

            //return RedirectToAction("Contact");

            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //ViewBag.RandomNumber = num;

            //if(num > 20000)
            //{
            //    return View("About");
            //}

            //string text = "Hello!";
            //System.IO.File.WriteAllText(@"C:\Users\maudi\sample\log.txt", text);

            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};
            //return View(names);

            //User user = new User();
            //user.Id = 1;
            //user.FirstName = "Jesse";
            //user.LastName = "Johnson";
            //user.Age = 32;
            //return View(user);


            return View();

            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Invalid Page");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}