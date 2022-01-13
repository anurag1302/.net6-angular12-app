using Infrastructure.Data;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _storeContext;

        public ProductRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _storeContext.Products
                .Include(t => t.ProductType)
                .Include(b => b.ProductBrand)
                .ToListAsync();
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _storeContext.Products
                .Include(t => t.ProductType)
                .Include(b => b.ProductBrand)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<ProductType>> GetProductTypesAsync()
        {
            return await _storeContext.ProductTypes.ToListAsync();
        }

        public async Task<List<ProductBrand>> GetProductBrandsAsync()
        {
            return await _storeContext.ProductBrands.ToListAsync();
        }
    }
}
