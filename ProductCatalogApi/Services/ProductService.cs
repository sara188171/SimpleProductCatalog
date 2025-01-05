using ProductCatalogApi.Data;

namespace ProductCatalogApi.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }

        public async Task<Product> AddProductAsync(Product newProduct)
        {
            return await _productRepository.AddProductAsync(newProduct);
        }
    }
}
