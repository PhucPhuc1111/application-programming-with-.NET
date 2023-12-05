using BusinessObjects.Models;
using DataAccessObjects.Repository;

namespace SaleWinApp
{
    public partial class frmAddMember : Form
    {
        private IMemberReposity MemberRepository = new MemberRepository();
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            MemberRepository.InsertMem(member);
            MessageBox.Show("Inserted");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
