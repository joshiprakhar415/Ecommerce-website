using Ecommerce.Interfaces;
using Ecommerce.Models;

namespace Ecommerce.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetProducts()
        {
            return _repository.GetAllProducts();
        }

        public Product? GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public Product CreateProduct(Product product)
        {
            return _repository.AddProduct(product);
        }

        public Product? UpdateProduct(int id, Product product)
        {
            return _repository.UpdateProduct(id, product);
        }

        public bool DeleteProduct(int id)
        {
            return _repository.DeleteProduct(id);
        }
    }
}