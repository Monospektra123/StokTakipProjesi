namespace StokTakip.UI.WinForms
{
    partial class SaleForm
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
            label1 = new Label();
            cmbCustomer = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            lblTotal = new Label();
            cmbProduct = new ComboBox();
            txtQuantity = new TextBox();
            btnSell = new Button();
            dgvSales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Seçin:";
            label1.Click += label1_Click;
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(290, 16);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(151, 28);
            cmbCustomer.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 53);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "Ürün Seçin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 87);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "Adet:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(409, 115);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(150, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Toplam Tutar: 0.00 TL";
            lblTotal.Click += lblTotal_Click;
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(290, 50);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(151, 28);
            cmbProduct.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(290, 84);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 8;
            // 
            // btnSell
            // 
            btnSell.Location = new Point(421, 83);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(138, 29);
            btnSell.TabIndex = 9;
            btnSell.Text = "Satışı Tamamla";
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSell_Click;
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(12, 146);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 51;
            dgvSales.Size = new Size(776, 292);
            dgvSales.TabIndex = 10;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSales);
            Controls.Add(btnSell);
            Controls.Add(txtQuantity);
            Controls.Add(cmbProduct);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCustomer);
            Controls.Add(label1);
            Name = "SaleForm";
            Text = "SaleForm";
            Load += SaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cmbCustomer;
        private Label label2;
        private Label label3;
        private Label lblTotal;
        private ComboBox cmbProduct;
        private TextBox txtQuantity;
        private Button btnSell;
        private DataGridView dgvSales;
    }
}