using Ecommerce.Models;

namespace Ecommerce.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product? GetProductById(int id);
        Product CreateProduct(Product product);
        Product? UpdateProduct(int id, Product product);
        bool DeleteProduct(int id);
    }
}