using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFurnitureShop.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurnitureShop.Infrastructure.Data.Configure
{
    public class FurnitureConfiguration : IEntityTypeConfiguration<Furniture>
    {
        public void Configure(EntityTypeBuilder<Furniture> builder)
        {
            builder.HasData(AllFurnitures());
        }
      
        private List<Furniture> AllFurnitures()
        {
            var furnitures = new List<Furniture>();
      
            var furniture = new Furniture()
            {
                Id = 1,
                Colour = "white",
                Name = "Brazilian sofa",
                Price = 320,
                TypeId = 3,
                IsActive = true
            };
      
            furnitures.Add(furniture);

             furniture = new Furniture()
            {
                Id = 2,
                Colour = "brown",
                Name = "Wooden chair",
                Price = 70,
                TypeId = 2,
                IsActive = true
            };

            furnitures.Add(furniture);

             furniture = new Furniture()
            {
                Id = 3,
                Colour = "white",
                Name = "Luxury table",
                Price = 120,
                TypeId = 1,
                IsActive = true
            };

            furnitures.Add(furniture);

            return furnitures;
        }
    }

    
}
