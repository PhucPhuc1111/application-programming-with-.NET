using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.Repository
{
    public interface IProductRepository
    {
        public List<ProductObject> GetProducts();
        public ProductObject GetProductById(int id);
        void InsertProduct(ProductObject p);
        void UpdateProduct(ProductObject p);
        void DeleteProduct(ProductObject p);

        public List<ProductObject> SearchProduct(string search);
        public void ReductAmount(int productid);
    }
}
