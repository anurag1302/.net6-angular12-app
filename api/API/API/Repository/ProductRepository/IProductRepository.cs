using API.Entities;

namespace API.Repository.ProductRepository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
    }
}
