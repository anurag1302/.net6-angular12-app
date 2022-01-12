using API.Data;
using API.Entities;

namespace API.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _storeContext;

        public ProductRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }
        public List<Product> GetProducts()
        {
            return _storeContext.Products.ToList();
        }
    }
}
