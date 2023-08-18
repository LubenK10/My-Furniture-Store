using System.ComponentModel.DataAnnotations;

namespace MyFurnitureShop.Models.Contact
{
    public class ContactViewModel
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        public string Subject { get; set; } = null!;

        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; } = null!;
    }
}
