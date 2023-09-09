using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFurnitureShop.Core.Constants;
using MyFurnitureShop.Infrastructure.Data.Entities;
using MyFurnitureShop.Models.User;

namespace MyFurnitureShop.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public readonly SignInManager<User> signInManager;

        public readonly UserManager<User> userManager;

        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(SignInManager<User> signInManager,
            UserManager<User> userManager,
           RoleManager<IdentityRole> roleManager)
        {

            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;

        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            var user = new RegisterViewModel();

            return View(user);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                Email = model.Email,
                UserName = model.UserName

            };

            if (!await roleManager.RoleExistsAsync("Manager") &&
                !await roleManager.RoleExistsAsync("User"))
            {
                await roleManager.CreateAsync(new IdentityRole() { Name = "Manager" });
                await roleManager.CreateAsync(new IdentityRole() { Name = "User" });
            }

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                  

                TempData[MessageConstants.SuccessMessage] = "You created an account!";

                return RedirectToAction("Login", "User");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var user = new LoginViewModel();

            return View(user);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model) 
        {
            if (!ModelState.IsValid)
            {
                TempData[MessageConstants.ErrorMessage] = "Unsuccessful login!";

                return View(model);

            }

            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    TempData[MessageConstants.SuccessMessage] = "You created an account!";

                    
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(model);
        }

        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
