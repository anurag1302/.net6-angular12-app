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
            return await _storeContext.Products.ToListAsync();
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _storeContext.Products.FindAsync(id);
        }
    }
}
