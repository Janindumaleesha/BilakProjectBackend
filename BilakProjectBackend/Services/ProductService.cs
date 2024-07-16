using BilakProjectBackend.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BilakProjectBackend.Services
{
    public class ProductService : IProduct
    {
        private readonly BilakDbContext _dbContext = new BilakDbContext();
        public Product CreateProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public void DeleteProduct(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
            }
        }

        public Product GetProductById(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                return product;
            }
            return null;
        }

        public List<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void UpdateProduct(int id, Product product)
        {
            var updateProduct = _dbContext.Products.FirstOrDefault(x => x.Id == id);
            if (updateProduct != null)
            {
                _dbContext.Products.Update(updateProduct);
                _dbContext.SaveChanges();
            }
        }
    }
}
