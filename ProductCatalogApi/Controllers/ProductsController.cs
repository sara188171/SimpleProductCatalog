using Microsoft.AspNetCore.Mvc;
using ProductCatalogApi.BL.Services;
using ProductCatalogApi.BL.Validaitors;
using System.Collections.Concurrent;

namespace ProductCatalogApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IProductValidaitor _productValidaitor;

        public ProductsController(IProductService productService, IProductValidaitor
            productValidaitor)
        {
            _productService = productService;
            _productValidaitor = productValidaitor;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var products = await _productService.GetAllProductsAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product newProduct)
        {
            if (!_productValidaitor.CheackProductValidaitor(newProduct))
            {
                return BadRequest("Invalid product data.");
            }

            try
            {
                var addedProduct = await _productService.AddProductAsync(newProduct);
                return Ok(addedProduct);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}