namespace MyFurnitureShop.Models.News
{
    public class DetailsNewsArticle
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string PublishDate { get; set; } = null!;
        public string Author { get; set; } = null!;
    }
}
