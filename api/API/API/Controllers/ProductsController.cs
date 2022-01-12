using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "List of Products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "Single Product with id: " + id;
        }
    }
}
