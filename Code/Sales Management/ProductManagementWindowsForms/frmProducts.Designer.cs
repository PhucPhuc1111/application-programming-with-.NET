namespace ProductManagementWindowsForms
{
    partial class frmProducts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            txtUnit = new TextBox();
            txtUnitPrice = new TextBox();
            txtCategoryID = new TextBox();
            dgvProducts = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtWeight = new TextBox();
            btnCancel = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 82);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 136);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 3;
            label4.Text = "Units In Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 26);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Unit Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(381, 82);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 5;
            label6.Text = "Categories ID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(110, 26);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(193, 27);
            txtProductID.TabIndex = 6;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(112, 82);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(193, 27);
            txtProductName.TabIndex = 7;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(110, 129);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(193, 27);
            txtUnit.TabIndex = 8;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(518, 23);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(193, 27);
            txtUnitPrice.TabIndex = 9;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(518, 75);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(193, 27);
            txtCategoryID.TabIndex = 10;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(21, 455);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(755, 250);
            dgvProducts.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(44, 399);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(381, 399);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(204, 399);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 132);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 16;
            label1.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(518, 129);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(193, 27);
            txtWeight.TabIndex = 17;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(564, 399);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(518, 191);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(271, 193);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(231, 27);
            txtSearch.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ProductID", "ProductName", "UnitPrice", "UnitInStock" });
            comboBox1.Location = new Point(87, 193);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 28);
            comboBox1.TabIndex = 22;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 717);
            Controls.Add(comboBox1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnCancel);
            Controls.Add(txtWeight);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvProducts);
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
            Name = "frmProducts";
            Text = "Form1";
            Load += frm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private TextBox txtUnit;
        private TextBox txtUnitPrice;
        private TextBox txtCategoryID;
        private DataGridView dgvProducts;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private TextBox txtWeight;
        private Button btnCancel;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox comboBox1;
    }
}