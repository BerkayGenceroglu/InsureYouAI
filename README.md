<h1 align="center">🛡️ InsureYouAI - Yapay Zeka Destekli Sigorta Yönetim Sistemi</h1>

<p align="center">
  Sigorta sektörünün dijital dönüşümünü hızlandıran, ASP.NET Core MVC ve Yapay Zeka entegrasyonu ile geliştirilmiş kapsamlı bir sigorta yönetim platformu
</p>

---

## 🧾 Proje Tanıtımı

**InsureYouAI**, sigorta sektörü için geliştirilmiş, **yapay zeka destekli** ve **modern web teknolojileriyle** tasarlanmış bir **web tabanlı yönetim sistemidir**.

Bu proje sayesinde:

**Kullanıcılar:**
- Sigorta ürünlerini kolayca inceleyebilir ve online teklif alabilir
- Yapay zeka destekli chatbot ile anlık sigorta danışmanlığı alabilir
- Poliçelerini takip edebilir ve yönetebilir
- Hasar bildirimi oluşturabilir ve süreçleri takip edebilir
- İletişim formu ile işletmeye kolayca ulaşabilir

**Yöneticiler:**
- Sigorta ürünlerini ve poliçeleri merkezi bir panelden yönetebilir
- Yapay zeka modülü aracılığıyla müşteri taleplerine otomatik yanıt üretebilir
- Tüm site içeriğini kolayca güncelleyebilir
- Kullanıcı ve müşteri verilerini güvenli şekilde yönetebilir

Proje, hem **kullanıcı deneyimini artırmayı** hem de **sigorta operasyonlarını dijitalleştirerek yapay zeka ile optimize etmeyi** hedeflemektedir.

**InsureYouAI**, geliştiriciler için ASP.NET Core MVC, Yapay Zeka API entegrasyonu, modern JavaScript ve HTML/CSS teknolojilerini bir arada sunar.

---

## 🚀 Kullanılan Teknolojiler

| Katman | Teknolojiler |
|--------|-------------|
| **Backend** | `ASP.NET Core MVC`, `C#`, `Entity Framework Core`, `MSSQL Server` |
| **Frontend** | `HTML5`, `CSS3`, `Bootstrap`, `JavaScript`, `jQuery`, `AJAX` |
| **Yapay Zeka** | `AI API Entegrasyonu`, `Chatbot`, `Doğal Dil İşleme` |
| **Mimari** | `MVC Pattern`, `Repository Pattern`, `Dependency Injection` |

---

## 🧱 Proje Yapısı

```
InsureYouAI/
│
├── 📁 InsureYouAI/                       → Ana Proje
│   ├── Controllers/                      → MVC Controller'lar
│   ├── Models/                           → Veri Modelleri
│   ├── Views/                            → Razor Views
│   ├── wwwroot/                          → Statik Dosyalar
│   │   ├── css/                          → Stil Dosyaları
│   │   ├── js/                           → JavaScript Dosyaları
│   │   └── images/                       → Görseller
│   └── appsettings.json                  → Uygulama Ayarları
│
├── InsureYouAI.sln                       → Solution Dosyası
├── .gitignore
└── .gitattributes
```

---

## ✨ Temel Özellikler

### 🎯 Kullanıcı Tarafı Özellikleri

- 🛡️ **Sigorta Ürün Listeleme** - Tüm sigorta ürünlerini görüntüleme ve filtreleme
- 🤖 **AI Destekli Chatbot** - Yapay zeka ile anlık sigorta danışmanlığı
- 💬 **Online Teklif Alma** - Kullanıcı dostu form ile hızlı sigorta teklifi
- 📋 **Poliçe Takibi** - Aktif poliçeleri görüntüleme ve yönetme
- 🔔 **Hasar Bildirimi** - Online hasar bildirimi ve süreç takibi
- 📞 **İletişim Formu** - Hızlı mesaj gönderme ve destek talebi
- 🔐 **Üyelik Sistemi** - Güvenli kayıt olma ve giriş yapma

### 🛡️ Admin Panel Özellikleri

- 📊 **Dashboard** - Genel istatistikler ve özet görünüm
- 📦 **Ürün Yönetimi** - Sigorta ürünleri CRUD işlemleri
- 👥 **Kullanıcı Yönetimi** - Müşteri ve kullanıcı takibi
- 📝 **Poliçe Yönetimi** - Tüm poliçeleri listeleme ve güncelleme
- 🤖 **AI Modül Yönetimi** - Chatbot yanıtlarını ve AI davranışını yönetme
- 🎨 **İçerik Yönetimi** - Site içeriklerini düzenleme
- 📱 **İletişim Takibi** - Kullanıcı mesajlarını görüntüleme

---

## 🏗 Mimari Yapı

```
┌─────────────────────────────────────────┐
│   📱 Presentation Layer (MVC Views)    │
│   - UI/UX                               │
│   - Razor Views                         │
│   - JavaScript & AJAX                   │
└──────────────┬──────────────────────────┘
               │
               ↓
┌─────────────────────────────────────────┐
│   🧠 Business Layer (Controllers)       │
│   - İş Mantığı                          │
│   - AI Entegrasyonu                     │
│   - Request/Response Yönetimi           │
└──────────────┬──────────────────────────┘
               │
               ↓
┌─────────────────────────────────────────┐
│   🗄️ Data Layer                         │
│   - Entity Framework Core               │
│   - Repository Pattern                  │
│   - MSSQL Server                        │
└─────────────────────────────────────────┘
```

---

## 🤖 Yapay Zeka Entegrasyonu

**InsureYouAI**'ın en öne çıkan özelliği, sigorta danışmanlığı için entegre edilmiş yapay zeka modülüdür:

- 🧠 **Akıllı Chatbot** - Kullanıcıların sorularını anlık olarak yanıtlar
- 📊 **Teklif Analizi** - Kullanıcı verisine göre en uygun sigorta ürününü önerir
- 🔍 **Hasar Değerlendirmesi** - AI destekli ön hasar analizi
- 💬 **Doğal Dil Anlama** - Türkçe doğal dil işleme ile kullanıcı odaklı deneyim

---

## ⚙️ Kurulum ve Çalıştırma

### Gereksinimler

- .NET 8.0 SDK
- MSSQL Server
- Visual Studio 2022 veya VS Code

### Adımlar

```bash
# 1. Repoyu klonla
git clone https://github.com/BerkayGenceroglu/InsureYouAI.git

# 2. Proje dizinine git
cd InsureYouAI

# 3. appsettings.json dosyasını yapılandır
# ConnectionStrings ve AI API anahtarını ekle

# 4. Veritabanını oluştur
dotnet ef database update

# 5. Projeyi çalıştır
dotnet run
```

### appsettings.json Yapılandırması

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=InsureYouAI;Trusted_Connection=True;"
  },
  "AISettings": {
    "ApiKey": "YOUR_AI_API_KEY"
  }
}
```

---

## 👤 Geliştirici

**Berkay Genceroğlu**

- GitHub: [@BerkayGenceroglu](https://github.com/BerkayGenceroglu)
- LinkedIn: [Berkay Genceroğlu](https://www.linkedin.com/in/berkay-gencero%C4%9Flu-586b52331/)

---

## 📫 İletişim

Proje hakkında sorularınız, önerileriniz ya da katkı istekleriniz için benimle iletişime geçebilirsiniz:

- 📧 E-posta: **berkaygenceroglu6@gmail.com**
- 🔗 LinkedIn: [Berkay Genceroğlu](https://www.linkedin.com/in/berkay-gencero%C4%9Flu-586b52331/)

---

## 💬 Son Söz

Teşekkürler! Bu projeyi kullandığınız veya katkıda bulunduğunuz için memnuniyet duyarım.  
Her türlü geri bildirime açığım.

**İyi kodlamalar! 🚀**
