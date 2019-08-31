using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
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
                var user = new IdentityUser() { UserName = model.Email, Email = model.Email };
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
                var user = new IdentityUser() { UserName = model.Email, Email = model.Email };
                var result = await signInManager.PasswordSignInAsync(user, model.Password,
                                                            model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

               
                    ModelState.AddModelError("", "Invalid Username or Password");
                
            }
            return View();
        }
    }
}