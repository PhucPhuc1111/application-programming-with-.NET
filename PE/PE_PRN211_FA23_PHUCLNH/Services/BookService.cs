using Repositories;
using Repositories.Entities;

namespace Services
{
    /// <summary>
    /// Class này chứa các hàm cung cấp/tương tác với GUI FORMS
    /// Nó sau đó sẽ giao tiếp với Repo tương ứng để tương tác gián tiếp
    /// với CSDL
    /// Các tên hàm nghe nó "người - human-being" hơn so với repo CRUD
    /// ví dụ:                 CheckLogin()           VS.     Get()
    ///                        GetAllBooks()           VS.     GetAll() 
    /// </summary>
    public class BookService
    {
        //cần repo để CRUD XUỐNG DB
        //CẦN ĐƯA RA HÀM ĐỂ CUNG CẤP CHO FORM 
        //THẰNG ĐỨNG 2 HÀNG
        private BookDAO _repo = new BookDAO();
        //NGUYÊN LÍ SOLID, TA PHỤ THUỘC VÀO INTERFACE HƠN LÀ 1 CLASS CỤ THỂ
        //CHỖ NÀY ĐÚNG CHUẨN PHẢI KHAI BÁO: IRepository<Book> _repo
        //                                  IBookRepository _repo;
        //lát hồi new ở Constructor() 1 cái class đã implement
        //HIỆN TƯỢNG, CÁCH NÀY GỌI LÀ DEPENDENCY INJECTION

        /// <summary>
        /// Hàm lấy tất cả sách từ DB và cung cấp cho form
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAllBooks()
        {
            return _repo.GetAll();
        }

        //CÒN HÀM THÊM, XOÁ, SỬA, VÀ VÀ VÀ SEARCH()
        /// <summary>
        /// Hàm này search cuốn sách theo tiêu chí: name, desc
        /// Search theo kiểu contain, tức là name có chứa keyword vừa gõ
        /// ko phải so sánh 2 chuỗi = nhau, mà là tìm gần đúng 
        /// nếu ko thấy cột name, sang cột desc tìm tiếp
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<Book> SearchBooks(string keyword)
        {
            return _repo.GetAll().Where(b => b.BookName.ToLower().Contains(keyword.ToLower()) ||
                                             b.Description.ToLower().Contains(keyword.ToLower())).ToList();
        }

        /// <summary>
        /// Hàm này xoá 1 cuốn sách theo mã số - int
        /// </summary>
        /// <param name="id"></param>
        public void DeleteABook(int id)
        {
            _repo.Delete(id);
        }

        public Book? GetABook(int id)
        {
            return _repo.Get(id);
        }


        //anh hãy đưa em 1 cuốn sách đc new, em nhờ repo add giùm
        public void AddABook(Book book)
        {
            _repo.Create(book); //try-catch, trùng mã số, bỏ trống ô nhập
        }

        public void UpdateABook(Book book)
        {
            _repo.Update(book); //try-catch, validation
        }
    }
}