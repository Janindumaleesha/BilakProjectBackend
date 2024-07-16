using BilakProjectBackend.Models;

namespace BilakProjectBackend.Services
{
    public interface IProduct
    {
        public List<Product> GetProducts();
        public Product GetProductById(int id);
        public Product CreateProduct(Product product);
        public void UpdateProduct(int id, Product product);
        public void DeleteProduct(int id);

    }
}
