using Microsoft.AspNetCore.Mvc;
using Article.Api.Repositories;

namespace Article.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleRepository _repo = new();

        [HttpGet]
        public IActionResult GetArticles()
        {
            return Ok(_repo.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetArticleById(int id)
        {
            var article = _repo.GetById(id);
            if (article == null)
                return NotFound(new { Message = $"Article with Id {id} not found" });

            return Ok(article);
        }
    }
}
