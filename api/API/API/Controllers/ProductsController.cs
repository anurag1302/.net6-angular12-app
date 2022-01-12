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
        public async Task<IActionResult> GetProducts()
        {
            var model = await _productRepository.GetProducts();
            return Ok(model);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            return Ok(await _productRepository.GetProductById(id));
        }
    }
}
