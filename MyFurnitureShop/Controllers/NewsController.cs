using Microsoft.AspNetCore.Mvc;
using MyFurnitureShop.Models.News;

namespace MyFurnitureShop.Controllers
{
    public class NewsController : Controller
    {
        private static List<DetailsNewsArticle> _newsArticles = new List<DetailsNewsArticle>
        {
            new DetailsNewsArticle
            {
                Id = 1,
                Title = "Великден наближава",
                Description = "Във връзка с наближаващите празници, екипът на Джи енд Джи ЕООД Ви информира, че офисът ни на ул. \"Г.С.Раковски\" 181 ни няма да работи в дните от 26.04.2023 до 29.04.2023.\r\n\r\n \r\n\r\nНа 30.04.2023 година ще Ви очакваме с нормално работно време.\r\n\r\n \r\n\r\nЕкипът на Джи енд Джи Ви пожелава весели празници! Бъдете здрави!",
                ImageUrl = "/images/714ve.jpg",
                Author = "Ivan Marinov",
                PublishDate = "30.01.2023"
            },
            new DetailsNewsArticle
            {
                Id = 2,
                Title = "Изложбената ни зала на бул. Тодор Александров 17 е затворена",
                Description = "Здравейте приятели,\r\n\r\nза съжаление и поради независещи от нас причини нашата изложбена зала на бул. \"Тодор Александров\" 17 вече е затворена. Може да ни посетите в другия ни магазин на ул. \"Г.С.Раковски\" 181.\r\n\r\nОчакваме Ви!\r\n\r\nС поздрав,\r\n\r\nЕкипа на фирма G&G  ЕООД ",
                ImageUrl = "/images/62135-og.jpg",
                Author = "Georgi Marinov",
                PublishDate = "22.05.2023",
            },
            new DetailsNewsArticle
            {
                Id = 3,
                Title = "Лятно работно време на изложбената ни зала",
                Description = "Уважаеми приятели,\r\n\r\nпрез месец Август 2023 изложбената ни зала ще работи със следното ваканционно работно време: \r\n\r\n    от понеделник до петък – работни дни, 10.00 – 19.00 ч.\r\n    събота – почивен ден\r\n\r\n Екипът на фирма „ДЖИ ЕНД ДЖИ”  ЕООД  Ви пожелава слънчево и топло лято!",
                ImageUrl = "/images/962mm.jpg",
                Author = "Ivan Marinov",
                PublishDate = "12.12.2023",
            }
        };

        public IActionResult Index()
        {
            return View(_newsArticles);
        }

        public IActionResult Details(int id)
        {
            var article = _newsArticles.Find(a => a.Id == id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }
    }
}
