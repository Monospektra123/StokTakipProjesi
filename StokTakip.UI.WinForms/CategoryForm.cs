using StokTakip.DataAccess;
using StokTakip.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StokTakip.UI.WinForms
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        StokTakipContext context = new StokTakipContext();
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            dgvCategories.DataSource = context.Categories
                                      .Select(x => new { x.Id, KategoriAdi = x.Name })
                                      .ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Kategori adı boş olamaz!");
                return;
            }
            var kategori = new Category { Name = txtName.Text };
            context.Categories.Add(kategori);
            context.SaveChanges();
            MessageBox.Show("Kategori Eklendi!");
            Listele();
            txtName.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                int seciliId = (int)dgvCategories.SelectedRows[0].Cells["Id"].Value;
                var silinecek = context.Categories.Find(seciliId);
                context.Categories.Remove(silinecek);
                context.SaveChanges();
                MessageBox.Show("Kategori Silindi!");
                Listele();
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek kategoriyi seçin.");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                int seciliId = (int)dgvCategories.SelectedRows[0].Cells["Id"].Value;
                var guncellenecek = context.Categories.Find(seciliId);
                guncellenecek.Name = txtName.Text;
                context.SaveChanges();
                MessageBox.Show("Kategori Güncellendi!");
                Listele();
                txtName.Clear();
            }
        }
        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = dgvCategories.Rows[e.RowIndex].Cells["KategoriAdi"].Value.ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}