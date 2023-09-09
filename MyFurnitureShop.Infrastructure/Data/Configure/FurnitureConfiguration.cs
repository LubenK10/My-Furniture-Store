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
                IsActive = true,
                Description = "Вътрешната конструнция е изработена от масив и метал, уплатнени с полиуретанова пяна. Моделът е с изчистени пропорции и модерно излъчване. Предлага се в много размера и на различни модули. Може да бъде поръчан в различни дамаски или кожа.",
                ImageUrl = "/images/15BOSTON-divano-_44.jpg"
            };
      
            furnitures.Add(furniture);

             furniture = new Furniture()
            {
                Id = 2,
                Colour = "brown",
                Name = "Wooden chair",
                Price = 70,
                TypeId = 2,
                IsActive = true,
                Description = "Трапезарен стол Giuseppina by Dondoli e Pocci. \r\n\r\nПроизведен е от висококачествена пластмаса по най-нови технологии. Предлага се в различни цветове\r\n\r\nРазмери: 53 х 46 х 46 h (седалка) х 84 h (облегалка)",
                ImageUrl = "/images/89cam-el-eon-stool-1.jpg"
             };

            furnitures.Add(furniture);

            furniture = new Furniture()
            {
                Id = 3,
                Colour = "white",
                Name = "Luxury table",
                Price = 120,
                TypeId = 1,
                IsActive = true,
                Description = "В този модел традицията и новаторството се преплитат хармонично, като един нов прочит на класическия модел маса с четири крака и вградена табла. Масата е дървена, а възглавниците може да са от плат или кожа\r\n\r\nРазмерите може да са 160 х 200 см. или 180 х 200 см.",
                ImageUrl = "/images/1.jpg"

            };

            furnitures.Add(furniture);

            return furnitures;
        }
    }

    
}
