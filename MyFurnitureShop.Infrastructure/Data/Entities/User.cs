using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MyFurnitureShop.Infrastructure.Data.Entities
{
    using static Data.Constants.GlobalConstants;
    public class User : IdentityUser
    {
        [StringLength(UserFirstNameMaxLength, MinimumLength = UserFirstNameMinLength)]
        public string? FirstName { get; set; }

        [StringLength(UserLastNameMaxLength, MinimumLength = UserLastNameMinLength)]
        public string? LastName { get; set; }

        public bool IsActive { get; set; }
    }
}
