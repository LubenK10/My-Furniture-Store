using Microsoft.AspNetCore.Mvc;
using MyFurnitureShop.Core.Services;

namespace MyFurnitureShop.Areas.Admin.Controllers
{
    public class UsersController : BaseController
    {
        private readonly UserService userService;

        public UsersController(UserService _userService)
        {
            userService = _userService;
        }


        [HttpGet]
        public async Task<IActionResult> AllUsers()
        {
            var model = await userService.All();

            return View(model);
        }


    }
}
