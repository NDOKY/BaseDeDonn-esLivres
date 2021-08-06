using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace BaseDeDonnéesLivres.Controllers
{
    public class HelloWorldController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

        //
        //GET: /HelloWorld/Welcome/

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return $"This is the welcome action method {name}";
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID:{ID}");

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
