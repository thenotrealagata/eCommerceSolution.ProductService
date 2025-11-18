using eCommerce.DataAccess.Entities;

namespace eCommerce.DataAccess.RepositoryContracts
{
    public interface IProductsRepository
    {
        public Task<List<Product>> GetProducts();
        public Task<Product?> GetProductByCondition(string condition);
        public Task<Product> AddProduct(Product product);
        public Task<Product?> UpdateProduct(Product product);
        public Task<Boolean> DeleteProduct(Guid productId);
    }
}
