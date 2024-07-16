using BilakProjectBackend.Models;

namespace BilakProjectBackend.Services
{
    public interface IProduct
    {
        public List<Product> GetProducts();
        public Product GetProductById(int id);
        public Product CreateProduct(Product product);
        public Product UpdateProduct(Product product);
        public Product DeleteProduct(int id);

    }
}
