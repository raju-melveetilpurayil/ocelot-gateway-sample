using Microsoft.AspNetCore.Mvc;

namespace ProductsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Wireless Bluetooth Headphones", Category = "Electronics" },
            new Product { Id = 2, Name = "Organic Green Tea", Category = "Groceries" },
            new Product { Id = 3, Name = "Yoga Mat - Non Slip", Category = "Fitness" },
            new Product { Id = 4, Name = "Ergonomic Office Chair", Category = "Furniture" },
            new Product { Id = 5, Name = "LED Desk Lamp", Category = "Home & Office" }
        };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> Get()
        {
            return Products.ToArray();
        }
    }
}
