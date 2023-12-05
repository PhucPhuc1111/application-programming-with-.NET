using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{

    /// <summary>
    /// Đây là class chịu trách nhiệm tương tác trực tiếp với CSDL, với table
    /// Book, tức là nó sẽ xài class Book đc generate bởi lệnh scaffold mình đã gõ
    /// Các hàm sẽ là CRUD 1 cuốn sách 1 instance of Book class
    /// Để tương tác đc với CSDL thì ta PHẢI GỌI CÁI CLASS BookManagment2023DbContext
    /// Class DbContext này nó đại diện cho CSDL MÌNH ĐANG SỬ DỤNG, ĐANG KẾT NỐI TỚI 
    /// </summary>
    public class BookDAO
    {
        //CRUD MỨC CƠ SỞ DỮ LIỆU, XÀO NẤU DATA TỪ CSDL LÀ VIỆC CỦA THẰNG SERVICE
        //CHUẨN CODE CHỖ NÀY PHẢI KẾ THỪA TỪ INTERFACE IRepository<Entity>
        //                                             IBookRepository
        //bài bữa nay ko dùng interface này, vì dùng interface vẫn phải code CRUD

        /// <summary>
        /// Hàm nhận vào mã cuốn sách là số nguyên và where và trả
        /// về duy nhất 1 cuốn - new Book()
        /// Phải nhờ đến class DbContext đang có chứa chuỗi kết nối đọc từ JSON giúp        
        /// Vì mã sách có thể sai, có thể ko thấy sách để return, ta sẽ return null khi đó
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        private BookManagement2023DbContext _context;
        public Book? Get(int bookId)
        {
            _context = new BookManagement2023DbContext();
            //_context.Books; //tương đương SELECT * FROM
            //lấy 1 cuốn theo Id có 2 cách:
            //LINQ: FirstOrDefault(lamba - hàm - delegate trả về 1 object theo đk nào đó)
            //                                        Func<>
            //dùng hàm sẵn của List, hàm Find(theo key)

            return _context.Books.Find(bookId);
        }

        /// <summary>
        /// Hàm này trả về tất cả các cuốn sách đang có trong table Book
        /// tức là return List<Book>. Cần gọi DbContext, đang nắm giữ 3 table
        /// Có 1 chuyện thú vị ở mối quan hệ 1-N TRONG TABLE Ở ĐÂY...
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAll() {
            _context = new BookManagement2023DbContext();
            //return _context.Books.ToList(); //quá đã
            //CHỈ LOAD THÔNG TIN TABLE BOOK, KO LOAD TABLE CATEGORY
            //LÀM SAO LOAD ĐC INFO CỦA CATEGORY, ĐỂ SAU NÀY CÒN LẤY TÊN CATEGORY
            //GIỐNG NHƯ CÂU SELECT * FROM BOOK B, CATEGORY C WHERE B.CATID = C.CATID - JOIN

            //CÂU JOIN BẮT ĐẦU
            return _context.Books.Include(cat => cat.BookCategory).ToList();
        }                                 //inner join sang table BookCategory
                                          //qua đặc tính/thuộc tính Category ở Book
                                          


        /// <summary>
        /// Hàm này tạo mới 1 cuốn sách, insert xuống DB qua gọi hành động
        /// của DbContext và đang đc chống lưng bởi Entity Framework
        /// Đầu vào cần là new Book(...) mới tinh nào đó
        /// </summary>
        /// <param name="book"></param>
        public void Create(Book book) {
            _context = new BookManagement2023DbContext();
            _context.Books.Add(book); //quá đã, INSERT INTO BOOK VALUES(...)
            _context.SaveChanges();
        }   

        /// <summary>
        /// Hàm này sẽ cập nhật 1 cuốn sách đang có, với thông tin bên trong 
        /// cuốn sách đc điều chỉnh: giá mới, năm xb mới, tên gõ đúng chính tả...
        /// Vẫn cần đưa vào 1 cuốn sách, và phải gọi DbContext
        /// </summary>
        /// <param name="book"></param>
        public void Update(Book book) {
            _context = new BookManagement2023DbContext();
            _context.Books.Update(book); 
            //quá đã, SQL: UPDATE BOOK SET NAME = 'TÊN MỚI CHO CUỐN SÁCH'... WHERE
            _context.SaveChanges();
        }   

        /// <summary>
        /// Hàm này xoá 1 cuốn sách theo Id. TA CẦN WHERE THEO ID
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id) {
            //ta phải đi tìm cuốn sách rồi mới xoá nó
            //xài LINQ, hoặc GET() Ở TRÊN
            _context = new BookManagement2023DbContext();
            var book = _context.Books.FirstOrDefault(b => b.BookId == id);
            //                                     nhận vào 1 delegate
            //                                     delegate(student) -> sv thoả tiêu chí
            if (book != null)
            {                
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        //public List<Book> Search(string keyword) { }
        //nên để ở tầng Service do nhu cầu search khác nhau
        //tầng Repo chỉ nên làm những hàm cơ bản CRUD data trong table
        //cung cấp data cho tầng Service xào nấu

    }
}
