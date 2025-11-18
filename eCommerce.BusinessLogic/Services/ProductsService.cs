using eCommerce.BusinessLogic.DTO;
using eCommerce.BusinessLogic.ServiceContracts;
using eCommerce.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BusinessLogic.Services
{
    internal class ProductsService : IProductsService
    {
        public Task<ProductResponse> AddProduct(ProductAddRequest product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductResponse> GetProductByCondition(string condition)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductResponse>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<ProductResponse> UpdateProduct(ProductUpdateRequest product)
        {
            throw new NotImplementedException();
        }
    }
}
