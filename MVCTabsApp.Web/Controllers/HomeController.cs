using MVCTabsApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTabsApp.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                Personal = new Personal()
                {
                    FirstName = "Bhavik",
                    LastName = "Patel",
                    UserName = "BPatel"
                },
                Login = new Login()
                {
                    EmailAddress = "bhavik.patel@radixweb.com",
                    Password = "Bhavik09",
                    SecurityQuestion = "Which is your first school?"
                },
                Contact = new Contact()
                {
                    ContactEmail = "bhavik@gmail.com",
                    ContactNumber = "8758485484",
                    ContactPerson = "Patel B"
                }
            };
            return View(homeViewModel);
        }
        [HttpPost]
        public ActionResult Save(HomeViewModel model, string action)
        {

            return View("Index", model);
        }
    }
}