using API_EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_EF.Controllers
{
    [Route("api/san-pham")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        MyStoreContext _context;
        public ProductController (MyStoreContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts() 
        {
            return _context.Products.AsEnumerable();
        }
    }
}
