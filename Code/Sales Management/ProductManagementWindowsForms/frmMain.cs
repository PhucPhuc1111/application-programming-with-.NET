using BusinessObjects.Models;
using ProductManagementWindowsForms;

namespace SaleWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public int MemberID { get; set; }

        public frmMain(int MemberID)
        {
            InitializeComponent();
            this.MemberID = MemberID;
        }

        private void tsMember_Click(object sender, EventArgs e)
        {
            foreach (var ok in this.MdiChildren)
            {
                ok.Close();
            }
            if (MemberID != 0)
            {
                frmMembers frm = new frmMembers(MemberID);
                frm.MdiParent = this;
                frm.Show();
            }

            else
            {
                frmMembers frm = new frmMembers();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tsProduct_Click(object sender, EventArgs e)
        {
            foreach(var ok in this.MdiChildren)
            {
                ok.Close();
            }
            if (MemberID != 0)
            {
                frmProducts frm = new frmProducts(MemberID);
                frm.MdiParent = this;
                frm.Show();
            }

            else
            {
                frmProducts frm = new frmProducts();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tsOrder_Click(object sender, EventArgs e)
        {
            foreach (var ok in this.MdiChildren)
            {
                ok.Close();
            }
            if (MemberID != 0)
            {
                frmOrders frm = new frmOrders(MemberID);
                frm.MdiParent = this;
                frm.Show();
            }

            else
            {
                frmOrders frm = new frmOrders();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tsLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
        }
    }
}
