using BusinessObjects.Models;
using DataAccessObjects.Repository;
using Microsoft.Extensions.Configuration;
using SaleWinApp;

namespace ProductManagementWindowsForms
{
    public partial class frmLogin : Form
    {
        private MemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
            this.FormClosed += delegate
            {
                Application.Exit();
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var email = config["AdminAccount:Email"];
            var password = config["AdminAccount:Password"];
            MemberObject user = memberRepository.GetMemberByEmailAndPassWord(txtEmail.Text, txtPassword.Text);
            if (txtEmail.Text.Equals(email) && txtPassword.Text.Equals(password))
            {
                this.Hide();
                new frmMain().ShowDialog();
            }
            else if (user != null)
            {
                this.Hide();
                new frmMain(user.MemberId).ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Username or password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
