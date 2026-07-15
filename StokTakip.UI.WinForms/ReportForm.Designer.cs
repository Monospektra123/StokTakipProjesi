namespace StokTakip.UI.WinForms
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
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
            lblProductCount = new Label();
            label2 = new Label();
            lblCustomerCount = new Label();
            label4 = new Label();
            lblTotalRevenue = new Label();
            label6 = new Label();
            lblSaleCount = new Label();
            label1 = new Label();
            dgvCriticalStock = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCriticalStock).BeginInit();
            SuspendLayout();
            // 
            // lblProductCount
            // 
            lblProductCount.AutoSize = true;
            lblProductCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblProductCount.Location = new Point(115, 9);
            lblProductCount.Name = "lblProductCount";
            lblProductCount.Size = new Size(50, 20);
            lblProductCount.TabIndex = 1;
            lblProductCount.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 0;
            label2.Text = "Toplam Müşteri:";
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCustomerCount.Location = new Point(133, 49);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(50, 20);
            lblCustomerCount.TabIndex = 1;
            lblCustomerCount.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 89);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 0;
            label4.Text = "Toplam Satış Tutarı:";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalRevenue.Location = new Point(157, 89);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(50, 20);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 129);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 0;
            label6.Text = "Yapılan Satış Adedi:";
            // 
            // lblSaleCount
            // 
            lblSaleCount.AutoSize = true;
            lblSaleCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSaleCount.Location = new Point(157, 129);
            lblSaleCount.Name = "lblSaleCount";
            lblSaleCount.Size = new Size(50, 20);
            lblSaleCount.TabIndex = 1;
            lblSaleCount.Text = "label7";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Toplam Ürün:";
            // 
            // dgvCriticalStock
            // 
            dgvCriticalStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCriticalStock.Location = new Point(12, 250);
            dgvCriticalStock.Name = "dgvCriticalStock";
            dgvCriticalStock.RowHeadersWidth = 51;
            dgvCriticalStock.Size = new Size(776, 188);
            dgvCriticalStock.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 227);
            label3.Name = "label3";
            label3.Size = new Size(229, 20);
            label3.TabIndex = 3;
            label3.Text = "Kritik Stoktaki Ürünler (20'den az)";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dgvCriticalStock);
            Controls.Add(label1);
            Controls.Add(lblSaleCount);
            Controls.Add(lblTotalRevenue);
            Controls.Add(label6);
            Controls.Add(lblCustomerCount);
            Controls.Add(label4);
            Controls.Add(lblProductCount);
            Controls.Add(label2);
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCriticalStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProductCount;
        private Label lblCustomerCount;
        private Label label2;
        private Label lblTotalRevenue;
        private Label label4;
        private Label lblSaleCount;
        private Label label6;
        private Label label1;
        private DataGridView dgvCriticalStock;
        private Label label3;
    }
}