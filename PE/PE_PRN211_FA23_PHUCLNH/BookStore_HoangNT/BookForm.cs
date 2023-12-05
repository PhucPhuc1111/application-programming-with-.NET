using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_HoangNT
{
    public partial class BookForm : Form
    {

        //dùng 1 biến PUBLIC Book hoặc biến int id để lưu trạng thái form
        //nếu biến này == null thì Form ứng tạo mới
        //nếu biến này != null tức là id = ??? nào đó, thì ta Get() nó từ DB
        public int? BookId { get; set; }
        private BookService _bookService = new(); //bỏ tên class
        private BookCategoryService _categoryService = new();

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {

            //đổ toàn bộ Category vào ComboBox hoặc DropDown
            cboCategory.DataSource = _categoryService.GetAllCategories();
            //giấu cột ko cần thiết trong 3 cột của table Category,
            //chỉ show cái cột Name của Category -  BookGenreType
            //nhưng khi chọn 1 dòng xổ ra, thì ngầm hiểu value là cột Id
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId"; //chọn 1 dòng xổ ra
            //nghĩa là lấy CategoryId

            if (this.BookId != null)
            {
                //edit mode, thì phải hiển thị data 
                //new mode, do nothing, form trống trơn
                var book = _bookService.GetABook((int)BookId);

                txtId.Text = book.BookId.ToString();
                txtName.Text = book.BookName;
                txtDescription.Text = book.Description;
                dtpReleasedDate.Value = book.ReleaseDate;
                txtQuantity.Text = book.Quantity.ToString();
                txtPrice.Text = book.Price.ToString();
                cboCategory.SelectedValue = book.BookCategoryId;
                txtAuthor.Text = book.Author;
                lblFormTitle.Text = "Update a Book...";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO: BẮT VALIDATION, IF CÁC Ô NHẬP THOẢ HAY KO, KO THÌ CHỬI 
            //      BẰNG MESSAGEBOX.SHOW()

            Book book = new()
            {
                BookId = int.Parse(txtId.Text.Trim()),
                BookName = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                ReleaseDate = dtpReleasedDate.Value.Date, //chỉ lấy ngày, ko lấy giờ
                Author = txtAuthor.Text.Trim(),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                Price = double.Parse(txtPrice.Text.Trim()),
                BookCategoryId = int.Parse(cboCategory.SelectedValue.ToString())
            };

            if (BookId != null)  //mode update
                _bookService.UpdateABook(book);
            else
                _bookService.AddABook(book);

            Close();  //đóng form sau khi save xong

        }
    }
}
