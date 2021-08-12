using BaseDeDonnéesLivres.Migrations;
using BaseDeDonnéesLivres.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace BaseDeDonnéesLivres.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly UserManager<Microsoft.AspNetCore.Identity.IdentityUser> _userManager;
//        private readonly SignInManager<Microsoft.AspNetCore.Identity.IdentityUser> _signInManager;
//        private readonly ILogger<HomeController> _logger;

//        public HomeController(ILogger<HomeController> logger)
//        {
//            _logger = logger;
//        }

//        public HomeController(UserManager<Microsoft.AspNetCore.Identity.IdentityUser> userManager,
//                                            SignInManager<Microsoft.AspNetCore.Identity.IdentityUser> signInManager)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//        }
//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult RegisterView()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> RegisterView(RegisterModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                var user = new Microsoft.AspNetCore.Identity.IdentityUser
//                {
//                    UserName = model.Email,
//                    Email = model.Email,
//                };

//                var result = await _userManager.CreateAsync(user, model.Password);

//                if (result.Succeeded)
//                {
//                    await _signInManager.SignInAsync(user, isPersistent: false);

//                    return RedirectToAction("index", "Home");
//                }

//                foreach(var error in result.Errors)
//                {
//                    ModelState.AddModelError("", error.Description);
//                }

//                ModelState.AddModelError(string.Empty, "Tentative de connexion invalide");
//            }
//            return View(model);
//        }

//        [HttpPost]
//        [AllowAnonymous]
//        public async Task<IActionResult> Login()
//        {

//            return View();
//        }

//        [HttpPost]
//        [AllowAnonymous]
//        public async Task<IActionResult> Login(LoginModel user)
//        {
//            if (ModelState.IsValid)
//            {
//                var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);

//                if (result.Succeeded)
//                    return RedirectToAction("Index", "Home");

//                ModelState.AddModelError(string.Empty, "Tentative de connexion invalide");
//            }
//            return View(user);
//        }

//        public async Task<IActionResult> LogOut()
//        {
//            await _signInManager.SignOutAsync();
//            return RedirectToAction("Login");
//        }
//    }
//}
