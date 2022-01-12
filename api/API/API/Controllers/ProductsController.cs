using API.Repository.ProductRepository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository=productRepository;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var model = _productRepository.GetProducts();
            return Ok(model);
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "Single Product with id: " + id;
        }
    }
}
