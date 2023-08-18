using Microsoft.AspNetCore.Mvc;
using MyFurnitureShop.Models.Contact;

namespace MyFurnitureShop.Controllers
{
    public class ContactController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Process the form data (e.g., send an email)
                // You can add your own logic here

                ViewBag.SuccessMessage = "Your message has been sent!";
            }

            return View(model);
        }
    }
}
