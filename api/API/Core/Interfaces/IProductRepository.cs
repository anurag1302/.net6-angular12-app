using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();

        Task<Product> GetProductByIdAsync(int id);
    }
}
