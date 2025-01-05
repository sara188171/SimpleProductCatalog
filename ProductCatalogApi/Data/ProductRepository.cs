namespace ProductCatalogApi.Data
{
    public class ProductRepository : IProductRepository
    {
        private static readonly Dictionary<int, Product> Products = new Dictionary<int, Product>
        {
            [1] = new Product { Id = 1, Name = "oven", Category = "Electrical appliances", Price = 12000 },
            [2] = new Product { Id = 2, Name = "Table", Category = "Furniture", Price = 2000 }
        };

        private static int CurrentId = 2;

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await Task.Run(() => Products.Values);
        }

        public async Task<Product> AddProductAsync(Product newProduct)
        {
            return await Task.Run(() =>
           {
               var newId = Interlocked.Increment(ref CurrentId);
               newProduct.Id = newId;
               Products.Add(newId, newProduct);
               return newProduct;
           });
        }
    }

}