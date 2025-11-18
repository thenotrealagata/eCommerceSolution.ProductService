using eCommerce.BusinessLogic.DTO;
using eCommerce.DataAccess.Entities;

namespace eCommerce.BusinessLogic.ServiceContracts
{
    public interface IProductsService
    {
        public Task<ProductResponse> GetProductByCondition(string condition);
        public Task<List<ProductResponse>> GetProducts();
        public Task<ProductResponse> AddProduct(ProductAddRequest product);
        public Task<ProductResponse> UpdateProduct(ProductUpdateRequest product);
        public Task<bool> DeleteProduct(Guid productId);
    }
}
