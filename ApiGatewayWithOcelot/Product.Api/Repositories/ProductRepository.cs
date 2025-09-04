using Product.Api.Models;

namespace Product.Api.Repositories
{
    public class ProductRepository
    {
        private readonly List<ProductItem> _products = new()
        {
            new ProductItem { Id = 1, Name = "Laptop", Price = 1200 },
            new ProductItem { Id = 2, Name = "Phone", Price = 800 },
            new ProductItem { Id = 3, Name = "Headphones", Price = 150 }
        };

        public IEnumerable<ProductItem> GetAll() => _products;

        public ProductItem? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
    }
}
