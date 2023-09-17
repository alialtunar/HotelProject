using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class SettingController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = user.Name;
            userEditViewModel.Surname = user.Surname;
            userEditViewModel.Email = user.Email;
            userEditViewModel.Username = user.UserName;
             
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel model)
        {
            if (model.Password == model.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = model.Name;
                user.Email = model.Email;
                user.Surname = model.Surname;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
           
                return View();
            
        }
    }
}
