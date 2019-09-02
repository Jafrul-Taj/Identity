using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.Models;
using Identity.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<AplicationUser> userManager;
        private readonly SignInManager<AplicationUser> signInManager;

        public AccountController(UserManager<AplicationUser> userManager,SignInManager<AplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Register","Account");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user= await userManager.FindByEmailAsync(email);

            if(user==null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use");
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async  Task<IActionResult> Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new AplicationUser() { UserName = model.Email, Email = model.Email, City= model.City };
                var result= await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await  signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index","Home");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var jaf= await userManager.FindByEmailAsync("jfhasan210@gmail.com");
                
                //var user = new AplicationUser() { UserName = model.Email, Email = model.Email };
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password,
                                                            model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

               
               ModelState.AddModelError("", "Invalid Username or Password");
                
            }
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}