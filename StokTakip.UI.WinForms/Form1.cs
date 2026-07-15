namespace StokTakip.UI.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void menuUrunler_Click(object sender, EventArgs e)
        {
            ProductForm urunFormu = new ProductForm();
            urunFormu.MdiParent = this;
            urunFormu.Show();
        }
        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm kategoriFormu = new CategoryForm();
            kategoriFormu.MdiParent = this;
            kategoriFormu.Show();
        }
        private void menuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void menuMusteriler_Click(object sender, EventArgs e)
        {
            CustomerForm frm = new CustomerForm();
            frm.MdiParent = this;
            frm.Show();
        }
        private void menuSatis_Click(object sender, EventArgs e)
        {
            SaleForm satisFormu = new SaleForm();
            satisFormu.MdiParent = this;
            satisFormu.Show();
        }
        private void menuRaporlar_Click(object sender, EventArgs e)
        {
            ReportForm rapor = new ReportForm();
            rapor.MdiParent = this;
            rapor.Show();
        }
    }
}
