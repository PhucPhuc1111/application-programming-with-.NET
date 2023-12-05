using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{

    /// <summary>
    /// Class này cung cấp dữ liệu từ table Category cho UI, và ngược lại
    /// Class này sẽ xài CategoryRepo vừa tạo, Repo thì lại gọi đến DbContex
    /// </summary>
    public class BookCategoryService
    {

        private CategoryDAO _repo;
        public List<BookCategory> GetAllCategories()
        {
            _repo = new CategoryDAO();
            return _repo.GetAll();
        }

    }
}
