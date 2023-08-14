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
    internal class TypeConfiguration : IEntityTypeConfiguration<FurnitureType>
    {
        public void Configure(EntityTypeBuilder<FurnitureType> builder)
        {
            builder.HasData(AllFurnituresTypes());
        }

        private List<FurnitureType> AllFurnituresTypes()
        {
            var types = new List<FurnitureType>();

            var type = new FurnitureType() 
            {
              Id = 1,
              Name = "Table"
            };

            types.Add(type);

            type = new FurnitureType()
            {
                Id = 2,
                Name = "Chair"
            };

            types.Add(type);

             type = new FurnitureType()
            {
                Id = 3,
                Name = "Sofa"
            };

            types.Add(type);

             type = new FurnitureType()
            {
                Id = 4,
                Name = "Bed"
            };

            types.Add(type);

             type = new FurnitureType()
            {
                Id = 5,
                Name = "Wardrobe"
             };

            types.Add(type);

             type = new FurnitureType()
            {
                Id = 6,
                Name = "Desk"
            };

            types.Add(type);

             type = new FurnitureType()
            {
                Id = 7,
                Name = "Cupboard"
             };

            types.Add(type);

            return types;
        }
    }
}
