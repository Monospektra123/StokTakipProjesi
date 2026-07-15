using StokTakip.DataAccess;
using StokTakip.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StokTakip.UI.WinForms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        StokTakipContext context = new StokTakipContext();
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var musteriler = context.Customers
                .Select(x => new
                {
                    x.Id,
                    AdSoyad = x.Name,
                    Telefon = x.PhoneNumber,
                    Email = x.Email
                }).ToList();

            dgvCustomers.DataSource = musteriler;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Ad Soyad boş geçilemez!");
                return;
            }
            var musteri = new Customer();
            musteri.Name = txtName.Text;
            musteri.PhoneNumber = txtPhone.Text;
            musteri.Email = txtEmail.Text;
            context.Customers.Add(musteri);
            context.SaveChanges();
            MessageBox.Show("Müşteri Eklendi!");
            Listele();
            Temizle();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int id = (int)dgvCustomers.SelectedRows[0].Cells["Id"].Value;
                var silinecek = context.Customers.Find(id);
                context.Customers.Remove(silinecek);
                context.SaveChanges();
                MessageBox.Show("Müşteri Silindi!");
                Listele();
                Temizle();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int id = (int)dgvCustomers.SelectedRows[0].Cells["Id"].Value;
                var guncellenecek = context.Customers.Find(id);
                guncellenecek.Name = txtName.Text;
                guncellenecek.PhoneNumber = txtPhone.Text;
                guncellenecek.Email = txtEmail.Text;
                context.SaveChanges();
                MessageBox.Show("Müşteri Güncellendi!");
                Listele();
                Temizle();
            }
        }
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvCustomers.Rows[e.RowIndex];
                txtName.Text = row.Cells["AdSoyad"].Value.ToString();
                txtPhone.Text = row.Cells["Telefon"].Value != null ? row.Cells["Telefon"].Value.ToString() : "";
                txtEmail.Text = row.Cells["Email"].Value != null ? row.Cells["Email"].Value.ToString() : "";
            }
        }
        void Temizle()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtSearch.Text;

            var filtrelenmisMusteriler = context.Customers
                .Where(x => x.Name.Contains(aranan)) // İsme göre ara
                .Select(x => new
                {
                    x.Id,
                    AdSoyad = x.Name,
                    Telefon = x.PhoneNumber,
                    Email = x.Email
                }).ToList();

            dgvCustomers.DataSource = filtrelenmisMusteriler;
        }
    }
}
