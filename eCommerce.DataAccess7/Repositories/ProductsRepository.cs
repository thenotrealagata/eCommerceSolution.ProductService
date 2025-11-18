using eCommerce.DataAccess.Entities;
using eCommerce.DataAccess.RepositoryContracts;

namespace eCommerce.DataAccess.Repositories
{
    internal class ProductsRepository : IProductsRepository
    {
        public Task<Product> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetProductByCondition(string condition)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
