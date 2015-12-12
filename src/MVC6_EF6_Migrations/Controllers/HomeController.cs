using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Entities;

namespace MVC6_EF6_Migrations.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var context = new StoreContext();
            context.Books.Add(new EBook
            {
                Title = "Red"
            });
            context.SaveChanges();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
