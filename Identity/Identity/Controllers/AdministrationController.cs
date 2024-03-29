﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.ViewModels;
using Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Identity.Controllers

{
  //  [Authorize(Policy = "AdminRolePolicy")]
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
        public async Task<ActionResult> ManageUserRoles(string userid)
        {
            ViewBag.userId = userid;

            var user = await userManager.FindByIdAsync(userid);

            if (user == null)
            {
                ViewBag.Erroe = $"This role cann't be found";
                return View("Not Found");
            }

            var model = new List<UserRolesViewModel>();

            foreach (var role in roleManager.Roles)
            {
                var userRolesViewModel = new UserRolesViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name,

                };

                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.isSeleted = true;
                }
                else
                {
                    userRolesViewModel.isSeleted = false;
                }
                model.Add(userRolesViewModel);
            }
            return View(model);
        }

         [HttpPost]
        public async Task<ActionResult> ManageUserRoles(List<UserRolesViewModel> model, string userid)
        {
            var user = await userManager.FindByIdAsync(userid);
            if (user == null)
            {
                ViewBag.Erroe = $"This role cann't be found";
                return View("Not Found");
            }
            var roles = await userManager.GetRolesAsync(user);
            var result = await userManager.RemoveFromRolesAsync(user, roles);
            if(!result.Succeeded)
            {
                ModelState.AddModelError("","Cannot remove user existinf roles");
                return View(model);
            }

            result = await userManager.AddToRolesAsync(user,
                model.Where(x => x.isSeleted).Select(y => y.RoleName));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existinf roles");
                return View(model);
            }
            return RedirectToAction("EditUser", new { Id = userid });
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

        [HttpGet]
        [Authorize(Policy = "EditRolePolicy")]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if(user==null)
            {
                ViewBag.ErrorMessage = $"User with Id= {id} cannot be found";
                return View("NotFound");
            }
            var userClaims = await userManager.GetClaimsAsync(user);
            var userRoles = await userManager.GetRolesAsync(user);

            var model = new EditUserViewModel()
            {
                Id = id,
                UserName = user.UserName,
                City = user.City,
                Claims = userClaims.Select(c => c.Type+" : "+ c.Value).ToList(),
                Roles = userRoles.ToList()
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "AdminRolePolicy")]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id);
            if(user==null)
            {
                ViewBag.ErrorMessage = $"User cannot be found";
                return View("NotFound");
            }

            user.Email = model.UserName;
            user.City = model.City;

            var result = await userManager.UpdateAsync(user);

            if(result.Succeeded)
            {
                return RedirectToAction("ListUsers", "Administration");
            }
            foreach(var error in result.Errors)
            {
                ModelState.AddModelError("",error.Description);
            }
                
            return View(model);
        }
        [HttpPost]
        
        public async Task<ActionResult> DeleteUser( string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await userManager.DeleteAsync(user);

                if(result.Succeeded)
                {
                    return RedirectToAction("ListUsers", "Administration");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("ListUsers", "Administration");
            }
        }

        [HttpPost]
        [Authorize(Policy = "DeleteRolePolicy")]
        public async Task<ActionResult> DeleteRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await roleManager.DeleteAsync(role);
                if(result.Succeeded)
                {
                    return RedirectToAction("ListRole", "Administration");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View("ListRole", "Administration");
            }
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

        [HttpGet]
        public async Task<ActionResult> ManageUserClaims(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.Erroe = $"This role cann't be found";
                return View("Not Found");
            }

            var exitingUserClaims = await userManager.GetClaimsAsync(user);
            var model = new UserClaimsViewModel()
            {
                UserId = user.Id
            };

            foreach(Claim claim in ClaimsStore.AllClaims)
            {
                UserClaim userClaim = new UserClaim()
                {
                    ClaimType = claim.Type
                };

                if(exitingUserClaims.Any(c => c.Type==claim.Type && c.Value=="true"))
                {
                    userClaim.isSeleted = true;
                }

                model.claim.Add(userClaim);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> ManageUserClaims(UserClaimsViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.UserId);

            if(user==null)
            {
                ViewBag.Erroe = $"This role cann't be found";
                return View("Not Found");
            }

            var claims = await userManager.GetClaimsAsync(user);
            var result = await userManager.RemoveClaimsAsync(user, claims);

            if(!result.Succeeded)
            {
                ModelState.AddModelError("","Cannot remove the existing claim");
                return View(model);
            }

            result = await userManager.AddClaimsAsync(user,
                model.claim.Select(c => new Claim(c.ClaimType, c.isSeleted ? "true" : "false" )));

            if(!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected claims to user");
                return View(model);

            }

            return RedirectToAction("EditUser", new {Id=model.UserId });
        }
    }
}