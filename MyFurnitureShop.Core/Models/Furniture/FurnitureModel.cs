using MyFurnitureShop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurnitureShop.Core.Models.Furniture
{
    public class FurnitureModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;


        public int TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public FurnitureType Type { get; set; } = null!;

        [Required]

        public string Colour { get; set; } = null!;

        public double Price { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public IEnumerable<FurnitureType> FurnitureTypes { get; set; } = new List<FurnitureType>();

    }


}
