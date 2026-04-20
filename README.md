<h1 align="center">🛡️ InsureYouAI — Yapay Zekâ Destekli Sigorta Danışmanlık Platformu</h1>

<p align="center">
  ASP.NET Core MVC altyapısı ile geliştirilmiş, yapay zekâ entegrasyonu sayesinde kullanıcıların ihtiyaçlarına özel sigorta önerileri alabildiği, poliçe karşılaştırma, AI destekli chatbot, kullanıcı profil yönetimi ve admin paneli gibi tam özellikli modülleri bünyesinde barındıran modern, güvenli ve ölçeklenebilir bir web uygulamasıdır.
</p>

---

## 🧾 Proje Tanıtımı

**InsureYouAI**, kullanıcıların sigorta dünyasında bilinçli kararlar almasını kolaylaştırmak amacıyla geliştirilmiş yapay zekâ destekli bir sigorta danışmanlık platformudur.

Bu proje sayesinde:

- Kullanıcılar **Sağlık, Araç, Konut, Seyahat** gibi sigorta kategorilerinde ürünleri keşfedebilir,
- **AI öneri motoru** aracılığıyla kendi ihtiyaçlarına en uygun poliçeyi bulabilir,
- **AI Chatbot** üzerinden sigorta ile ilgili her sorusuna anlık yanıt alabilir,
- Kayıt ve giriş sistemi ile kişisel hesaplarını güvenle yönetebilir,
- Yöneticiler **Admin Paneli** üzerinden kullanıcıları ve içerikleri merkezi olarak yönetebilir,
- Tüm formlar **ModelState doğrulaması** ile sunucu tarafında korunur,
- Uygulama tamamen **responsive** tasarımıyla mobil ve masaüstünde sorunsuz çalışır.

---

## 🚀 Kullanılan Teknolojiler

| Katman | Teknolojiler |
|--------|-------------|
| Backend | `ASP.NET Core MVC`, `C#`, `ASP.NET Core Identity` |
| Yapay Zekâ | `OpenAI API` / `Gemini API`, `REST HTTP` |
| Frontend | `HTML5`, `CSS3`, `JavaScript`, `Bootstrap`, `jQuery` |
| Veritabanı | `MS SQL Server`, `Entity Framework Core`, `Code First Migration` |
| Kimlik Doğrulama | `ASP.NET Core Identity`, `Cookie Auth` |
| Yetkilendirme | `Role-Based Authorization`, `[Authorize]` |
| Doğrulama | `ModelState`, `Data Annotations` |
| IDE | `Visual Studio 2022` |

---

## 🧱 Proje Mimarisi

<pre>
InsureYouAI/
│
├── InsureYouAI.sln
│
└── InsureYouAI/
    ├── Controllers/
    │   ├── HomeController.cs            → Ana Sayfa, Hakkımızda, İletişim
    │   ├── AccountController.cs         → Kayıt, Giriş, Çıkış, Profil
    │   ├── InsuranceController.cs       → Sigorta Listesi, Detay, Öneri
    │   ├── ChatController.cs            → AI Chatbot
    │   └── AdminController.cs           → Kullanıcı & İçerik Yönetimi
    │
    ├── Models/
    │   ├── AppUser.cs                   → Identity kullanıcı modeli
    │   ├── InsuranceProduct.cs          → Sigorta ürün modeli
    │   ├── ChatMessage.cs               → Chatbot mesaj modeli
    │   └── ViewModels/
    │       ├── RegisterViewModel.cs
    │       ├── LoginViewModel.cs
    │       ├── InsuranceRecommendViewModel.cs
    │       └── ChatViewModel.cs
    │
    ├── Services/
    │   ├── IAIService.cs                → AI servis arayüzü
    │   ├── AIService.cs                 → OpenAI/Gemini API entegrasyonu
    │   ├── IInsuranceService.cs         → Sigorta servis arayüzü
    │   └── InsuranceService.cs          → Öneri & filtreleme mantığı
    │
    ├── Data/
    │   └── AppDbContext.cs              → EF Core DbContext
    │
    ├── Views/
    │   ├── Home/
    │   │   ├── Index.cshtml             → Ana Sayfa
    │   │   ├── About.cshtml             → Hakkımızda
    │   │   └── Contact.cshtml           → İletişim
    │   ├── Account/
    │   │   ├── Register.cshtml          → Kayıt Ol
    │   │   ├── Login.cshtml             → Giriş Yap
    │   │   └── Profile.cshtml           → Profil Yönetimi
    │   ├── Insurance/
    │   │   ├── Index.cshtml             → Sigorta Ürün Listesi
    │   │   ├── Detail.cshtml            → Poliçe Detay
    │   │   └── Recommend.cshtml         → AI Öneri Sistemi
    │   ├── Chat/
    │   │   └── Index.cshtml             → AI Chatbot
    │   └── Admin/
    │       ├── Users.cshtml             → Kullanıcı Listesi
    │       └── Dashboard.cshtml         → Admin Paneli
    │
    ├── wwwroot/
    │   ├── css/
    │   ├── js/
    │   └── images/
    │
    ├── appsettings.json
    └── Program.cs
</pre>

---

## 🏠 Ana Sayfa (Home / Index)

Uygulamanın giriş kapısıdır. Kullanıcıları karşılayan dinamik bir **hero bölümü**, InsureYouAI'nin sunduğu başlıca özelliklerin (AI Chatbot, Öneri Motoru, Poliçe Karşılaştırma) tanıtım kartları ve hemen başlamak için yönlendirme butonları yer alır. Giriş yapmamış kullanıcılar doğrudan kayıt veya giriş sayfasına yönlendirilir.

> Ana Sayfa — Hero Bölümü ve Özellik Kartları:

<!-- Ana sayfa ekran görüntüsü buraya eklenecek -->

---

## ℹ️ Hakkımızda (Home / About)

Projenin amacını, misyonunu ve geliştirici bilgilerini içeren tanıtım sayfasıdır. InsureYouAI'nin neden geliştirildiği, hangi problemi çözdüğü ve yapay zekânın sigorta sektörüne katkıları burada anlatılır.

> Hakkımızda Sayfası:

<!-- Hakkımızda ekran görüntüsü buraya eklenecek -->

---

## 📬 İletişim (Home / Contact)

Kullanıcıların destek ekibiyle iletişime geçebileceği form sayfasıdır. **Ad, E-posta ve Mesaj** alanlarından oluşur. Tüm alanlar ModelState ile doğrulanır; form gönderimi sonrasında kullanıcıya başarı bildirimi gösterilir.

> İletişim Formu:

<!-- İletişim ekran görüntüsü buraya eklenecek -->

---

## 🔐 Kimlik Doğrulama

### 📝 Kayıt Ol (Account / Register)

Kullanıcıların sisteme dahil olabilmesi için **Ad, Soyad, E-posta ve Şifre** bilgilerini girdiği formdur. Tüm alanlar hem istemci hem sunucu tarafında ModelState ile doğrulanır. Şifreler ASP.NET Core Identity tarafından otomatik olarak PBKDF2 algoritmasıyla hash'lenir.

> Kayıt Formu:

<!-- Kayıt ekran görüntüsü buraya eklenecek -->

---

### 🔑 Giriş Yap (Account / Login)

Kayıtlı kullanıcıların **E-posta ve Şifre** ile platforma eriştiği güvenli giriş ekranıdır. Hatalı girişlerde kullanıcıya anlamlı hata mesajları gösterilir. Hesabı olmayan kullanıcılar için kayıt sayfasına yönlendirme bağlantısı bulunur. Çok sayıda başarısız girişte hesap otomatik olarak kilitlenir.

> Giriş Ekranı:

<!-- Giriş ekran görüntüsü buraya eklenecek -->

---

### 👤 Profil Yönetimi (Account / Profile)

Kullanıcının kişisel bilgilerini (ad, soyad, e-posta) görüntüleyip güncelleyebildiği sayfadır. Şifre değiştirme işlemi de bu ekran üzerinden yapılabilir. Tüm değişiklikler kaydedilmeden önce doğrulama kontrolünden geçirilir.

> Profil Sayfası:

<!-- Profil ekran görüntüsü buraya eklenecek -->

---

## 🛡️ Sigorta Modülü

### 📋 Sigorta Ürün Listesi (Insurance / Index)

Sistemde mevcut tüm sigorta ürünlerinin kart formatında listelendiği sayfadır. Her kart; **ürün adı, sigorta kategorisi (Sağlık, Araç, Konut, Seyahat vb.), kısa açıklama ve fiyat aralığı** bilgilerini içerir. Kullanıcılar kategori filtreleme ile aradıkları ürüne hızlıca ulaşabilir.

> Sigorta Ürün Listesi:

<!-- Sigorta listesi ekran görüntüsü buraya eklenecek -->

---

### 🔍 Poliçe Detay (Insurance / Detail)

Seçilen sigorta ürününe ait tüm detayların görüntülendiği sayfadır. **Kapsam içerikleri, prim tutarları, avantajlar ve dışlamalar** bu ekranda listelenir. Kullanıcı ürünü değerlendirirken doğrudan AI Chatbot'a soru sorabilir ya da AI Öneri Motoru'na geçiş yapabilir.

> Poliçe Detay Sayfası:

<!-- Poliçe detay ekran görüntüsü buraya eklenecek -->

---

### 🤖 AI Öneri Sistemi (Insurance / Recommend)

InsureYouAI'nin temel yapay zekâ özelliğini barındıran sayfadır. Kullanıcıdan **yaş, bütçe, aile durumu ve öncelikli ihtiyaçlar** gibi kısa sorular aracılığıyla bilgi toplanır. Bu verilere dayanarak yapay zekâ en uygun sigorta ürünlerini sıralar ve her öneri için kısa bir gerekçe sunar.

### Çalışma Akışı

```
Kullanıcı Anketi Doldurur
         │
         ▼
  ASP.NET Core Controller Verileri Alır
         │
         ▼
  AIService → OpenAI / Gemini API'ye HTTP İsteği
         │
         ▼
  Yapay Zekâ Kullanıcı Profilini Analiz Eder
         │
         ▼
  En Uygun Sigorta Ürünleri Sıralanır
         │
         ▼
  Kart Formatında Kullanıcıya Sunulur ✅
```

> AI Öneri Anketi:

<!-- Öneri anketi ekran görüntüsü buraya eklenecek -->

> AI Öneri Sonuçları:

<!-- Öneri sonuçları ekran görüntüsü buraya eklenecek -->

---

## 💬 AI Chatbot (Chat / Index)

Kullanıcıların sigorta ile ilgili her türlü sorusunu gerçek zamanlı olarak yapay zekâ destekli asistana sorabildiği sohbet arayüzüdür. Mesajlar **baloncuk (bubble) formatında** görüntülenir; kullanıcı mesaj gönderir, AI yanıtı birkaç saniye içinde oluşturulup ekrana yansıtılır. Konuşma geçmişi oturum boyunca korunur.

### Çalışma Akışı

```
Kullanıcı Mesaj Yazar ve Gönderir
         │
         ▼
  ChatController Mesajı Alır
         │
         ▼
  AIService → OpenAI / Gemini API'ye Gönderilir
         │
         ▼
  Yapay Zekâ Sigorta Bağlamında Yanıt Üretir
         │
         ▼
  Yanıt Ekranda Gerçek Zamanlı Gösterilir 💬
```

> AI Chatbot Arayüzü:

<!-- Chatbot ekran görüntüsü buraya eklenecek -->

> Chatbot Sigorta Sorusu Yanıtı:

<!-- Chatbot yanıt ekran görüntüsü buraya eklenecek -->

---

## 👥 Admin Paneli

### 📊 Dashboard (Admin / Dashboard)

Yöneticilerin sisteme genel bakış yapabildiği özet paneldir. Toplam kullanıcı sayısı, aktif poliçe sayısı ve chatbot kullanım istatistikleri bu ekranda görüntülenebilir.

> Admin Dashboard:

<!-- Admin dashboard ekran görüntüsü buraya eklenecek -->

---

### 👤 Kullanıcı Yönetimi (Admin / Users)

Admin paneli üzerinden tüm kayıtlı kullanıcılar listelenir. Her kullanıcı için **ad, e-posta, kayıt tarihi ve rol bilgisi** görüntülenebilir. Yöneticiler kullanıcılara rol atayabilir, hesaplarını düzenleyebilir veya silebilir.

> Kullanıcı Listesi:

<!-- Kullanıcı listesi ekran görüntüsü buraya eklenecek -->

### Roller

| Rol | Yetkiler |
|-----|----------|
| `Admin` | Tüm kullanıcıları ve içerikleri yönetebilir, istatistikleri görebilir |
| `User` | Kendi profili, sigorta önerileri ve chatbot erişimi |

---

## 🔐 Kimlik Doğrulama Akışı

```
Kullanıcı Kayıt Formunu Doldurur
            │
            ▼ ModelState Kontrolü
  ASP.NET Core Identity ile Kayıt
            │
            ▼
  Kullanıcıya Varsayılan "User" Rolü Atanır
            │
            ▼
        Sisteme Giriş Yapılabilir ✅
            │
      ┌─────┴──────┐
      ▼            ▼
   Admin          User
  Paneli       Sigorta Modülü
      │              │
  Kullanıcı    AI Öneri & Chatbot
  Yönetimi     Poliçe Keşfet
```

---

## 🛡️ Güvenlik Özellikleri

| Özellik | Açıklama |
|---------|----------|
| Şifre Hash'leme | ASP.NET Core Identity ile otomatik PBKDF2 hash |
| Giriş Kilitleme | Başarısız deneme limitinde hesap kilitlenir (Lockout) |
| Role-Based Authorization | Controller ve Action bazında `[Authorize(Roles="")]` koruması |
| ModelState Doğrulama | Tüm formlarda sunucu tarafı doğrulama zorunluluğu |
| HTTPS | Üretim ortamında HTTPS yönlendirmesi aktif |
| API Key Güvenliği | AI API anahtarları `appsettings.json` üzerinden yönetilir |

---

## ⚙️ Kurulum

### Gereksinimler

- [.NET 8 SDK](https://dotnet.microsoft.com/download) veya üzeri
- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- SQL Server (LocalDB veya full instance)
- OpenAI / Gemini API Key

### Adımlar

1. **Repoyu klonlayın:**
   ```bash
   git clone https://github.com/BerkayGenceroglu/InsureYouAI.git
   cd InsureYouAI
   ```

2. **`appsettings.json` dosyasını yapılandırın:**
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=InsureYouAI;Trusted_Connection=True;"
     },
     "ApiKeys": {
       "OpenAI": "YOUR_OPENAI_API_KEY"
     }
   }
   ```

3. **Veritabanı migration'larını uygulayın:**
   ```bash
   dotnet ef database update
   ```

4. **Uygulamayı başlatın:**
   ```bash
   dotnet run --project InsureYouAI
   ```

5. Tarayıcıda `https://localhost:5001` adresini açın.

---

## 📄 Lisans

Bu proje açık kaynaklıdır. Herhangi bir ticari veya kişisel amaçla kullanılabilir. Tamamen proje geliştirme amacıyla oluşturulmuştur.

---

## 📫 İletişim

Proje hakkında sorularınız, önerileriniz ya da katkı istekleriniz için benimle iletişime geçebilirsiniz:

- 🔗 GitHub: [@BerkayGenceroglu](https://github.com/BerkayGenceroglu)

---

**İyi kodlamalar! 🚀**

---
