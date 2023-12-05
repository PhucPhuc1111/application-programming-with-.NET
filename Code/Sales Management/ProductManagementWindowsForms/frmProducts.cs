using BusinessObjects.Models;
using DataAccessObjects.Repository;
using Microsoft.IdentityModel.Tokens;
using SaleWinApp;

namespace ProductManagementWindowsForms
{
    public partial class frmProducts : Form
    {
        private BindingSource source = new BindingSource();

        private IProductRepository productRepository = new ProductRepository();

        private IOrderRepository orderRepository = new OrderRepository();

        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private readonly FstoreContext _context = new FstoreContext();
        private int memberid { get; set; }
        public frmProducts()
        {
            InitializeComponent();
        }

        public frmProducts(int memberid) : this()
        {
            this.memberid = memberid;
        }

        private void frm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void DisableText()
        {
            txtProductID.Enabled = false;
            txtProductName.Enabled = false;
            txtUnitPrice.Enabled = false;
            txtUnit.Enabled = false;
            txtCategoryID.Enabled = false;
            txtWeight.Enabled = false;
        }

        private void LoadData()
        {
            if (memberid != 0)
            {
                DisableText();
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            source.DataSource = productRepository.GetProducts();
            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtCategoryID.DataBindings.Clear();
            txtUnit.DataBindings.Clear();
            txtWeight.DataBindings.Clear();

            txtProductID.DataBindings.Add("Text", source, "ProductID");
            txtProductName.DataBindings.Add("Text", source, "ProductName");
            txtUnit.DataBindings.Add("Text", source, "UnitsInStock");
            txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
            txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
            txtWeight.DataBindings.Add("Text", source, "Weight");

            dgvProducts.DataSource = source;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (memberid == 0)
            {
                new frmAddProduct().ShowDialog();
            }
            else
            {
                //var orderid = _context.Orders.OrderByDescending(x => x.OrderId).Select(x => x.OrderId).FirstOrDefault() + 1;
                var orderid = _context.Orders.Count() + 1;
                OrderObject o = new OrderObject
                {
                    OrderId = orderid,
                    MemberId = memberid,
                    OrderDate = DateTime.Now,
                    RequiredDate = DateTime.Now,
                    ShippedDate = DateTime.Now,
                    Freight = 0
                };
                orderRepository.InsertOrder(o);

                OrderDetailObject od = new OrderDetailObject
                {
                    OrderId = orderid,
                    ProductId = int.Parse(txtProductID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = 1,
                    Discount = 0
                };
                orderDetailRepository.InsertOrderDetail(od);
                productRepository.ReductAmount(int.Parse(txtProductID.Text));
                MessageBox.Show("Order Success");
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductObject p = new ProductObject
            {
                ProductId = int.Parse(txtProductID.Text),
                CategoryId = int.Parse(txtCategoryID.Text),
                ProductName = txtProductName.Text,
                UnitsInStock = int.Parse(txtUnit.Text),
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                Weight = txtWeight.Text,
            };
            productRepository.DeleteProduct(p);
            MessageBox.Show("Deleted");
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductObject p = new ProductObject
            {
                ProductId = int.Parse(txtProductID.Text),
                CategoryId = int.Parse(txtCategoryID.Text),
                ProductName = txtProductName.Text,
                UnitsInStock = int.Parse(txtUnit.Text),
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                Weight = txtWeight.Text,
            };
            productRepository.UpdateProduct(p);
            MessageBox.Show("Updated");
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain(memberid).Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.IsNullOrEmpty())
            {
                comboBox1.DataBindings.Clear();
                source.DataSource = _context.Products.ToList();
            }
            else if (comboBox1.Text.Equals("ProductID"))
            {
                source.DataSource = _context.Products.Where(x => x.ProductId.ToString().Equals(txtSearch.Text)).ToList();
            }
            else if (comboBox1.Text.Equals("ProductName"))
            {
                source.DataSource = _context.Products.Where(x => x.ProductName.Equals(txtSearch.Text)).ToList();
            }
            else if (comboBox1.Text.Equals("UnitPrice"))
            {
                source.DataSource = _context.Products.Where(x => x.UnitPrice.ToString().Equals(txtSearch.Text)).ToList();
            }
            else if (comboBox1.Text.Equals("UnitInStock"))
            {
                source.DataSource = _context.Products.Where(x => x.UnitsInStock.ToString().Equals(txtSearch.Text)).ToList();
            }
            dgvProducts.DataSource = source;
        }
    }
}