using AutoMapper;
using eCommerce.BusinessLogic.DTO;
using eCommerce.BusinessLogic.ServiceContracts;
using eCommerce.DataAccess.Entities;
using eCommerce.DataAccess.RepositoryContracts;

namespace eCommerce.BusinessLogic.Services
{
    internal class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public ProductsService(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductResponse>> GetProducts()
        {
            List<Product> products = await _productsRepository.GetProducts();

            return products.Select(p => _mapper.Map<ProductResponse>(p)).ToList();
        }

        public async Task<ProductResponse?> GetProductById(Guid id)
        {
            Product? product = await _productsRepository.GetProductById(id);

            if (product is null)
            {
                return null;
            }
            
            return _mapper.Map<ProductResponse>(product);
        }

        public async Task<ProductResponse?> GetProductByCondition(string condition)
        {
            Product? product = await _productsRepository.GetProductByCondition(condition);

            if (product is null)
            {
                return null;
            }

            return _mapper.Map<ProductResponse>(product);
        }


        public async Task<ProductResponse> AddProduct(ProductAddRequest product)
        {
            var productEntity = _mapper.Map<Product>(product);

            await _productsRepository.AddProduct(productEntity);
            return _mapper.Map<ProductResponse>(productEntity);
        }

        public async Task<ProductResponse> UpdateProduct(ProductUpdateRequest product)
        {
            var updatedProductEntity = _mapper.Map<Product>(product);
            await _productsRepository.UpdateProduct(updatedProductEntity);

            return _mapper.Map<ProductResponse>(updatedProductEntity);
        }

        public async Task<bool> DeleteProduct(Guid productId)
        {
            bool success = await _productsRepository.DeleteProduct(productId);
            return success;
        }        
    }
}
