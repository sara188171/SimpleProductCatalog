namespace ProductCatalogApi.Data
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> AddProductAsync(Product newProduct);
    }

}
