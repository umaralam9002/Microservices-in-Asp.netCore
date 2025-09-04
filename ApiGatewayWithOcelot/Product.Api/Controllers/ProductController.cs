using Microsoft.AspNetCore.Mvc;
using Product.Api.Repositories;

namespace Product.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _repo = new();

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_repo.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _repo.GetById(id);
            if (product == null)
                return NotFound(new { Message = $"Product with Id {id} not found" });

            return Ok(product);
        }
    }
}
