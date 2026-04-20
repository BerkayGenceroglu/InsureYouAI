# 🛡️ InsureYouAI — Yapay Zeka Destekli Sigorta Yönetim Sistemi

> **ASP.NET Core MVC** ve **Yapay Zeka API Entegrasyonu** ile geliştirilmiş, modern ve kapsamlil bir sigorta yönetim platformu. Kullanıcı taraflı online sigorta deneyiminden yönetici paneline kadar tüm süreci dijitalleştirir.

---

## 🚀 Kullanılan Teknolojiler

| Katman | Teknolojiler |
|--------|-------------|
| **Backend** | ASP.NET Core MVC · C# · Entity Framework Core · MSSQL Server |
| **Frontend** | HTML5 · CSS3 · Bootstrap · JavaScript · jQuery · AJAX |
| **Yapay Zeka** | Anthropic Claude API · Eleven Labs AI · Tavily AI Web Tarama |
| **Mimari** | MVC Pattern · Repository Pattern · Dependency Injection · ASP.NET Identity |

---

## 🧱 Proje Yapısı

```
InsureYouAI/
├── Controllers/          → MVC Controller'lar
├── Models/               → Veri Modelleri & Entity'ler
├── Views/                → Razor Views (.cshtml)
├── Areas/Admin/          → Admin Panel (ayrı Area)
│   ├── Controllers/
│   └── Views/
└── wwwroot/
    ├── css/              → Stil Dosyaları
    ├── js/               → JavaScript & AJAX
    └── images/           → Statik Görseller
```

---

## 🏗️ Mimari Katman Diyagramı

```
┌─────────────────────────────────────────┐
│   📱 Presentation Layer (MVC Views)     │
│   Razor Views · Bootstrap UI · AJAX    │
└──────────────┬──────────────────────────┘
               ↓
┌─────────────────────────────────────────┐
│   🧠 Business Layer (Controllers)       │
│   İş Mantığı · AI Entegrasyonu         │
│   Request / Response Yönetimi          │
└──────────────┬──────────────────────────┘
               ↓
┌─────────────────────────────────────────┐
│   🗄️ Data Layer                         │
│   Entity Framework Core · Repository   │
│   MSSQL Server                         │
└─────────────────────────────────────────┘
```

---

# 👤 KULLANICI (UI) TARAFI

## 1. Ana Sayfa — `/Home/Index`

Projenin vitrin sayfasıdır. Ziyaretçilere şirketi ve hizmetleri modern bir tasarımla tanıtır.

**Bileşenler:**
- 🎯 **Hero Banner** — Tam ekran görsel, hızlı teklif formu ve CTA butonları
- 🛡️ **Öne Çıkan Sigorta Ürünleri** — Kasko, Sağlık, Konut, Trafik kartları
- 🤖 **AI Chatbot Widget** — Sayfaya entegre yapay zeka danışmanlık asistanı
- ⭐ **Müşteri Referansları** — Müşteri yorumları ve puanlamaları
- 📊 **İstatistik Bölümü** — Toplam poliçe sayısı, müşteri ve memnuniyet oranları
- 🛠️ **Hizmetler Özeti** — Sunulan sigorta hizmetlerinin kısa tanıtımı
- ℹ️ **Hakkımızda Özeti** — Şirket misyonu ve vizyonu

> 📸 Görseller: Ana sayfa hero, ürün kartları, chatbot, referanslar, istatistikler, footer bölümleri

---

## 2. Sigorta Ürünleri — `/Product/Index`

Sistemdeki tüm sigorta ürünlerini listeleyen sayfa.

**Özellikler:**
- Tüm ürünlerin kart görünümü (grid layout)
- Kategori etiketi (Kasko · Trafik · Sağlık · Konut vb.)
- Fiyat aralığı ve teklif özeti
- Ürün detay sayfasına yönlendirme butonu
- Filtreleme ve arama desteği

> 📸 Görseller: Ürün listeleme grid, filtre paneli, ürün kartı yapısı

---

## 3. Ürün Detay — `/Product/Detail/{id}`

Seçilen sigorta ürününün tüm ayrıntılarını sunan sayfa.

**Bileşenler:**
- 📋 Kapsam & Teminat detayları
- 💵 Prim bilgileri ve ödeme seçenekleri
- 📝 Kapsamlı ürün açıklaması
- ⭐ Önceki müşteri değerlendirmeleri ve yıldız puanları
- 🤖 **AI Ürün Karşılaştırma** — Yapay zeka destekli öneri ve karşılaştırma

> 📸 Görseller: Ürün detay üst bölümü, teminat tablosu, müşteri yorumları, AI öneri kartı

---

## 4. Online Teklif Al — `/Quote/Index`

Kullanıcıların kişisel ve araç/mülk bilgilerini girerek anlık sigorta teklifi aldığı form sayfası.

**Form Alanları:**
- 👤 Kişisel Bilgiler: Ad, Soyad, T.C. Kimlik No, Doğum Tarihi
- 📋 Sigorta Bilgileri: Sigorta türü, poliçe başlangıç tarihi
- 🚗 Ürüne Göre Dinamik Alanlar: Araç bilgileri veya mülk bilgileri
- 💰 Teminat Kapsamı Seçimi

> 📸 Görseller: Teklif formu üst bölüm, dinamik alan grupları

---

## 5. AI Chat Asistanı — Canlı Chatbot Widget

Tüm sayfalara entegre yapay zeka destekli sigorta danışmanlık asistanı.

**Özellikler:**
- 🤖 Türkçe doğal dil anlama (NLP)
- 💬 7/24 anlık yanıt sistemi
- 📊 Ürün karşılaştırma önerileri
- 🔍 Poliçe sorgulama ve bilgi alma
- Sohbet geçmişi ve bağlam takibi

> 📸 Görseller: Chatbot açık pencere, sohbet akışı, AI yanıt kartları

---

## 6. İletişim — `/Contact/Index`

Şirket iletişim bilgileri ve kullanıcı mesajlaşma formu.

**Bileşenler:**
- 📍 Şirket adres bilgisi
- 📞 Telefon & e-posta iletişim bilgileri
- 📝 İletişim Formu: İsim, E-posta, Konu, Mesaj alanları
- AJAX ile sayfa yenilenmeden gönderim

> 📸 Görseller: İletişim sayfası üst, form bölümü

---

## 7. Üyelik Sistemi — Kayıt & Giriş

**ASP.NET Identity** altyapısı ile güvenli kimlik doğrulama.

**Kayıt Formu (`/Account/Register`):**
- İsim, Soyisim, Kullanıcı Adı, E-posta, Şifre, Şifre Tekrar
- Şifreler hash'lenerek veritabanında saklanır

**Giriş Formu (`/Account/Login`):**
- Kullanıcı Adı, Şifre, Beni Hatırla (Remember Me)
- Rol bazlı yönlendirme (Admin / Kullanıcı)

---

---

# 🛡️ ADMİN PANELİ

> **Erişim:** Yalnızca `Admin` rolüne sahip kullanıcılar  
> **Alan:** `/Admin/...` (ASP.NET Core Area yapısı)  
> **Layout:** Özel `_AdminLayout.cshtml` şablonu

---

## 1. Dashboard (Ana Kontrol Merkezi) — `/Admin/Dashboard/Index`

Admin panelinin ana sayfasıdır. Genel sistem durumunu özet kartlar ve grafiklerle sunar.

**İstatistik Kartları:**
- 🛡️ Toplam Poliçe Sayısı
- 👤 Toplam Kayıtlı Kullanıcı
- 💰 Toplam Prim Geliri
- 🔔 Bekleyen Hasar Bildirimleri

**Grafikler & Listeler:**
- 📊 Aylık satış & poliçe grafiği
- Son eklenen poliçe ve kullanıcı listesi
- **AI Paket Tahmin** — Yapay zeka ile önerilen sigorta paket kombinasyonları

> 📸 Görseller: Dashboard ana kart grubu, aylık satış grafiği, AI tahmin bölümü

---

## 2. Ürün Yönetimi — `/Admin/Product/Index`

Sigorta ürünleri üzerinde tam CRUD işlemleri.

**Tablo Kolonları:** ID · Ürün Adı · Kategori · Fiyat · Durum · İşlemler

**İşlemler:**
- ➕ Yeni ürün ekleme
- ✏️ Mevcut ürün düzenleme (ElevenLabs AI entegrasyonu ile açıklama oluşturma)
- 🗑️ Ürün silme
- 🔄 Durum aktif/pasif değiştirme

> 📸 Görseller: Ürün listesi tablosu, ürün ekleme/düzenleme formu

---

## 3. Kullanıcı Yönetimi — `/Admin/User/Index`

Kayıtlı tüm kullanıcıları listeleme ve yönetme ekranı.

**Tablo Kolonları:** Ad Soyad · E-posta · Kayıt Tarihi · Poliçe Sayısı · Durum

**İşlemler:**
- Kullanıcı detayını görüntüleme
- Hesap aktif/pasif yapma
- Rol atama

> 📸 Görseller: Kullanıcı listesi tablosu

---

## 4. İçerik Yönetimi

### 4a. Hakkımızda Bölümü — `/Admin/About`
Ana sayfadaki "Hakkımızda" bölümünün içeriğini düzenleme.
- Başlık, açıklama metni, özellik maddeleri

### 4b. Slider Yönetimi — `/Admin/Slider`
Ana sayfa hero slider'ını yönetme.
- Görsel yükleme, başlık, alt başlık, buton metni ve link
- Sıralama ve aktif/pasif kontrolü

### 4c. Hizmet Yönetimi — `/Admin/Service`
Sunulan hizmet kartlarını ekleme, düzenleme ve silme.
- İkon, başlık, kısa açıklama

### 4d. Referans (Testimonial) Yönetimi — `/Admin/Testimonial`
Müşteri yorumlarını yönetme.
- Müşteri adı, fotoğraf, yorum metni, puan

### 4e. Video Alanı — `/Admin/Video`
Hakkımızda veya ürün sayfasındaki video içeriğini yönetme.
- YouTube/video URL güncelleme, kapak görseli

> 📸 Görseller: Her içerik yönetim formu ve liste ekranları

---

## 5. Makale (Blog) Yönetimi — `/Admin/Article`

Sigorta hakkında bilgilendirici makaleler oluşturma ve yayınlama.

**Özellikler:**
- Zengin metin editörü ile makale yazma
- Kategori atama
- Yayın tarihi ve durum kontrolü
- SEO başlığı ve açıklaması

> 📸 Görseller: Makale listesi, makale ekleme formu (rich text editor)

---

## 6. Kategori Yönetimi — `/Admin/Category`

Sigorta ürünleri ve makale kategorilerini yönetme.

**İşlemler:** Kategori ekleme · Düzenleme · Silme · Sıralama

> 📸 Görseller: Kategori listesi tablosu

---

## 7. Mesaj Yönetimi — `/Admin/Message`

Kullanıcıların iletişim formu üzerinden gönderdiği mesajları yönetme.

**Tablo Kolonları:** Ad Soyad · E-posta · Konu · Tarih · Durum

**İşlemler:**
- Mesaj detayını görüntüleme
- Okundu/okunmadı işaretleme
- Mesaj silme

> 📸 Görseller: Mesaj listesi, mesaj detay görünümü

---

## 8. Yorum Yönetimi — `/Admin/Comment`

Ürün detay sayfalarındaki müşteri yorumlarını moderasyon.

**Özellikler:**
- Yorumları onaylama / reddetme
- Uygunsuz yorumları silme
- Yıldız puanı istatistiği

> 📸 Görseller: Yorum moderasyon tablosu

---

## 9. Ödeme Listesi — `/Admin/Payment`

Tüm prim ödemelerini ve işlem geçmişini görüntüleme.

**Tablo Kolonları:** Poliçe No · Kullanıcı · Tutar · Tarih · Durum

> 📸 Görseller: Ödeme geçmişi tablosu

---

## 10. AI Modül Yönetimi — `/Admin/AI`

Yapay zeka entegrasyonlarını yönetme ve izleme ekranı.

**Özellikler:**
- 🤖 **Claude AI Chatbot** — Chatbot yanıt geçmişi ve istatistikleri
- 🔊 **ElevenLabs AI** — Sesli içerik üretimi ayarları
- 🌐 **Tavily AI Web Tarama** — İnternet kaynaklı bilgi özetleme asistanı
- 📄 **AI Belge Analiz** — PDF/belge yükleme ve yapay zeka ile analiz ettirme
- ⚙️ AI parametreleri ve model ayarları

> 📸 Görseller: AI modül kontrol paneli

---

## ⚙️ Kurulum

### Gereksinimler
- .NET 8.0 SDK
- MSSQL Server
- Visual Studio 2022 veya VS Code

```bash
# 1. Repoyu klonla
git clone https://github.com/BerkayGenceroglu/InsureYouAI.git
cd InsureYouAI

# 2. appsettings.json dosyasını yapılandır
# ConnectionStrings ve AI API anahtarlarını ekle

# 3. Veritabanını oluştur
dotnet ef database update

# 4. Projeyi çalıştır
dotnet run
```

### appsettings.json Örneği

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=InsureYouAI;Trusted_Connection=True;"
  },
  "AISettings": {
    "ApiKey": "YOUR_AI_API_KEY",
    "ElevenLabsKey": "YOUR_ELEVENLABS_KEY",
    "TavilyKey": "YOUR_TAVILY_KEY"
  }
}
```

---

## 👤 Geliştirici

**Berkay Genceroğlu**

- 🐙 GitHub: [@BerkayGenceroglu](https://github.com/BerkayGenceroglu)
- 💼 LinkedIn: [Berkay Genceroğlu](https://www.linkedin.com/in/berkay-gencero%C4%9Flu-586b52331/)
- 📧 E-posta: berkaygenceroglu6@gmail.com

---

> 🚀 **InsureYouAI** — Sigorta sektörünü yapay zeka ile dijitalleştiren, hem kullanıcı dostu hem de yönetici odaklı modern bir platform.
