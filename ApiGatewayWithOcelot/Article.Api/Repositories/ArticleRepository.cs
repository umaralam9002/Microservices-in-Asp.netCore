using Article.Api.Models;

namespace Article.Api.Repositories
{
    public class ArticleRepository
    {
        private readonly List<ArticleItem> _articles = new()
        {
            new ArticleItem { Id = 1, Title = "ASP.NET Core Basics", Author = "Umar" },
            new ArticleItem { Id = 2, Title = "Microservices with Ocelot", Author = "Ali" },
            new ArticleItem { Id = 3, Title = "Docker for Beginners", Author = "Ahmed" }
        };

        public IEnumerable<ArticleItem> GetAll() => _articles;

        public ArticleItem? GetById(int id) => _articles.FirstOrDefault(a => a.Id == id);
    }
}
