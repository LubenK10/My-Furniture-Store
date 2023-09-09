using Microsoft.AspNetCore.Mvc;

namespace MyFurnitureShop.Areas.Admin.Controllers
{
    public class FurnitureController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
