<h1 align="center">InsureYouAI - Yapay Zeka Destekli Sigorta Yönetim Sistemi</h1>

<p align="center">
  Sigorta sektörünün dijital dönüşümünü hızlandıran, <strong>ASP.NET Core MVC</strong> ve <strong>Yapay Zeka entegrasyonu</strong> ile geliştirilmiş kapsamlı bir sigorta yönetim platformu.
</p>
<p align="center">
  <strong>InsureYouAI</strong>, geleneksel sigorta süreçlerini uçtan uca dijitalleştiren, hem kullanıcıları hem de yöneticileri düşünerek tasarlanmış modern bir web platformudur.<br/>
  Kullanıcılar sigorta ürünlerini inceleyebilir, online teklif alabilir, poliçelerini takip edebilir ve 7/24 yapay zeka destekli chatbot aracılığıyla anlık danışmanlık alabilir.<br/>
  Yöneticiler ise merkezi admin panelinden tüm ürünleri, poliçeleri, kullanıcıları ve site içeriklerini kolayca yönetebilir; yapay zeka modülleri ile müşteri taleplerine otomatik yanıt üretebilir.
</p>
<p align="center">
  Proje; <strong>Claude AI · ElevenLabs · Tavily</strong> gibi güncel yapay zeka servislerini tek bir platformda bir araya getirerek sigorta operasyonlarını hem hızlandırır hem de akıllandırır.
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

## 🖥️ Ekran Görüntüleri ve Sayfa Detayları

## 👤 Kullanıcı Girişi ve Kayıt

### 1. Kayıt Ol (Register)

Bu ekran, yeni kullanıcıların sisteme üye olması için geliştirilmiş kayıt formudur.

**Form Alanları:**
- İsim, Soyisim, Kullanıcı Adı, E-posta, Şifre, Şifre Tekrar

**ASP.NET Identity** ile güvenli kayıt işlemi gerçekleştirilir. Şifreler hash'lenerek veritabanında saklanır.

<!-- EKRAN GÖRÜNTÜSİ: Kayıt sayfasının ekran görüntüsünü buraya ekleyin -->
<!-- <img width="1920" height="944" alt="Kayıt Ol Sayfası" src="GÖRSEL_URL_BURAYA" /> -->

---

### 2. Giriş Yap (Login)

Kayıtlı kullanıcıların sisteme güvenli bir şekilde giriş yapmasını sağlayan sayfadır.

**Form Alanları:**
- Kullanıcı Adı, Şifre, Beni Hatırla (Remember Me)

<!-- EKRAN GÖRÜNTÜSİ: Giriş sayfasının ekran görüntüsünü buraya ekleyin -->
<!-- <img width="1920" height="947" alt="Giriş Yap Sayfası" src="GÖRSEL_URL_BURAYA" /> -->

---

## 📄 Kullanıcı Sayfaları

### 3. Ana Sayfa (Home)

**Yol:** `/` veya `/Home/Index`/

**Açıklama:** Projenin vitrin sayfasıdır. Tüm önemli bilgileri görsel ve etkili bir şekilde sunar.

**Bileşenler:**
- 🎯 **Hero Banner** - Büyük görsel ve sigorta teklif formu
- 🛡️ **Öne Çıkan Ürünler** - En popüler sigorta ürünlerinin kartları
- 🤖 **AI Chatbot** - Sayfaya entegre yapay zeka asistanı
- ℹ️ **Hakkımızda Özeti** - Şirket hakkında kısa bilgi
- 🛠️ **Servisler** - Sunulan hizmetlerin özeti
- ⭐ **Müşteri Referansları** - Müşteri yorumları
- 📊 **İstatistikler** - Toplam poliçe, müşteri gibi sayısal bilgiler

<!-- EKRAN GÖRÜNTÜSİ: Ana sayfanın ekran görüntülerini buraya ekleyin -->
<img width="1863" height="965" alt="image" src="https://github.com/user-attachments/assets/24c209c0-5233-404d-b840-c43363cbe0a1" />
<img width="1864" height="955" alt="image" src="https://github.com/user-attachments/assets/83549e56-3c51-41d2-a0c6-27fd69dba028" />
<img width="1842" height="953" alt="image" src="https://github.com/user-attachments/assets/649e3d14-9d00-48b5-9e34-5d4d55dfa1c3" />
<img width="1859" height="901" alt="image" src="https://github.com/user-attachments/assets/afe4fd76-21c2-4560-9dc6-59d0d43feb9d" />
<img width="1866" height="938" alt="image" src="https://github.com/user-attachments/assets/dca69ed4-d738-48f0-9e6c-762582882da8" />
<img width="1860" height="957" alt="image" src="https://github.com/user-attachments/assets/e5c890ff-a140-4f8b-9eef-5fa397253503" />
<img width="1862" height="953" alt="image" src="https://github.com/user-attachments/assets/43b8a04e-f987-41aa-baff-84e1ce814bf3" />
<img width="1864" height="954" alt="image" src="https://github.com/user-attachments/assets/fe688be2-3145-4668-9154-3016e1010ff9" />
<img width="1861" height="948" alt="image" src="https://github.com/user-attachments/assets/158d7f3d-b8aa-42d8-b756-3f118c2b46c4" />
<img width="1615" height="354" alt="image" src="https://github.com/user-attachments/assets/92663bd3-637c-42f6-9d01-0863a7b52718" />
<img width="1865" height="954" alt="image" src="https://github.com/user-attachments/assets/22d727c0-7c8f-4747-afac-6cf686f80fa6" />



---

### 4. Blog Listesi Sayfası (Products)

**Yol:** `/Product/Index`

**Açıklama:** Tüm sigorta ürünlerini görüntüleme ve filtreleme sayfası.

**Özellikler:**
- 🛡️ Tüm ürünlerin kart görünümü
- 🏷️ Kategori bilgisi (Kasko, Trafik, Sağlık, Konut vb.)
- 💰 Fiyat aralığı ve teklif bilgisi
- 🔗 Detay sayfasına yönlendirme
  
<img width="1866" height="956" alt="image" src="https://github.com/user-attachments/assets/fc4eea3f-590c-45d6-8010-cdd857eedde4" />
<img width="1861" height="949" alt="image" src="https://github.com/user-attachments/assets/6c056032-5632-42f7-b250-e1420e09fecb" />
<img width="1864" height="953" alt="image" src="https://github.com/user-attachments/assets/67058525-b202-4b7b-a2e3-1834c01716ce" />

<!-- <img width="1920" height="949" alt="Ürünler 1" src="GÖRSEL_URL_BURAYA" /> -->
<!-- <img width="1920" height="944" alt="Ürünler 2" src="GÖRSEL_URL_BURAYA" /> -->

---

### 5. Blog Detay Sayfası (Product Detail)

**Yol:** `/Product/Detail/{id}`

**Açıklama:** Seçilen sigorta ürününün tüm detaylarını gösteren kapsamlı sayfa.

**Bileşenler:**
- 📋 **Ürün Özellikleri** - Kapsam ve teminat detayları
- 💵 **Fiyatlandırma** - Prim bilgileri ve ödeme seçenekleri
- 📝 **Detaylı Açıklama** - Ürün hakkında kapsamlı bilgi
- ⭐ **Müşteri Yorumları** - Önceki müşterilerin değerlendirmeleri
- 🤖 **AI Öneri** - Yapay zeka destekli ürün karşılaştırması

<img width="1861" height="952" alt="image" src="https://github.com/user-attachments/assets/fd3e4e28-c0f0-47d4-a98f-2863b75c2177" />
<img width="1862" height="954" alt="image" src="https://github.com/user-attachments/assets/0af77e4f-584d-492d-87e5-ef1aa105201c" />
<img width="1866" height="890" alt="image" src="https://github.com/user-attachments/assets/3125d99d-d9ea-4948-ab94-bff3fffa8556" />
<img width="1862" height="952" alt="image" src="https://github.com/user-attachments/assets/a14030a3-2224-4c50-90d4-86f56c806ab7" />

<

---

### 6. İletişim Sayfası (Get Quote)

**Yol:** `/Quote/Index`

**Açıklama:** Sigorta teklifi alma formu.

**Form Alanları:**
- 👤 **Kişisel Bilgiler:** Ad, Soyad, T.C. Kimlik No, Doğum Tarihi
- 📋 **Sigorta Bilgileri:** Sigorta türü, poliçe başlangıç tarihi
- 🚗 **Araç / Mülk Bilgileri:** Seçilen ürüne göre değişir
- 💰 **Teminat Seçenekleri:** İstenilen teminat kapsamı


<img width="1864" height="954" alt="image" src="https://github.com/user-attachments/assets/9a230564-28b8-4b05-b7d8-964d24010703" />
<img width="1615" height="354" alt="image" src="https://github.com/user-attachments/assets/92663bd3-637c-42f6-9d01-0863a7b52718" />


---

### 7. Dashboard 

**Açıklama:** Yapay zeka destekli sigorta danışmanlık asistanı.

**Özellikler:**
- 🤖 Doğal dil ile sigorta soruları sorabilme
- 📊 Ürün karşılaştırma önerileri
- 💬 7/24 anlık yanıt
- 🔍 Poliçe sorgulama
<img width="1865" height="955" alt="image" src="https://github.com/user-attachments/assets/277162a8-d075-4877-90c1-41d737e6b95e" />
<img width="1864" height="938" alt="image" src="https://github.com/user-attachments/assets/fdba3c3f-e2b1-4998-97b3-5cd288ed034c" />
<img width="1864" height="957" alt="image" src="https://github.com/user-attachments/assets/b032e8b0-5ecf-4ffe-ae02-18d4a8c15b6f" />

---

### 8. AI Chat Asistant Sayfası (Contact)

**Yol:** `/Contact/Index`

**Açıklama:** İletişim bilgileri ve mesaj gönderme formu.

**Bileşenler:**
- 📍 **Adres Bilgisi** - Şirket adresi
- 📞 **İletişim Bilgileri** - Telefon, email
- 📝 **İletişim Formu:** İsim, Email, Konu, Mesaj

<img width="1864" height="954" alt="image" src="https://github.com/user-attachments/assets/c7248564-894b-4348-a6b2-39d8b775b9fa" />
<img width="1867" height="951" alt="image" src="https://github.com/user-attachments/assets/7c4b8e23-7539-45d6-84ad-b16fb61cb7a2" />


---

## 🛡️ Admin Paneli Sayfaları

Admin panel, **Area** yapısı ile ayrılmıştır.

**Yol:** `/Admin/...`

**Erişim:** Sadece Admin rolüne sahip kullanıcılar

**Layout:** `_AdminLayout.cshtml` - Özel admin template

---

### 1. AI Paket Tahmin (Admin Ana Sayfa)

**Yol:** `/Admin/Dashboard/Index`

**Açıklama:** Admin panelinin ana kontrol merkezi.

**İstatistikler:**
- 🛡️ Toplam Poliçe Sayısı
- 👤 Toplam Kullanıcı Sayısı
- 💰 Toplam Prim Geliri
- 🔔 Bekleyen Hasar Bildirimleri
- 📊 Aylık Satış Grafiği

<img width="1866" height="951" alt="image" src="https://github.com/user-attachments/assets/adf983cb-d297-4ca4-9c81-d1994eaa1571" />
<img width="1868" height="950" alt="image" src="https://github.com/user-attachments/assets/4fc0e38f-2617-4362-85a9-3b3c6fa7c549" />


---

### 2. Eleven LabsAI (Admin Product)

**Yol:** `/Admin/Product/Index`

**Açıklama:** Sigorta ürünleri CRUD işlemleri.

**Tablo Kolonları:**
- ID, Ürün Adı, Kategori, Fiyat, Durum, İşlemler (Düzenle/Sil)

<img width="1869" height="956" alt="image" src="https://github.com/user-attachments/assets/4b62ad15-20dc-45c6-9d5b-894532a65212" />



---
### 3. Tavily AI Web Tarama & Özetleme Asistanı  (Admin User)

**Yol:** `/Admin/User/Index`

**Açıklama:** Kayıtlı kullanıcıları listeleme ve yönetme.

**Kolonlar:**
- Ad Soyad, Email, Kayıt Tarihi, Poliçe Sayısı, Durum

<!-- EKRAN GÖRÜNTÜSİ: Kullanıcı yönetimi ekran görüntüsünü buraya ekleyin -->
<!-- <img width="1920" height="950" alt="Kullanıcı Yönetimi" src="GÖRSEL_URL_BURAYA" /> -->
<img width="1866" height="955" alt="image" src="https://github.com/user-attachments/assets/6955f8a4-0269-437d-9f75-8145a7631d95" />

---
### 3. Hakkımızda Bölge  (Admin User)

**Yol:** `/Admin/User/Index`

**Açıklama:** Kayıtlı kullanıcıları listeleme ve yönetme.

**Kolonlar:**
- Ad Soyad, Email, Kayıt Tarihi, Poliçe Sayısı, Durum

<!-- EKRAN GÖRÜNTÜSİ: Kullanıcı yönetimi ekran görüntüsünü buraya ekleyin -->
<!-- <img width="1920" height="950" alt="Kullanıcı Yönetimi" src="GÖRSEL_URL_BURAYA" /> -->
<img width="1864" height="952" alt="image" src="https://github.com/user-attachments/assets/b3cef565-bc54-4114-8356-c6d743224e13" />
<img width="1863" height="952" alt="image" src="https://github.com/user-attachments/assets/93872f4d-2382-4d29-96a9-cbc23f098bde" />


---
### 3. Hakkımızda Alt Bölge  (Admin User)

**Yol:** `/Admin/User/Index`

**Açıklama:** Kayıtlı kullanıcıları listeleme ve yönetme.

**Kolonlar:**
- Ad Soyad, Email, Kayıt Tarihi, Poliçe Sayısı, Durum

<img width="1866" height="952" alt="image" src="https://github.com/user-attachments/assets/01c7bcb2-7af9-40e3-b020-ac59d122a417" />
<img width="1620" height="233" alt="image" src="https://github.com/user-attachments/assets/3f8ac339-711b-48e3-b35a-04e9c939f42d" />
<img width="652" height="307" alt="image" src="https://github.com/user-attachments/assets/ca952956-214c-443c-9c53-5d05001ebbb5" />


---
### 3. Hakkımızda Alt Bölge  (Admin User)

**Yol:** `/Admin/User/Index`

**Açıklama:** Kayıtlı kullanıcıları listeleme ve yönetme.

**Kolonlar:**
- Ad Soyad, Email, Kayıt Tarihi, Poliçe Sayısı, Durum
<img width="1867" height="742" alt="image" src="https://github.com/user-attachments/assets/c6df27a8-cd11-4d81-a0a6-a9b63523ac46" />
<img width="1871" height="629" alt="image" src="https://github.com/user-attachments/assets/ade66ab6-a77d-4593-8a9c-173280bf8834" />
<img width="1864" height="659" alt="image" src="https://github.com/user-attachments/assets/b109f78b-5dc5-460e-9f35-61658bdf24a1" />



---
### 3. Message Listesi  (Admin User)

**Yol:** `/Admin/User/Index`

**Açıklama:** Kayıtlı kullanıcıları listeleme ve yönetme.

**Kolonlar:**
- Ad Soyad, Email, Kayıt Tarihi, Poliçe Sayısı, Durum
<img width="1865" height="947" alt="image" src="https://github.com/user-attachments/assets/1fce3268-677e-44c0-b3f2-98dc4303fc82" />
<img width="1865" height="953" alt="image" src="https://github.com/user-attachments/assets/9f98223d-72bf-4982-bfb3-cb7753040a0a" />
<img width="1861" height="950" alt="image" src="https://github.com/user-attachments/assets/706a840b-4b51-45ac-82ee-c41685e60cb3" />



---
### 3. Yorum Listesi  (Admin User)

**Yol:** `/Admin/User/Index`

**Açıklama:** Kayıtlı kullanıcıları listeleme ve yönetme.

**Kolonlar:**
- Ad Soyad, Email, Kayıt Tarihi, Poliçe Sayısı, Durum
<img width="1866" height="951" alt="image" src="https://github.com/user-attachments/assets/bb6813d1-2a07-4b16-8f6b-9b1f359ed68e" />



---
### 3. Ödeme Listesi  (Admin User)

**Yol:** `/Admin/User/Index`

**Açıklama:** Kayıtlı kullanıcıları listeleme ve yönetme.

**Kolonlar:**
- Ad Soyad, Email, Kayıt Tarihi, Poliçe Sayısı, Durum
<img width="1869" height="793" alt="image" src="https://github.com/user-attachments/assets/b87983e1-1812-46d5-9add-9cd52e97abdb" />



---
### 3. Hizmet Listesi  (Admin User)

**Yol:** `/Admin/User/Index`

**Açıklama:** Kayıtlı kullanıcıları listeleme ve yönetme.

**Kolonlar:**
- Ad Soyad, Email, Kayıt Tarihi, Poliçe Sayısı, Durum
<img width="1867" height="749" alt="image" src="https://github.com/user-attachments/assets/2389f940-52b4-4dc3-9cd9-26e8ad84b4a3" />
<img width="1868" height="913" alt="image" src="https://github.com/user-attachments/assets/5b03af33-4d48-4374-b0d2-11e7f88c80c2" />
<img width="1866" height="911" alt="image" src="https://github.com/user-attachments/assets/1b393132-f23a-4b33-8540-8708da627aa2" />




---
### 3. Slider Listesi  (Admin User)

**Yol:** `/Admin/User/Index`

**Açıklama:** Kayıtlı kullanıcıları listeleme ve yönetme.

**Kolonlar:**
- Ad Soyad, Email, Kayıt Tarihi, Poliçe Sayısı, Durum
<img width="1869" height="877" alt="image" src="https://github.com/user-attachments/assets/d6ef4942-c1ae-4895-aebf-0f7d64fda768" />
<img width="1864" height="950" alt="image" src="https://github.com/user-attachments/assets/a2825bc6-1a8a-40ad-96c6-2d7a3247dbf0" />
<img width="1866" height="950" alt="image" src="https://github.com/user-attachments/assets/a1621316-8e44-4ab1-a9b5-5634bb5a51d1" />





---
### 3. Referans Listesi  (Admin User)

**Yol:** `/Admin/User/Index`

**Açıklama:** Kayıtlı kullanıcıları listeleme ve yönetme.

**Kolonlar:**
- Ad Soyad, Email, Kayıt Tarihi, Poliçe Sayısı, Durum

<img width="1865" height="952" alt="image" src="https://github.com/user-attachments/assets/0837593d-94ef-4f9e-a1f7-cbb891842cb2" />

<img width="1865" height="948" alt="image" src="https://github.com/user-attachments/assets/cfed602d-a757-484a-a8f9-2d41cb882e12" />
<img width="1866" height="950" alt="image" src="https://github.com/user-attachments/assets/8312ce20-8389-4fe9-b5ea-e9942888f515" />



---
### 3. Video Alanı  (Admin User)

**Yol:** `/Admin/User/Index`

**Açıklama:** Kayıtlı kullanıcıları listeleme ve yönetme.

**Kolonlar:**
- Ad Soyad, Email, Kayıt Tarihi, Poliçe Sayısı, Durum

<img width="1601" height="277" alt="image" src="https://github.com/user-attachments/assets/fa404ac4-1110-4040-a97f-7636181475a8" />
<img width="1610" height="427" alt="image" src="https://github.com/user-attachments/assets/402da8c4-aeaf-4656-8623-979c595042e6" />
<img width="1620" height="450" alt="image" src="https://github.com/user-attachments/assets/bf3ae3a7-e3f7-46d1-a300-a098ca40a401" />



---
### 4. AI Belge Analiz Edici (Admin AI)

**Yol:** `/Admin/AI/Index`

**Açıklama:** Yapay zeka chatbot ayarlarını ve yanıt şablonlarını yönetme.

**Özellikler:**
- 🤖 Chatbot yanıt geçmişi
- ⚙️ AI parametreleri ayarlama
- 📊 Chatbot kullanım istatistikleri
- 📝 Özelleştirilmiş yanıt şablonları


<img width="1872" height="954" alt="image" src="https://github.com/user-attachments/assets/552fdf35-71fc-40aa-97bd-a7ed354cdf02" />

---

### 5. Kategori Listesi Mesajları (Admin Contact)

**Yol:** `/Admin/Contact/Index`

**Kolonlar:**
- Ad Soyad, Email, Konu, Mesaj, Tarih

**İşlemler:**
- Mesajları görüntüleme, mesaj detayı, mesaj silme

<!-- EKRAN GÖRÜNTÜSİ: İletişim mesajları ekran görüntüsünü buraya ekleyin -->
<!-- <img width="1920" height="953" alt="İletişim Mesajları" src="GÖRSEL_URL_BURAYA" /> -->
<img width="1865" height="960" alt="image" src="https://github.com/user-attachments/assets/5e63b8a8-9e07-4f79-83c3-52ce56b892c8" />


---
### 5. Makale Listesi  (Admin Contact)

**Yol:** `/Admin/Contact/Index`

**Kolonlar:**
- Ad Soyad, Email, Konu, Mesaj, Tarih

**İşlemler:**
- Mesajları görüntüleme, mesaj detayı, mesaj silme

<!-- EKRAN GÖRÜNTÜSİ: İletişim mesajları ekran görüntüsünü buraya ekleyin -->
<!-- <img width="1920" height="953" alt="İletişim Mesajları" src="GÖRSEL_URL_BURAYA" /> -->
<img width="1865" height="948" alt="image" src="https://github.com/user-attachments/assets/1b546e70-a84f-4893-83df-8338f25a82b9" />
<img width="1866" height="954" alt="image" src="https://github.com/user-attachments/assets/ed821de9-4f34-4986-9c5f-9ebbbcf8c6ca" />
<img width="1865" height="954" alt="image" src="https://github.com/user-attachments/assets/dc8974b6-827e-42cd-965a-be47147e2f76" />

## 🏗 Mimari Yapı
---
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
<img width="385" height="337" alt="image" src="https://github.com/user-attachments/assets/401855f1-8de7-4414-8869-7e387e1a4f47" />

Teşekkürler! Bu projeyi kullandığınız veya katkıda bulunduğunuz için memnuniyet duyarım.  
Her türlü geri bildirime açığım.

**İyi kodlamalar! 🚀**
