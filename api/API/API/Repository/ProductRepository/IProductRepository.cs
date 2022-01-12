using API.Entities;

namespace API.Repository.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();

        Task<Product> GetProductById(int id);
    }
}
