using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyNews.Models;
using HappyNews.ViewsModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HappyNews.Controllers
{
    public class UserController1 : Controller
    {
        private readonly UserManager<User1> _userManager;

        public UserController1(UserManager<User1> userManager)
        {
            _userManager = userManager;
        }

        // GET
        public IActionResult Index() => View(_userManager.Users.ToList());

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreatUserVM userViewModel)
        {
            if (!ModelState.IsValid) return View(userViewModel);
            var result = await _userManager.CreateAsync(new User1()
            {
                Email = userViewModel.Email,
                UserName = userViewModel.Email,
                FullName = userViewModel.FullName
            });
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(userViewModel);
        }


        public async Task<IActionResult> Edit(string id)
        {

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var vm = new EditVM
            {
                Id = user.Id,
                Email = user.Email,
                FullName = user.FullName
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditVM userViewModel)
        {
            if (!ModelState.IsValid) return View(userViewModel);

            var user = await _userManager.FindByIdAsync(userViewModel.Id);
            if (user == null)
            {
                return NotFound();
            }

            user.FullName = userViewModel.FullName;
            user.Email = userViewModel.Email;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(userViewModel);
        }
    }
}

