using BusinessObjects.Models;
using Microsoft.IdentityModel.Tokens;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        public static List<ProductObject> GetProducts()
        {
            using var _context = new FstoreContext();
            var listProducts = _context.Products.ToList();
            return listProducts;
        }

        
        public static ProductObject GetProductById(int id)
        {
            ProductObject product = null;
            try
            {
                using (var content = new FstoreContext())
                {
                    product  = content.Products.SingleOrDefault(x => x.ProductId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public static void ReduceAmount(int productid)
        {
            using var _context = new FstoreContext();
            var product = _context.Products.SingleOrDefault(x => x.ProductId == productid);
            product.UnitsInStock -= 1;
            _context.SaveChanges();
        }

        public static void SaveProduct(ProductObject p)
        {
            try
            {
                using (var content = new FstoreContext())
                {
                    content.Products.Add(p);
                    content.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteProduct(ProductObject p)
        {
            using var _context = new FstoreContext();
            _context.Products.Remove(p);
            _context.SaveChanges();
        }

        public static void UpdateProduct(ProductObject p)
        {
            try
            {
                using (var content = new FstoreContext())
                {
                    content.Products.Update(p);
                    content.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ProductObject> SearchProduct(string search)
        {
            using var _content = new FstoreContext();
            if(search.IsNullOrEmpty())
            {
                return GetProducts();
            }
            return _content.Products.Where(x => x.ProductId.ToString().Equals(search) || x.ProductName.Equals(search) || 
            x.UnitPrice.ToString().Equals(search) || x.UnitsInStock.ToString().Equals(search)).ToList();
        }

    }
}
