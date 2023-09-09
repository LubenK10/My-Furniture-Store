using MyFurnitureShop.Core.Models.Cart;
using MyFurnitureShop.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurnitureShop.Core.Services
{
    public class CartService
    {
        private readonly List<CartItem> _cartItems = new List<CartItem>()
        {
           new CartItem { ProductId = 1, ProductName = "Vietham Table", Price = 134, Quantity = 1, Image = "/images/1.jpg"},
           new CartItem { ProductId = 1, ProductName = "Vietham Table", Price = 134, Quantity = 1, Image = "/images/1.jpg" } 

        };


        public void AddToCart(Furniture furniture)
        {
            var existingItem = _cartItems.FirstOrDefault(item => item.ProductId == furniture.Id);

            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                _cartItems.Add(new CartItem
                {
                    ProductId = furniture.Id,
                    ProductName = furniture.Name,
                    Price = furniture.Price,
                    Quantity = 1
                });
            }
        }

        public List<CartItem> GetCartItems()
        {
            return _cartItems;
        }

        public void UpdateQuantity(int productId, int quantity)
        {
            var cartItem = _cartItems.FirstOrDefault(item => item.ProductId == productId);

            if (cartItem != null)
            {
                cartItem.Quantity = quantity;
            }
        }

        public void RemoveFromCart(int productId)
        {
            var cartItem = _cartItems.FirstOrDefault(item => item.ProductId == productId);

            if (cartItem != null)
            {
                _cartItems.Remove(cartItem);
            }
        }
    }
}
