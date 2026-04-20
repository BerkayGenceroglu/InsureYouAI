# 🛡️ InsureYouAI

<p align="center">
  <img src="https://img.shields.io/badge/Platform-ASP.NET%20Core%20MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" />
  <img src="https://img.shields.io/badge/Frontend-HTML%20%2F%20CSS%20%2F%20JS-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black" />
  <img src="https://img.shields.io/badge/AI-Powered-FF6F00?style=for-the-badge&logo=openai&logoColor=white" />
  <img src="https://img.shields.io/badge/License-MIT-blue?style=for-the-badge" />
</p>

<p align="center">
  <strong>InsureYouAI</strong>, yapay zeka destekli akıllı bir sigorta danışmanlık platformudur.<br/>
  Kullanıcıların ihtiyaçlarına özel sigorta önerileri almasını, poliçelerini yönetmesini ve AI chatbot üzerinden anlık destek almasını sağlar.
</p>

---

## 📋 İçindekiler

- [Özellikler](#-özellikler)
- [Teknoloji Yığını](#-teknoloji-yığını)
- [Kurulum](#-kurulum)
- [Proje Yapısı](#-proje-yapısı)
- [Sayfalar ve Ekranlar](#-sayfalar-ve-ekranlar)
- [Katkıda Bulunma](#-katkıda-bulunma)
- [Lisans](#-lisans)

---

## ✨ Özellikler

- 🤖 **AI Destekli Chatbot** — Kullanıcıların sigorta hakkında sorularını anlık olarak yanıtlayan yapay zeka asistanı
- 📊 **Kişisel Sigorta Tavsiyesi** — Kullanıcı profili ve ihtiyaçlarına göre özelleştirilmiş sigorta önerileri
- 📄 **Poliçe Yönetimi** — Mevcut sigorta poliçelerini görüntüleme, karşılaştırma ve takip etme
- 🔐 **Güvenli Kullanıcı Kimlik Doğrulama** — Kayıt / Giriş sistemi ile kişisel hesap yönetimi
- 📱 **Responsive Tasarım** — Mobil, tablet ve masaüstü cihazlara uyumlu arayüz
- 📬 **İletişim Formu** — Kullanıcıların destek ekibiyle iletişim kurmasını sağlayan bölüm

---

## 🛠 Teknoloji Yığını

| Katman | Teknoloji |
|---|---|
| **Backend** | ASP.NET Core MVC (C#) |
| **Frontend** | HTML5, CSS3, JavaScript |
| **Yapay Zeka** | OpenAI API / Gemini API |
| **Veritabanı** | Entity Framework Core / SQL Server |
| **Kimlik Doğrulama** | ASP.NET Core Identity |
| **Paket Yönetimi** | NuGet |

---

## 🚀 Kurulum

### Gereksinimler

- [.NET 8 SDK](https://dotnet.microsoft.com/download) veya üzeri
- [Visual Studio 2022](https://visualstudio.microsoft.com/) veya [VS Code](https://code.visualstudio.com/)
- SQL Server (LocalDB veya full instance)
- OpenAI / Gemini API Key (AI chatbot için)

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
       "OpenAI": "YOUR_API_KEY_HERE"
     }
   }
   ```

3. **Veritabanı migration'larını uygulayın:**
   ```bash
   dotnet ef database update
   ```

4. **Uygulamayı çalıştırın:**
   ```bash
   dotnet run --project InsureYouAI
   ```

5. Tarayıcınızda `https://localhost:5001` adresini açın.

---

## 📁 Proje Yapısı

```
InsureYouAI/
│
├── Controllers/                  # MVC Controller'ları
│   ├── HomeController.cs         # Ana sayfa ve genel rotalar
│   ├── AccountController.cs      # Giriş / Kayıt işlemleri
│   ├── InsuranceController.cs    # Sigorta işlemleri
│   └── ChatController.cs         # AI chatbot endpoint'leri
│
├── Models/                       # Veri modelleri
│   ├── User.cs
│   ├── Policy.cs
│   └── ChatMessage.cs
│
├── Views/                        # Razor View dosyaları
│   ├── Home/
│   │   ├── Index.cshtml          # Ana Sayfa
│   │   └── About.cshtml          # Hakkımızda
│   ├── Account/
│   │   ├── Login.cshtml          # Giriş Sayfası
│   │   └── Register.cshtml       # Kayıt Sayfası
│   ├── Insurance/
│   │   ├── Index.cshtml          # Sigorta Listesi
│   │   ├── Detail.cshtml         # Poliçe Detayı
│   │   └── Recommend.cshtml      # AI Öneri Sayfası
│   ├── Chat/
│   │   └── Index.cshtml          # AI Chatbot Sayfası
│   └── Shared/
│       ├── _Layout.cshtml        # Genel Sayfa Şablonu
│       └── _NavBar.cshtml        # Navigasyon Bileşeni
│
├── wwwroot/                      # Statik dosyalar
│   ├── css/                      # Stil dosyaları
│   ├── js/                       # JavaScript dosyaları
│   └── images/                   # Görseller
│
├── appsettings.json              # Uygulama yapılandırması
└── Program.cs                    # Uygulama giriş noktası
```

---

## 📄 Sayfalar ve Ekranlar

### 🏠 Ana Sayfa — `Home/Index`
Uygulamanın giriş sayfasıdır. Kullanıcılara InsureYouAI'nin sunduğu hizmetlerin kısa bir özeti, öne çıkan özellikler (AI chatbot, öneri sistemi, poliçe yönetimi) ve hemen başlamak için yönlendirme butonları yer alır. Dinamik ve dikkat çekici bir hero bölümü ile misafir kullanıcıları karşılar.

---

### ℹ️ Hakkımızda — `Home/About`
Projenin amacını, geliştiriciler hakkında bilgileri ve platformun vizyonunu anlatan tanıtım sayfasıdır. InsureYouAI'nin neden geliştirildiğini ve kullanıcılara nasıl değer katmayı hedeflediğini açıklar.

---

### 🔑 Giriş Sayfası — `Account/Login`
Kayıtlı kullanıcıların platforma erişim sağladığı sayfadır. E-posta ve şifre alanları içerir. Hatalı giriş denemelerinde kullanıcıya anlamlı hata mesajları gösterilir. Ayrıca hesabı olmayan kullanıcılar için kayıt sayfasına yönlendirme bağlantısı bulunur.

---

### 📝 Kayıt Sayfası — `Account/Register`
Yeni kullanıcıların sisteme dahil olmasını sağlayan formdur. Ad, soyad, e-posta ve şifre gibi temel bilgilerin yanı sıra ileride AI önerilerini kişiselleştirmek için bazı ek profil bilgileri de istenebilir. Form doğrulama (validation) hem istemci tarafında hem sunucu tarafında uygulanmıştır.

---

### 🛡️ Sigorta Listesi — `Insurance/Index`
Sistemde mevcut bulunan tüm sigorta ürünlerinin (sağlık, araç, konut, seyahat vb.) listelendiği sayfadır. Her ürün kart formatında gösterilir; ürün adı, kapsamı ve fiyat aralığı gibi bilgileri içerir. Kullanıcılar bu sayfadan detay sayfasına veya öneri motoruna geçiş yapabilir.

---

### 📋 Poliçe Detay Sayfası — `Insurance/Detail`
Seçilen sigorta ürününün tüm ayrıntılarının listelendiği sayfadır. Kapsam detayları, prim tutarları, dışlamalar ve öne çıkan avantajlar bu ekranda görüntülenir. Kullanıcı poliçeyi değerlendirmek için buradan AI asistanına soru sorabilir ya da teklif talebinde bulunabilir.

---

### 🤖 AI Öneri Sistemi — `Insurance/Recommend`
Kullanıcının yanıtladığı kısa bir anket veya profil bilgilerine dayanarak yapay zekanın en uygun sigorta ürünlerini önerdiği sayfadır. Öneri sonuçları kart formatında sıralanır; her öneri için kısa bir gerekçe ve eşleşme skoru gösterilebilir. Bu sayfa uygulamanın temel AI özelliğini ön plana çıkarır.

---

### 💬 AI Chatbot — `Chat/Index`
Kullanıcıların sigorta ile ilgili her türlü sorusunu gerçek zamanlı olarak yapay zeka destekli asistana sorabildiği sohbet arayüzüdür. Mesajlar baloncuk (bubble) formatında görüntülenir. Kullanıcı mesajı gönderir, AI yanıtı birkaç saniye içinde oluşturulup ekrana yansıtılır. Önceki konuşmalar oturum boyunca saklanabilir.

---

### 📬 İletişim — `Home/Contact` *(varsa)*
Kullanıcıların platform hakkında soru, öneri veya destek talebi iletebileceği form sayfasıdır. Ad, e-posta ve mesaj alanlarını içerir. Form gönderimi sonrası kullanıcıya onay bildirimi gösterilir.

---

## 🖼️ Ekran Görüntüleri

> 📌 *Ekran görüntüleri buraya eklenebilir.*

---

## 🤝 Katkıda Bulunma

Katkılarınızı memnuniyetle karşılıyoruz! Lütfen aşağıdaki adımları izleyin:

1. Bu repoyu fork'layın
2. Yeni bir branch oluşturun: `git checkout -b feature/yeni-ozellik`
3. Değişikliklerinizi commit edin: `git commit -m "feat: yeni özellik eklendi"`
4. Branch'inizi push edin: `git push origin feature/yeni-ozellik`
5. Bir Pull Request açın

---

## 👤 Geliştirici

**Berkay Gençeroğlu**

[![GitHub](https://img.shields.io/badge/GitHub-BerkayGenceroglu-181717?style=flat&logo=github)](https://github.com/BerkayGenceroglu)

---

## 📜 Lisans

Bu proje [MIT Lisansı](LICENSE) kapsamında lisanslanmıştır.

---

<p align="center">
  <sub>InsureYouAI — Yapay Zeka ile Sigorta Dünyasını Kolaylaştırıyoruz 🛡️</sub>
</p>
