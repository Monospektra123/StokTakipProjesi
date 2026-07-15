using StokTakip.DataAccess;
using StokTakip.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.UI.WinForms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        StokTakipContext context = new StokTakipContext();
        private void ProductForm_Load(object sender, EventArgs e)
        {
            Listele();
            KategorileriDoldur();
        }
        void Listele()
        {
            var urunler = context.Products
                            .Select(x => new
                            {
                                x.Id,
                                UrunAdi = x.Name,
                                Fiyat = x.Price,
                                Stok = x.Stock,
                                Kategori = x.Category.Name
                            }).ToList();
            dgvProducts.DataSource = urunler;
        }
        void KategorileriDoldur()
        {
            var kategoriler = context.Categories.ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.DataSource = kategoriler;
            cmbCategory.SelectedIndex = -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            Product urun = new Product();
            urun.Name = txtName.Text;
            urun.Price = decimal.Parse(txtPrice.Text);
            urun.Stock = int.Parse(txtStock.Text);
            urun.CategoryId = (int)cmbCategory.SelectedValue;
            context.Products.Add(urun);
            context.SaveChanges();
            MessageBox.Show("Ürün Eklendi!");
            Listele();
            Temizle();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int seciliId = (int)dgvProducts.SelectedRows[0].Cells["Id"].Value;
                var silinecek = context.Products.Find(seciliId);
                context.Products.Remove(silinecek);
                context.SaveChanges();
                MessageBox.Show("Ürün silindi!");
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int seciliId = (int)dgvProducts.SelectedRows[0].Cells["Id"].Value;
                var guncellenecekUrun = context.Products.Find(seciliId);
                guncellenecekUrun.Name = txtName.Text;
                guncellenecekUrun.Price = decimal.Parse(txtPrice.Text);
                guncellenecekUrun.CategoryId = (int)cmbCategory.SelectedValue;
                guncellenecekUrun.Stock = int.Parse(txtStock.Text);
                context.SaveChanges();
                MessageBox.Show("Ürün Güncellendi!");
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek ürünü listeden seçin.");
            }
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProducts.Rows[e.RowIndex];
                txtName.Text = row.Cells["UrunAdi"].Value.ToString();
                txtPrice.Text = row.Cells["Fiyat"].Value.ToString();
                txtStock.Text = row.Cells["Stok"].Value.ToString();
                cmbCategory.Text = row.Cells["Kategori"].Value.ToString();
            }
        }
        void Temizle()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            cmbCategory.SelectedIndex = -1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtSearch.Text;

            var filtrelenmisListe = context.Products
                                    .Where(x => x.Name.Contains(aranan))
                                    .Select(x => new
                                    {
                                        x.Id,
                                        UrunAdi = x.Name,
                                        Fiyat = x.Price,
                                        Stok = x.Stock,
                                        Kategori = x.Category.Name
                                    }).ToList();

            dgvProducts.DataSource = filtrelenmisListe;
        }
    }
}