using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurnitureShop.Core.Models.Users
{
    public class UserModel
    {
        public string UserId { get; init; } = null!;
        public string Email { get; init; } = null!;

        public string FullName { get; init; } = null!;

    }
}
