

using ProductCatalogApi;
using ProductCatalogApi.BL.Validaitors;

namespace CorrectCode.BL.Validaitors
{
    public class ProductValidaitor  : IProductValidaitor
    {
        public bool CheackProductValidaitor(Product product)
        {
            if (product == null)
                return false;
            if (product == null || string.IsNullOrWhiteSpace(product.Name) || string.IsNullOrWhiteSpace(product.Category) || product.Price <= 0)
                return false;
            return true;    

        }
    }
}
