using BusinessObjects.Models;
using DataAccessObjects.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
    public partial class frmMembers : Form
    {
        private IMemberReposity MemberRepository = new MemberRepository();

        private readonly FstoreContext _context = new FstoreContext();

        private BindingSource source = new BindingSource();

        private int MemberID = new frmMain().MemberID;
        public frmMembers()
        {
            InitializeComponent();
        }

        public frmMembers(int MemberID) : this()
        {
            this.MemberID = MemberID;
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (MemberID != 0)
            {
                source.DataSource = MemberRepository.GetMember(MemberID);
                btnAdd.Hide();
                btnDelete.Hide();
            }
            else
            {
                source.DataSource = MemberRepository.GetMembers();
            }
            txtMemberID.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCompanyName.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtPassword.DataBindings.Clear();

            txtMemberID.DataBindings.Add("Text", source, "MemberId");
            txtEmail.DataBindings.Add("Text", source, "Email");
            txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
            txtCity.DataBindings.Add("Text", source, "City");
            txtCountry.DataBindings.Add("Text", source, "Country");
            txtPassword.DataBindings.Add("Text", source, "Password");

            dgvMember.DataSource = source;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var member = new MemberObject
            {
                MemberId = int.Parse(txtMemberID.Text),
                Email = txtEmail.Text,
                CompanyName = txtCompanyName.Text,
                Country = txtCountry.Text,
                City = txtCity.Text,
                Password = txtPassword.Text,
            };
            MemberRepository.UpdateMem(member);
            MessageBox.Show("Updated");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain(MemberID);
            this.Visible = false;
            frmMain.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAddMember().ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var member = new MemberObject
            {
                MemberId = int.Parse(txtMemberID.Text),
                Email = txtEmail.Text,
                CompanyName = txtCompanyName.Text,
                Country = txtCountry.Text,
                City = txtCity.Text,
                Password = txtPassword.Text,
            };
            var order = _context.Orders.Where(o => o.MemberId == int.Parse(txtMemberID.Text)).ToList();
            var orderid = _context.Orders.Where(o => o.MemberId == member.MemberId).Select(o => o.OrderId).ToList();
            foreach(var id in orderid)
            {
                var orderdetail = _context.OrderDetails.Where(x => x.OrderId == id).ToList();
                _context.OrderDetails.RemoveRange(orderdetail);
                _context.SaveChanges();
            }
            _context.Orders.RemoveRange(order);
            _context.SaveChanges();
            MemberRepository.DeleteMem(member);
            MessageBox.Show("Deleted");
            LoadData();
        }
    }
}
