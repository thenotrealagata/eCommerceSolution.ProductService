using eCommerce.DataAccess.Entities;
using eCommerce.DataAccess.RepositoryContracts;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.DataAccess.Repositories
{
    internal class ProductsRepository : IProductsRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductsRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Product> AddProduct(Product product)
        {
            // TODO set Guid?
            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<Boolean> DeleteProduct(Guid productId)
        {
            Product? product = await _dbContext.Products.FindAsync(productId);

            if (product is null)
            {
                return false;
            }

            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Product?> GetProductByCondition(string condition)
        {
            Product? product = await _dbContext.Products.FirstOrDefaultAsync(p => 
                p.ProductName.Contains(condition, StringComparison.CurrentCultureIgnoreCase) ||
                p.Category.Contains(condition, StringComparison.CurrentCultureIgnoreCase));

            if (product is null)
            {
                return null;
            }

            return product;
        }

        public async Task<List<Product>> GetProducts()
        {
            var products = await _dbContext.Products.ToListAsync();

            return products;
        }

        public async Task<Product?> UpdateProduct(Product product)
        {
            var affectedRows = await _dbContext.Products
                .Where(p => p.ProductId == product.ProductId)
                .ExecuteUpdateAsync(p => p
                    .SetProperty(p => p.ProductName, product.ProductName)
                    .SetProperty(p => p.Category, product.Category)
                    .SetProperty(p => p.UnitPrice, product.UnitPrice)
                    .SetProperty(p => p.QuantityInStock, product.QuantityInStock)
                );

            if (affectedRows == 0)
            {
                return null;
            }

            return product;
        }
    }
}
