using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial.Areas.Help.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Index(string id)
        {
            if(id == "Page2")
            {
                return View("Page2");
            }
            else if (id == "Page3")
            {
                return View("Page3");
            }
            return View("Page1");
        }
    }
}
