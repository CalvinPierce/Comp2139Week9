using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial.Areas.Help.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var contacts = new Dictionary<string, string>
            {
                { "Phone", "416-567-7890" },
                { "Email", "JohnDoe@gmail.com" },
                { "Facebook", "facebook.com/JohnDoe" }
            };
            return View(contacts);
        }
    }
}
