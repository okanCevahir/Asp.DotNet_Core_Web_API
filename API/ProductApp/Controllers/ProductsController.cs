using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var products = new List<Product>()
            {
                new Product(){id=1,ProductName="mause"},
                new Product(){id=2,ProductName="phone"},
                new Product(){id=3,ProductName="computer"},
            };
            _logger.LogInformation("GetAllProdut action has been called");
            _logger.LogWarning("Try");
            return Ok(products);
        }

        [HttpPost]
        public IActionResult GetAllProduct([FromBody]Product product)
        {
            _logger.LogWarning("Creat get warning");
            return StatusCode(201);
        }
    }
}
