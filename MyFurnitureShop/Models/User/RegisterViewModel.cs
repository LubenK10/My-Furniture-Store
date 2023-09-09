using System.ComponentModel.DataAnnotations;

namespace MyFurnitureShop.Models.User
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(30)]
        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(40)]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [StringLength(30)]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
