# Stok Takip Otomasyonu

İşletmelerin envanterlerini, ürün giriş-çıkışlarını ve stok durumlarını yönetebilmeleri için geliştirdiğim bir masaüstü uygulamasıdır. Projede katmanlı mimari ve modern veritabanı yönetim araçları kullanılmıştır.

## 🚀 Öne Çıkan Özellikler

* **CRUD Yönetimi:** Ürün ekleme, listeleme, güncelleme ve silme (CRUD) işlemlerinin eksiksiz yönetimi.
* **Hızlı Arama ve Filtreleme:** Stoktaki ürünlerin kritik seviyelerine göre filtrelenmesi ve dinamik arama yapılması.
* **Güçlü Veritabanı Altyapısı:** Entity Framework Core (ORM) kullanılarak SQL Server ile optimize edilmiş veri ilişkileri.

## 🛠️ Kullanılan Teknolojiler

* **Platform & Arayüz:** C#, Windows Forms 
* **Veritabanı Teknolojileri:** Microsoft SQL Server, Entity Framework Core (EF Core)
* **Mimari:** Katmanlı Mimari (N-Tier Architecture)

## 💻 Kurulum ve Çalıştırma

1. Projeyi bilgisayarınıza klonlayın:
   `git clone https://github.com/kullaniciadi/StokTakipProjesi.git`
2. Visual Studio 2022 ile solution dosyasını (.sln) açın.
3. Veritabanı bağlantı ayarınızı (Connection String) kendi yerel SQL Server'ınıza göre güncelleyin.
4. Veritabanı tablolarını oluşturmak için Package Manager Console üzerinden `Update-Database` komutunu çalıştırın.
5. Projeyi derleyip başlatın.

**🔑 Test Giriş Bilgileri:**
Uygulamayı ilk kez çalıştırdığınızda veritabanı boşsa, sistem test edebilmeniz için otomatik olarak aşağıdaki varsayılan yönetici hesabını oluşturacaktır:
* **Kullanıcı Adı:** admin
* **Şifre:** 1234
