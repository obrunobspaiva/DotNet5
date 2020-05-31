using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewExpressions.Model;
using System.Collections.Generic;

namespace NewExpressions.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController: ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            ProductModel prod1 = new("0001", "Product 0001", 100.11);
            ProductModel prod2 = new("0002", "Product 0002", 20.20);

            List<ProductModel> product = new() { prod1, prod2 };

            return product;
        }
    }
}
