using Microsoft.AspNetCore.Mvc;
using MyFurnitureShop.Core.Models.Cart;
using MyFurnitureShop.Core.Services;
using MyFurnitureShop.Data;

namespace MyFurnitureShop.Controllers
{

    public class CartController : Controller
    {


        private readonly CartService _cartService;
        private readonly ApplicationDbContext _data;

        public CartController(CartService cartService, 
            ApplicationDbContext data)
        {
            _cartService = cartService;
            _data = data;
        }

        public IActionResult Index()
        {
            var cartItems = _cartService.GetCartItems();
            return View(cartItems);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId)
        {
            //  var product = GetProductFromDatabase(productId);
            var product = _data.Furnitures.First(x => x.Id == productId);
            _cartService.AddToCart(product);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int productId, int quantity)
        {
            _cartService.UpdateQuantity(productId, quantity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int productId)
        {
            _cartService.RemoveFromCart(productId);
            return RedirectToAction("Index");
        }
    }
}
