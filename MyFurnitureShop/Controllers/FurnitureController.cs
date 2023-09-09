using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyFurnitureShop.Core.Services;
using MyFurnitureShop.Data;
using MyFurnitureShop.Models.Furniture;

namespace MyFurnitureShop.Controllers
{
    public class FurnitureController : Controller
    {
        private readonly FurnitureService furnitureService;


        public FurnitureController(
            FurnitureService _furnitureService)
        {
            furnitureService = _furnitureService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllFurnitures query)
        {
            var result = await furnitureService.All(
                query.FurnitureType,
                query.Colour,
                query.Name,
                query.SearchTerm,
                query.CurrentPage,
                AllFurnitures.FurnituresPerPage);

            query.TotalFurnitureCount = result.FurnituresCount;
            query.FurnitureTypes = await furnitureService.AllFurnitureTypesNames();
            query.Furnitures = result.Furnitures;

            return View(query);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {

            var model = await furnitureService.PetDetailsById(id);


            return View(model);
        }

    }
}
