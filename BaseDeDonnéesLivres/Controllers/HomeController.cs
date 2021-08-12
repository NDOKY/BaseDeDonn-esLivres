using BaseDeDonnéesLivres.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.IO;
using BaseDeDonnéesLivres.Data;

namespace BaseDeDonnéesLivres.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly BaseDeDonnéesLivresContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public HomeController(BaseDeDonnéesLivresContext context, IWebHostEnvironment hostEnvironment)
        //{
        //    dbContext = context;
        //    webHostEnvironment = hostEnvironment;
        //}

        public async Task<IActionResult> Index()
        {
            //var user = await dbContext.User.ToListAsync();
            return View(/*user*/);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //public IActionResult New()
        //{
        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> New(Register model)
        {
            if (ModelState.IsValid)
            {
                //string
                
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
