using eCommerce.BusinessLogic.DTO;
using eCommerce.BusinessLogic.ServiceContracts;
using eCommerce.DataAccess.Entities;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            List<ProductResponse> products = await _productsService.GetProducts();

            return Ok(products);
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            ProductResponse? product = await _productsService.GetProductById(id);

            if (product is null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpGet("/search/{condition}")]
        public async Task<IActionResult> SearchProducts(string condition)
        {
            ProductResponse? product = await _productsService.GetProductByCondition(condition);

            if (product is null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductAddRequest addRequest)
        {
            ProductResponse product = await _productsService.AddProduct(addRequest);
            return CreatedAtAction(nameof(GetProducts), new { id = product.ProductId }, product);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductUpdateRequest updateRequest)
        {
            ProductResponse product = await _productsService.UpdateProduct(updateRequest);
            return Ok(product);
        }

        [HttpDelete("/{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            bool success = await _productsService.DeleteProduct(id);

            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
