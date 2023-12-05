using BusinessObjects.Models;
using DataAccessObjects.Repository;
using Microsoft.EntityFrameworkCore;
using ProductManagementWindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmAddProduct : Form
    {
        private BindingSource source = new BindingSource();

        private IProductRepository productRepository = new ProductRepository();

        private IOrderRepository orderRepository = new OrderRepository();

        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private readonly FstoreContext _context = new FstoreContext();
        private int memberid { get; set; }
        public frmAddProduct()
        {
            InitializeComponent();
            this.Load += delegate
            {
                txtProductID.Enabled = false;
                var productid = _context.Products.OrderByDescending(x => x.ProductId).Select(x => x.ProductId).First() + 1;
                txtProductID.Text = productid.ToString();
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            productRepository.InsertProduct(p);
            MessageBox.Show("Added");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
