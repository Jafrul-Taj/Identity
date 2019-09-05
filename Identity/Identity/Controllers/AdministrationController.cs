using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.ViewModels;
using Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace Identity.Controllers

{
    [Authorize(Roles ="Admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<AplicationUser> userManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager,
                                        UserManager<AplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListUsers()
        {
            var users= userManager.Users;
            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if(ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole()
                {
                    Name = model.RoleName
                };

                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if(result.Succeeded)
                {
                    return RedirectToAction("ListRole","Administration");
                }
                
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }
            }
            return View(model);
        }

        public IActionResult ListRole()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {

            IdentityRole role = await roleManager.FindByIdAsync(model.Id);

            if(role==null)
            {
                ViewBag.ErrorMessage($"Role with id {model.Id} cannot be found");
                return View("Not found");
            }
            else
            {
                role.Name = model.RoleName;

                var result = await roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRole", "Administration");
                }

                foreach(var errror in result.Errors)
                {
                    ModelState.AddModelError("", errror.Description);
                }
            }
           
            foreach(var user in userManager.Users)
            {
                if(await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {

            IdentityRole role = await roleManager.FindByIdAsync(id);

            if(role==null)
            {
                ViewBag.ErrorMessage($"Role with id {id} cannot be found");
                return View("Not found");
            }
            var model = new EditRoleViewModel()
            {
                Id = role.Id,
                RoleName = role.Name

            };

            foreach(var user in userManager.Users)
            {
                if(await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.RoleId = roleId;
            var role = await roleManager.FindByIdAsync(roleId);

            if(role==null)
            {
                ViewBag.Erroe = $"This role cann't be found";
                return View("Not Found");
            }

            var model = new List<UserRoleViewModel>();

            foreach(var user in userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel()
                {
                    UserName = user.UserName,
                    UserId = user.Id
                };

                if(await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSeleted = true;
                }
                else
                {
                    userRoleViewModel.IsSeleted = false;
                }

                model.Add(userRoleViewModel);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> models,string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);

            if(role==null)
            {
                ViewBag.Erroe = $"This role cann't be found";
                return View("Not Found");
            }

            for(int i=0; i<models.Count;i++)
            {
                var user =  await userManager.FindByIdAsync(models[i].UserId);
                IdentityResult result = null;
                if(models[i].IsSeleted && !(await userManager.IsInRoleAsync(user,role.Name)))
                {
                   result=  await userManager.AddToRoleAsync(user, role.Name);
                }
                else if(!models[i].IsSeleted && (await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);

                }
                else
                {
                    continue;
                }
                if(result.Succeeded)
                {
                    if (i < (models.Count - 1))
                        continue;

                    else
                        return RedirectToAction("EditRole", new { Id = roleId });
                }
            }

            return RedirectToAction("EditRole",new { Id=roleId });
        }

       
    }
}