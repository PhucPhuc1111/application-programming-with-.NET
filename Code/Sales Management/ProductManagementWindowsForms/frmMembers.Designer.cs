namespace SaleWinApp
{
    partial class frmMembers
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
            dgvMember=new DataGridView();
            btnAdd=new Button();
            btnDelete=new Button();
            btnUpdate=new Button();
            btnCancel=new Button();
            txtMemberID=new TextBox();
            txtEmail=new TextBox();
            txtCompanyName=new TextBox();
            txtCity=new TextBox();
            txtCountry=new TextBox();
            txtPassword=new TextBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            label6=new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location=new Point(12, 184);
            dgvMember.Name="dgvMember";
            dgvMember.RowHeadersWidth=51;
            dgvMember.RowTemplate.Height=29;
            dgvMember.Size=new Size(776, 188);
            dgvMember.TabIndex=0;
            // 
            // btnAdd
            // 
            btnAdd.Location=new Point(56, 390);
            btnAdd.Name="btnAdd";
            btnAdd.Size=new Size(94, 29);
            btnAdd.TabIndex=1;
            btnAdd.Text="Add";
            btnAdd.UseVisualStyleBackColor=true;
            btnAdd.Click+=btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location=new Point(240, 390);
            btnDelete.Name="btnDelete";
            btnDelete.Size=new Size(94, 29);
            btnDelete.TabIndex=2;
            btnDelete.Text="Delete";
            btnDelete.UseVisualStyleBackColor=true;
            btnDelete.Click+=btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location=new Point(412, 390);
            btnUpdate.Name="btnUpdate";
            btnUpdate.Size=new Size(94, 29);
            btnUpdate.TabIndex=3;
            btnUpdate.Text="Update";
            btnUpdate.UseVisualStyleBackColor=true;
            btnUpdate.Click+=btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location=new Point(586, 390);
            btnCancel.Name="btnCancel";
            btnCancel.Size=new Size(94, 29);
            btnCancel.TabIndex=4;
            btnCancel.Text="Cancel";
            btnCancel.UseVisualStyleBackColor=true;
            btnCancel.Click+=btnCancel_Click;
            // 
            // txtMemberID
            // 
            txtMemberID.Location=new Point(158, 16);
            txtMemberID.Name="txtMemberID";
            txtMemberID.Size=new Size(158, 27);
            txtMemberID.TabIndex=5;
            // 
            // txtEmail
            // 
            txtEmail.Location=new Point(158, 68);
            txtEmail.Name="txtEmail";
            txtEmail.Size=new Size(158, 27);
            txtEmail.TabIndex=6;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location=new Point(158, 118);
            txtCompanyName.Name="txtCompanyName";
            txtCompanyName.Size=new Size(158, 27);
            txtCompanyName.TabIndex=7;
            // 
            // txtCity
            // 
            txtCity.Location=new Point(558, 12);
            txtCity.Name="txtCity";
            txtCity.Size=new Size(146, 27);
            txtCity.TabIndex=8;
            // 
            // txtCountry
            // 
            txtCountry.Location=new Point(558, 64);
            txtCountry.Name="txtCountry";
            txtCountry.Size=new Size(146, 27);
            txtCountry.TabIndex=9;
            // 
            // txtPassword
            // 
            txtPassword.Location=new Point(558, 111);
            txtPassword.Name="txtPassword";
            txtPassword.Size=new Size(146, 27);
            txtPassword.TabIndex=10;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(56, 19);
            label1.Name="label1";
            label1.RightToLeft=RightToLeft.Yes;
            label1.Size=new Size(78, 20);
            label1.TabIndex=11;
            label1.Text="MemberId";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(88, 71);
            label2.Name="label2";
            label2.Size=new Size(46, 20);
            label2.TabIndex=12;
            label2.Text="Email";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(22, 118);
            label3.Name="label3";
            label3.Size=new Size(112, 20);
            label3.TabIndex=13;
            label3.Text="CompanyName";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(468, 15);
            label4.Name="label4";
            label4.Size=new Size(34, 20);
            label4.TabIndex=14;
            label4.Text="City";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(446, 61);
            label5.Name="label5";
            label5.Size=new Size(60, 20);
            label5.TabIndex=15;
            label5.Text="Country";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(436, 111);
            label6.Name="label6";
            label6.Size=new Size(70, 20);
            label6.TabIndex=16;
            label6.Text="Password";
            // 
            // frmMembers
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
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
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvMember);
            Name="frmMembers";
            Text="frmMember";
            Load+=frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMember;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCancel;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private TextBox txtCompanyName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}