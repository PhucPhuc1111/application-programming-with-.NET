using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    /// <summary>
    /// Class này dùng để CRUD table Category - Thể loại Sách
    /// Thường thể loại sách hiếm khi thay đổi, chủ yếu là lấy ra
    /// danh sách đưa vào dropdown/combobox
    /// </summary>
    public class CategoryDAO
    {
        //private BookManagement2023DbContext _context;
        public List<BookCategory> GetAll()
        {
            //_context = new BookManagement2023DbContext();
            //return _context.BookCategories.ToList();
            return new BookManagement2023DbContext().BookCategories.ToList();
        }
    }
}
