using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.Repository
{
    public class ProductRepository  : IProductRepository
    {
        private ProductDAO ProductDAO = new ProductDAO();
        public List<ProductObject> GetProducts() => ProductDAO.GetProducts();
        public ProductObject GetProductById(int id) => ProductDAO.GetProductById(id);
        public void InsertProduct(ProductObject p) => ProductDAO.SaveProduct(p);
        public void UpdateProduct(ProductObject p) => ProductDAO.UpdateProduct(p);
        public void DeleteProduct(ProductObject p) => ProductDAO.DeleteProduct(p);

        public List<ProductObject> SearchProduct(string search) => ProductDAO.SearchProduct(search);

        public void ReductAmount(int productid) => ProductDAO.ReduceAmount(productid);
    }
}
