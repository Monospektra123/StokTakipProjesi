using StokTakip.DataAccess;
using StokTakip.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StokTakip.UI.WinForms
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }
        StokTakipContext context = new StokTakipContext();
        private void SaleForm_Load(object sender, EventArgs e)
        {
            try
            {
                VerileriYukle();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
            }
        }
        void VerileriYukle()
        {
            var musteriler = context.Customers.Select(x => new { x.Id, x.Name }).ToList();
            cmbCustomer.DataSource = musteriler;
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "Id";
            cmbCustomer.SelectedIndex = -1;
            var urunler = context.Products.Select(x => new { x.Id, x.Name }).ToList();
            cmbProduct.DataSource = urunler;
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "Id";
            cmbProduct.SelectedIndex = -1;
        }
        void Listele()
        {
            var satislar = context.Sales
                .Include(s => s.Customer)
                .Include(s => s.Product)
                .Select(x => new
                {
                    x.Id,
                    Musteri = x.Customer.Name,
                    Urun = x.Product.Name,
                    Adet = x.Quantity,
                    ToplamTutar = x.TotalPrice,
                    Tarih = x.Date
                })
                .OrderByDescending(x => x.Tarih)
                .ToList();

            dgvSales.DataSource = satislar;
        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue == null || cmbProduct.SelectedValue == null || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }
            int urunId = (int)cmbProduct.SelectedValue;
            int musteriId = (int)cmbCustomer.SelectedValue;
            int adet = int.Parse(txtQuantity.Text);
            var secilenUrun = context.Products.Find(urunId);
            if (secilenUrun == null) return;
            if (secilenUrun.Stock < adet)
            {
                MessageBox.Show($"Yetersiz Stok! Mevcut Stok: {secilenUrun.Stock}");
                return;
            }
            decimal toplamTutar = secilenUrun.Price * adet;
            Sale yeniSatis = new Sale();
            yeniSatis.CustomerId = musteriId;
            yeniSatis.ProductId = urunId;
            yeniSatis.Quantity = adet;
            yeniSatis.TotalPrice = toplamTutar;
            yeniSatis.Date = DateTime.Now;
            secilenUrun.Stock = secilenUrun.Stock - adet;
            context.Sales.Add(yeniSatis);
            context.SaveChanges();
            MessageBox.Show($"Satış Başarılı! Toplam Tutar: {toplamTutar} TL");
            lblTotal.Text = $"Son Satış: {toplamTutar} TL";
            Listele();
            txtQuantity.Clear();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}