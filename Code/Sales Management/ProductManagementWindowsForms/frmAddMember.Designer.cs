namespace SaleWinApp
{
    partial class frmAddMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtCompanyName = new TextBox();
            txtEmail = new TextBox();
            txtMemberID = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 297);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 28;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 250);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 27;
            label5.Text = "Country";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 195);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 26;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 144);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 25;
            label3.Text = "CompanyName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 91);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 24;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 30);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(78, 20);
            label1.TabIndex = 23;
            label1.Text = "MemberId";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(152, 294);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(158, 27);
            txtPassword.TabIndex = 22;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(152, 247);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(158, 27);
            txtCountry.TabIndex = 21;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(152, 192);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(158, 27);
            txtCity.TabIndex = 20;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(152, 141);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(158, 27);
            txtCompanyName.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(152, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(158, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(152, 27);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(158, 27);
            txtMemberID.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(68, 363);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(216, 363);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 452);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompanyName);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberID);
            Name = "frmAddMember";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtCompanyName;
        private TextBox txtEmail;
        private TextBox txtMemberID;
        private Button btnAdd;
        private Button btnCancel;
    }
}