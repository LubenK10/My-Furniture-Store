using MyFurnitureShop.Core.Models.Furniture;

namespace MyFurnitureShop.Models.Furniture
{
    public class AllFurnitures
    {
        public const int FurnituresPerPage = 6;

        public string? FurnitureType { get; set; }

        public string? Colour { get; set; }

        public string? Name { get; set; }

        public string? SearchTerm { get; set; }

        public int CurrentPage { get; set; }

        public int TotalFurnitureCount { get; set; }

        public IEnumerable<string> FurnitureTypes { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<FurnitureModel> Furnitures { get; set; } = Enumerable.Empty<FurnitureModel>();
    }
}
