namespace StokTakip.UI.WinForms
{
    partial class ProductForm
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
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvProducts = new DataGridView();
            label4 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 48);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 14);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Kategori:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 81);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Fiyat:";
            label3.Click += label3_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(322, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(322, 11);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(322, 78);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 27);
            txtPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(222, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(322, 144);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(422, 144);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 212);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(776, 226);
            dgvProducts.TabIndex = 9;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 114);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 10;
            label4.Text = "Stok:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(322, 111);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(151, 27);
            txtStock.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 182);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 12;
            label5.Text = "Ürün Ara:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(85, 179);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(151, 27);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(dgvProducts);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(cmbCategory);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvProducts;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtSearch;
    }
}