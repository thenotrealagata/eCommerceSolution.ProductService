using eCommerce.DataAccess.Entities;
using AutoMapper;
using eCommerce.BusinessLogic.DTO;

namespace eCommerce.BusinessLogic.Mappers
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<ProductAddRequest, Product>()
                .ForMember(dest => dest.ProductId, opt => new Guid()); // TODO will this work?
            CreateMap<Product, ProductResponse>();
            CreateMap<ProductUpdateRequest, Product>();
        }
    }
}
