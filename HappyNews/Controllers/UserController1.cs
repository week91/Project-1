using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using HappyNews.ViewsModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;



namespace HappyNews.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController1 : Controller
    {
        private readonly UserManager<User> _userManager;

        public UserController1(UserManager<User> userManager)
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
            var result = await _userManager.CreateAsync(new User()
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
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ChangePassword(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            ChangePassViewModel model = new ChangePassViewModel {Id = user.Id, Email = user.Email};
            return View(model);
        }
        [Authorize(Roles = "Admin")]
       [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePassViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    var _passwordValidator =
                        HttpContext.RequestServices.GetService(typeof(IPasswordValidator<User>)) as
                            IPasswordValidator<User>;
                    var _passwordHasher =
                        HttpContext.RequestServices.GetService(typeof(IPasswordHasher<User>)) as IPasswordHasher<User>;

                    IdentityResult result =
                        await _passwordValidator.ValidateAsync(_userManager, user, model.NewPassword);
                    if (result.Succeeded)
                    {
                        user.PasswordHash = _passwordHasher.HashPassword(user, model.NewPassword);
                        await _userManager.UpdateAsync(user);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Пользователь не найден");
                }
            }

            return View(model);
        }
    }
}

