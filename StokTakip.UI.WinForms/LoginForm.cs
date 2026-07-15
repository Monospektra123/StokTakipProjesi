using Microsoft.EntityFrameworkCore;
using StokTakip.DataAccess;
using StokTakip.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StokTakip.UI.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string kadi = txtUsername.Text.Trim();
            string sifre = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(kadi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var context = new StokTakipContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == kadi && u.Password == sifre);
                if (user != null)
                {
                    MessageBox.Show($"Hoşgeldin {user.Username}!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 anaForm = new Form1();
                    this.Hide();
                    anaForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            using (var context = new StokTakipContext())
            {
                try
                {
                    context.Database.EnsureCreated();
                    if (!context.Users.Any())
                    {
                        var adminUser = new User { Username = "admin", Password = "1234", Role = "Admin" };
                        context.Users.Add(adminUser);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}