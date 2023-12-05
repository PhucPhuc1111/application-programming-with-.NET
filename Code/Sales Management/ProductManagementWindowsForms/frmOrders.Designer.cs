namespace SaleWinApp
{
    partial class frmOrders
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            gbOrder = new GroupBox();
            dStartDate = new DateTimePicker();
            txtMemberId = new TextBox();
            txtFreight = new TextBox();
            dEndDate = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtOrderID = new TextBox();
            label1 = new Label();
            dgvOrders = new DataGridView();
            gbOrderDetail = new GroupBox();
            txtDiscount = new TextBox();
            label7 = new Label();
            txtQuantity = new TextBox();
            label8 = new Label();
            txtUnitPrice = new TextBox();
            label10 = new Label();
            txtProductId = new TextBox();
            label11 = new Label();
            txtOrderIDOrderDetail = new TextBox();
            label12 = new Label();
            dgvOrderDetail = new DataGridView();
            btnView = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnFilter = new Button();
            gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            gbOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // gbOrder
            // 
            gbOrder.Controls.Add(btnFilter);
            gbOrder.Controls.Add(dStartDate);
            gbOrder.Controls.Add(txtMemberId);
            gbOrder.Controls.Add(txtFreight);
            gbOrder.Controls.Add(dEndDate);
            gbOrder.Controls.Add(label6);
            gbOrder.Controls.Add(label5);
            gbOrder.Controls.Add(label3);
            gbOrder.Controls.Add(label2);
            gbOrder.Controls.Add(txtOrderID);
            gbOrder.Controls.Add(label1);
            gbOrder.Controls.Add(dgvOrders);
            gbOrder.Location = new Point(12, 12);
            gbOrder.Name = "gbOrder";
            gbOrder.Size = new Size(659, 516);
            gbOrder.TabIndex = 1;
            gbOrder.TabStop = false;
            gbOrder.Text = "Order";
            // 
            // dStartDate
            // 
            dStartDate.Location = new Point(354, 27);
            dStartDate.Name = "dStartDate";
            dStartDate.Size = new Size(250, 27);
            dStartDate.TabIndex = 17;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(90, 144);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(132, 27);
            txtMemberId.TabIndex = 16;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(90, 79);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(132, 27);
            txtFreight.TabIndex = 15;
            // 
            // dEndDate
            // 
            dEndDate.Location = new Point(354, 86);
            dEndDate.Name = "dEndDate";
            dEndDate.Size = new Size(250, 27);
            dEndDate.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 86);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 11;
            label6.Text = "EndDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 27);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 9;
            label5.Text = "StartDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 147);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 5;
            label3.Text = "MemberId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Freight";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(90, 20);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(132, 27);
            txtOrderID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "OrderID";
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(19, 234);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 29;
            dgvOrders.Size = new Size(597, 219);
            dgvOrders.TabIndex = 0;
            // 
            // gbOrderDetail
            // 
            gbOrderDetail.Controls.Add(txtDiscount);
            gbOrderDetail.Controls.Add(label7);
            gbOrderDetail.Controls.Add(txtQuantity);
            gbOrderDetail.Controls.Add(label8);
            gbOrderDetail.Controls.Add(txtUnitPrice);
            gbOrderDetail.Controls.Add(label10);
            gbOrderDetail.Controls.Add(txtProductId);
            gbOrderDetail.Controls.Add(label11);
            gbOrderDetail.Controls.Add(txtOrderIDOrderDetail);
            gbOrderDetail.Controls.Add(label12);
            gbOrderDetail.Controls.Add(dgvOrderDetail);
            gbOrderDetail.Location = new Point(733, 12);
            gbOrderDetail.Name = "gbOrderDetail";
            gbOrderDetail.Size = new Size(656, 516);
            gbOrderDetail.TabIndex = 2;
            gbOrderDetail.TabStop = false;
            gbOrderDetail.Text = "Order Detail";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(388, 79);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(132, 27);
            txtDiscount.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(290, 80);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 9;
            label7.Text = "Discount";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(388, 19);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(132, 27);
            txtQuantity.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(285, 22);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 7;
            label8.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(90, 147);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(132, 27);
            txtUnitPrice.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 147);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 5;
            label10.Text = "UnitPrice";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(90, 77);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(132, 27);
            txtProductId.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 79);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 3;
            label11.Text = "ProductId";
            // 
            // txtOrderIDOrderDetail
            // 
            txtOrderIDOrderDetail.Location = new Point(90, 20);
            txtOrderIDOrderDetail.Name = "txtOrderIDOrderDetail";
            txtOrderIDOrderDetail.Size = new Size(132, 27);
            txtOrderIDOrderDetail.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 23);
            label12.Name = "label12";
            label12.Size = new Size(62, 20);
            label12.TabIndex = 1;
            label12.Text = "OrderID";
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(26, 234);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.RowTemplate.Height = 29;
            dgvOrderDetail.Size = new Size(597, 219);
            dgvOrderDetail.TabIndex = 0;
            // 
            // btnView
            // 
            btnView.Location = new Point(449, 547);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 17;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(643, 547);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(836, 547);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(354, 138);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 588);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnView);
            Controls.Add(gbOrderDetail);
            Controls.Add(gbOrder);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOrders";
            Text = "frmOrder";
            Load += frmOrders_Load;
            gbOrder.ResumeLayout(false);
            gbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            gbOrderDetail.ResumeLayout(false);
            gbOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox gbOrder;
        private DataGridView dgvOrders;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtOrderID;
        private Label label1;
        private Label label6;
        private DateTimePicker DOrderdate;
        private DateTimePicker DRequiredate;
        private DateTimePicker dEndDate;
        private GroupBox gbOrderDetail;
        private TextBox txtUnitPrice;
        private Label label10;
        private TextBox txtProductId;
        private Label label11;
        private TextBox txtOrderIDOrderDetail;
        private Label label12;
        private DataGridView dgvOrderDetail;
        private TextBox txtDiscount;
        private Label label7;
        private TextBox txtQuantity;
        private Label label8;
        private TextBox txtMemberId;
        private TextBox txtFreight;
        private Button btnView;
        private Button btnCancel;
        private Button btnDelete;
        private DateTimePicker dStartDate;
        private Button btnFilter;
    }
}