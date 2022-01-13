using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();

        Task<Product> GetProductByIdAsync(int id);

        Task<List<ProductType>> GetProductTypesAsync();

        Task<List<ProductBrand>> GetProductBrandsAsync();
    }
}
