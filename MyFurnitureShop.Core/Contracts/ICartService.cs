using MyFurnitureShop.Core.Models.Cart;
using MyFurnitureShop.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurnitureShop.Core.Contracts
{
    public interface ICartService
    {
        void AddToCart(Furniture furniture);

        List<CartItem> GetCartItems();
        void UpdateQuantity(int productId, int quantity);
        void RemoveFromCart(int productId);
    }
}
