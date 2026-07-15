using StokTakip.DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StokTakip.UI.WinForms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        StokTakipContext context = new StokTakipContext();

        private void ReportForm_Load(object sender, EventArgs e)
        {
            IstatistikleriGetir();
            KritikStoklariGetir();
        }

        void IstatistikleriGetir()
        {
            // 1. Toplam Ürün Sayısı
            int urunSayisi = context.Products.Count();
            lblProductCount.Text = urunSayisi.ToString();

            // 2. Toplam Müşteri Sayısı
            int musteriSayisi = context.Customers.Count();
            lblCustomerCount.Text = musteriSayisi.ToString();

            // 3. Toplam Ciro (Kasadaki Para)
            // Eğer hiç satış yoksa hata vermesin diye (decimal?) kullandık
            decimal? toplamPara = context.Sales.Sum(x => (decimal?)x.TotalPrice);
            lblTotalRevenue.Text = (toplamPara ?? 0).ToString("C2"); // C2: Para birimi formatı (TL)

            // 4. Toplam Yapılan Satış İşlemi
            int satisIslemSayisi = context.Sales.Count();
            lblSaleCount.Text = satisIslemSayisi.ToString();
        }

        void KritikStoklariGetir()
        {
            // Stoğu 20'den az olan ürünleri bul ve listele
            // Bu, patronun "Hangi üründen sipariş vermeliyim?" sorusunun cevabıdır.
            var kritikUrunler = context.Products
                                .Where(x => x.Stock < 20)
                                .Select(x => new
                                {
                                    UrunAdi = x.Name,
                                    KalanStok = x.Stock,
                                    Fiyat = x.Price
                                })
                                .OrderBy(x => x.KalanStok) // En az kalan en üstte
                                .ToList();

            dgvCriticalStock.DataSource = kritikUrunler;
        }

        // Yanlış tıklamaları önlemek için boş metodlar (Gerekirse)
        private void label1_Click(object sender, EventArgs e) { }
    }
}
