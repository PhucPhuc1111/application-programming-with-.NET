namespace SaleWinApp
{
    partial class frmAddProduct
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
            txtWeight = new TextBox();
            label1 = new Label();
            txtCategoryID = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnit = new TextBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(122, 274);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(193, 27);
            txtWeight.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 274);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 28;
            label1.Text = "Weight";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(122, 221);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(193, 27);
            txtCategoryID.TabIndex = 27;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(120, 177);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(193, 27);
            txtUnitPrice.TabIndex = 26;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(120, 118);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(193, 27);
            txtUnit.TabIndex = 25;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(122, 71);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(193, 27);
            txtProductName.TabIndex = 24;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(120, 15);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(193, 27);
            txtProductID.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 224);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 22;
            label6.Text = "Categories ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 177);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 21;
            label5.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 20;
            label4.Text = "Units In Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 19;
            label3.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 15);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 18;
            label2.Text = "Product ID";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(38, 343);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(221, 343);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 443);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtWeight);
            Controls.Add(label1);
            Controls.Add(txtCategoryID);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtUnit);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmAddProduct";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWeight;
        private Label label1;
        private TextBox txtCategoryID;
        private TextBox txtUnitPrice;
        private TextBox txtUnit;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAdd;
        private Button btnCancel;
    }
}