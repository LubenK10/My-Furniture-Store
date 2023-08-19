using System.ComponentModel.DataAnnotations;

namespace MyFurnitureShop.Models.User
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string UserName { get; set; } = null!;


        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6)]
        public string Password { get; set; } = null!;
    }
}
