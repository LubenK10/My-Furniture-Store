using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurnitureShop.Infrastructure.Data.Entities
{
    using static Data.Constants.GlobalConstants;
    public class Furniture
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(FurnitureNameMaxLength, MinimumLength = FurnitureNameMinLength)]
        public string Name { get; set; } = null!;


        public int TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public FurnitureType Type { get; set; } = null!;

        [Required]

        public string Colour { get; set; } = null!;

        public double Price { get; set; }

        public bool IsActive { get; set; }

    }
}
