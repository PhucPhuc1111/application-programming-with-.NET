using BusinessObjects.Models;
using DataAccessObjects.Repository;
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
    public partial class frmOrders : Form
    {
        private IOrderRepository orderRepository = new OrderRepository();
        private IOrderDetailRepository detailRepository = new OrderDetailRepository();
        private readonly FstoreContext _context = new FstoreContext();

        private BindingSource source = new BindingSource();
        private BindingSource source2 = new BindingSource();

        private int memberid { get; set; }
        public frmOrders()
        {
            InitializeComponent();
        }

        public frmOrders(int memberid) : this()
        {
            this.memberid = memberid;
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (memberid == 0)
            {
                source.DataSource = orderRepository.GetOrders();
            }
            else
            {
                source.DataSource = orderRepository.getOrdersByUser(memberid);
                
            }

            txtOrderID.DataBindings.Clear();
            txtFreight.DataBindings.Clear();
            txtMemberId.DataBindings.Clear();
            dEndDate.DataBindings.Clear();


            txtOrderID.DataBindings.Add("Text", source, "OrderId");
            txtFreight.DataBindings.Add("Text", source, "Freight");
            txtMemberId.DataBindings.Add("Text", source, "MemberId");

            dgvOrders.DataSource = source;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain(memberid).Visible = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            txtOrderIDOrderDetail.DataBindings.Clear();
            txtProductId.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtDiscount.DataBindings.Clear();
            source2.DataSource = detailRepository.GetOrder(txtOrderID.Text);

            txtOrderIDOrderDetail.DataBindings.Add("Text", source2, "OrderId");
            txtProductId.DataBindings.Add("Text", source2, "ProductId");
            txtUnitPrice.DataBindings.Add("Text", source2, "UnitPrice");
            txtQuantity.DataBindings.Add("Text", source2, "Quantity");
            txtDiscount.DataBindings.Add("Text", source2, "Discount");

            dgvOrderDetail.DataSource = source2;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            detailRepository.DeleteOrderDetail(_context.OrderDetails.SingleOrDefault(x => x.OrderId == int.Parse(txtOrderID.Text)));
            orderRepository.DeleteOrder(_context.Orders.SingleOrDefault(x => x.OrderId == int.Parse(txtOrderID.Text)));
            LoadData();
            MessageBox.Show("Deleted");

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            source.DataSource = _context.Orders.Where(x => x.OrderDate >= dStartDate.Value && x.OrderDate <= dEndDate.Value).ToList();
            dgvOrders.DataSource = source;
        }
    }
}
