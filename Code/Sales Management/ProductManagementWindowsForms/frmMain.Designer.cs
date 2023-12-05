namespace SaleWinApp
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            tsMember = new ToolStripTextBox();
            tsProduct = new ToolStripTextBox();
            tsOrder = new ToolStripTextBox();
            tsLogout = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsMember, tsProduct, tsOrder, tsLogout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(791, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsMember
            // 
            tsMember.Name = "tsMember";
            tsMember.ReadOnly = true;
            tsMember.Size = new Size(100, 27);
            tsMember.Text = "Member";
            tsMember.Click += tsMember_Click;
            // 
            // tsProduct
            // 
            tsProduct.Name = "tsProduct";
            tsProduct.ReadOnly = true;
            tsProduct.Size = new Size(100, 27);
            tsProduct.Text = "Product";
            tsProduct.Click += tsProduct_Click;
            // 
            // tsOrder
            // 
            tsOrder.Name = "tsOrder";
            tsOrder.ReadOnly = true;
            tsOrder.Size = new Size(100, 27);
            tsOrder.Text = "Order";
            tsOrder.Click += tsOrder_Click;
            // 
            // tsLogout
            // 
            tsLogout.Name = "tsLogout";
            tsLogout.ReadOnly = true;
            tsLogout.Size = new Size(100, 27);
            tsLogout.Text = "Logout";
            tsLogout.Click += tsLogout_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 563);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmProducts";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TsOrder_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripTextBox tsMember;
        private ToolStripTextBox tsProduct;
        private ToolStripTextBox tsOrder;
        private ToolStripTextBox tsLogout;
    }
}