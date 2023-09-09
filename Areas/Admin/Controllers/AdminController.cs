using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace MyFurnitureShop.Areas.Admin.Controllers
{

    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
