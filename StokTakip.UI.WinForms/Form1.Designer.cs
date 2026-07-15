namespace StokTakip.UI.WinForms
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuUrunler = new ToolStripMenuItem();
            menuMusteriler = new ToolStripMenuItem();
            kategoriYönetimiToolStripMenuItem = new ToolStripMenuItem();
            menuSatis = new ToolStripMenuItem();
            menuRaporlar = new ToolStripMenuItem();
            menuCikis = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuUrunler, menuMusteriler, kategoriYönetimiToolStripMenuItem, menuSatis, menuRaporlar, menuCikis });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuUrunler
            // 
            menuUrunler.Name = "menuUrunler";
            menuUrunler.Size = new Size(116, 24);
            menuUrunler.Text = "Ürün Yönetimi";
            menuUrunler.Click += menuUrunler_Click;
            // 
            // menuMusteriler
            // 
            menuMusteriler.Name = "menuMusteriler";
            menuMusteriler.Size = new Size(134, 24);
            menuMusteriler.Text = "Müşteri Yönetimi";
            menuMusteriler.Click += menuMusteriler_Click;
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            kategoriYönetimiToolStripMenuItem.Size = new Size(142, 24);
            kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            kategoriYönetimiToolStripMenuItem.Click += kategoriYönetimiToolStripMenuItem_Click;
            // 
            // menuSatis
            // 
            menuSatis.Name = "menuSatis";
            menuSatis.Size = new Size(114, 24);
            menuSatis.Text = "Satış İşlemleri";
            menuSatis.Click += menuSatis_Click;
            // 
            // menuRaporlar
            // 
            menuRaporlar.Name = "menuRaporlar";
            menuRaporlar.Size = new Size(80, 24);
            menuRaporlar.Text = "Raporlar";
            menuRaporlar.Click += menuRaporlar_Click;
            // 
            // menuCikis
            // 
            menuCikis.Name = "menuCikis";
            menuCikis.Size = new Size(53, 24);
            menuCikis.Text = "Çıkış";
            menuCikis.Click += menuCikis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Sistemi - Ana Sayfa";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuUrunler;
        private ToolStripMenuItem menuMusteriler;
        private ToolStripMenuItem menuSatis;
        private ToolStripMenuItem menuRaporlar;
        private ToolStripMenuItem menuCikis;
        private ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
    }
}
