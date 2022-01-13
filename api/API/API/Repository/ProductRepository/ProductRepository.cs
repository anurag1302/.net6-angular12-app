using Infrastructure.Data;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _storeContext;

        public ProductRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _storeContext.Products.FindAsync(id);
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _storeContext.Products.ToListAsync();
        }
    }
}
