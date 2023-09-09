using Microsoft.EntityFrameworkCore;
using MyFurnitureShop.Core.Models.Furniture;
using MyFurnitureShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurnitureShop.Core.Services
{
    public class FurnitureService
    {

        private readonly ApplicationDbContext data;

        public FurnitureService(ApplicationDbContext _data)
        {
            data = _data;
        }

        public async Task<FurnitureQueryModel> All(string? furnitureType = null,
            string? colour = null,
            string? name = null,
            string? searchTerm = null,
            int currentPage = 1,
            int petsPerPage = 1)
        {
            var result = new FurnitureQueryModel();
            var furnitures = data.Furnitures
                .Where(h => h.IsActive);

            if (string.IsNullOrEmpty(furnitureType) == false)
            {
                furnitures = furnitures
                    .Where(h => h.Type.Name == furnitureType);
            }

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                furnitures = furnitures
                    .Where(h => EF.Functions.Like(h.Name.ToLower(), searchTerm) ||
                        EF.Functions.Like(h.Type.Name.ToLower(), searchTerm));
            }



           

            result.Furnitures = await furnitures
               .Skip((currentPage) * petsPerPage)
                .Take(petsPerPage)
                .Select(h => new FurnitureModel()
                {
                    Id = h.Id,
                    ImageUrl = h.ImageUrl,
                    Name = h.Name,
                    Description = h.Description,
                    Price = h.Price,
                    Type = h.Type,
                    Colour = h.Colour,
                })
                .ToListAsync();

            result.FurnituresCount = await furnitures.CountAsync();

            return result;
        }

        public async Task<IEnumerable<string>> AllFurnitureTypesNames()
        {
            return await data.Types
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<FurnitureDetailsModel> PetDetailsById(int id)
        {
            return await data.Furnitures
              .Where(p => p.IsActive)
              .Where(h => h.Id == id)
              .Select(h => new FurnitureDetailsModel()
              {
                  Description = h.Description,
                  Id = id,
                  ImageUrl = h.ImageUrl,
                  Price = h.Price,
                  Name = h.Name,
                  Type = h.Type,
                  Colour = h.Colour
              })
              .FirstAsync();
        }
    }
}
