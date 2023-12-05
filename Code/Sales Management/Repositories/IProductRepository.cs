
using BusinessObjects.Models;

namespace Repositories
{
    public interface IProductRepository
    {
        public interface IProductRepository
        {
            void SaveProduct(Product p);
            void DeleteProduct(Product p);
            void UpdateProduct(Product p);
            List<Category> GetCategories();
            List<Product> GetProducts();
            Product GetProductById(int id);
        }
    }
}
