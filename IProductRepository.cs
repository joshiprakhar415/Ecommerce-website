using Ecommerce.Models;

namespace Ecommerce.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product? GetProductById(int id);
        Product AddProduct(Product product);
        Product? UpdateProduct(int id, Product product);
        bool DeleteProduct(int id);
    }
}