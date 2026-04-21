<h1 align="center">InsureYouAI - Yapay Zeka Destekli Sigorta Yönetim Sistemi</h1>

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
- 🔍 **PDF Değerlendirmesi** - AI Destekli PDF analizi
- 💬 **Doğal Dil Anlama** - Türkçe doğal dil işleme ile kullanıcı odaklı deneyim

---

# 📱 KULLANICI TARAFLARI

---


## 1. Ana Sayfa (Default)

**Yol:** `/` veya `/Default/Index`

**Açıklama:** Projenin vitrin sayfasıdır. Tüm önemli bilgileri görsel ve etkili bir şekilde sunar.

**Bileşenler:**
- 🎯 **Hero Banner** - Büyük görsel ve sigorta teklif formu
- 🛡️ **Öne Çıkan Ürünler** - En popüler sigorta ürünlerinin kartları
- ℹ️ **Hakkımızda Özeti** - Şirket hakkında kısa bilgi
- 📦 **Paketler** - Sigorta şirketine ait paket teklifleri
- 🛠️ **Servisler** - Sunulan hizmetlerin özeti
- ⭐ **Müşteri Referansları** - Müşteri yorumları
- 📊 **İstatistikler** - Toplam poliçe, müşteri gibi sayısal bilgiler
- 📬 **İletişim** - Sigorta şirketine mail yoluyla iletişime geçilir; arka planda yapay zeka otomatik cevap verir   burayı daha güzel yap tasarım aynı kalsın 


<img width="1863" height="965" alt="Ana Sayfa - Hero Banner" src="https://github.com/user-attachments/assets/24c209c0-5233-404d-b840-c43363cbe0a1" />
<img width="1864" height="955" alt="Ana Sayfa - Öne Çıkan Ürünler" src="https://github.com/user-attachments/assets/83549e56-3c51-41d2-a0c6-27fd69dba028" />
<img width="1842" height="953" alt="Ana Sayfa - Hakkımızda" src="https://github.com/user-attachments/assets/649e3d14-9d00-48b5-9e34-5d4d55dfa1c3" />
<img width="1859" height="901" alt="Ana Sayfa - Servisler" src="https://github.com/user-attachments/assets/afe4fd76-21c2-4560-9dc6-59d0d43feb9d" />
<img width="1866" height="938" alt="Ana Sayfa - Müşteri Referansları" src="https://github.com/user-attachments/assets/dca69ed4-d738-48f0-9e6c-762582882da8" />
<img width="1860" height="957" alt="Ana Sayfa - İstatistikler" src="https://github.com/user-attachments/assets/e5c890ff-a140-4f8b-9eef-5fa397253503" />
<img width="1862" height="953" alt="Ana Sayfa - AI Chatbot Bölümü" src="https://github.com/user-attachments/assets/43b8a04e-f987-41aa-baff-84e1ce814bf3" />
<img width="1864" height="954" alt="Ana Sayfa - Teklif Formu" src="https://github.com/user-attachments/assets/fe688be2-3145-4668-9154-3016e1010ff9" />
<img width="1861" height="948" alt="Ana Sayfa - Footer" src="https://github.com/user-attachments/assets/158d7f3d-b8aa-42d8-b756-3f118c2b46c4" />
<img width="1615" height="354" alt="Ana Sayfa - Alt Şerit" src="https://github.com/user-attachments/assets/92663bd3-637c-42f6-9d01-0863a7b52718" />
<img width="1865" height="954" alt="Ana Sayfa - Genel Görünüm" src="https://github.com/user-attachments/assets/22d727c0-7c8f-4747-afac-6cf686f80fa6" />

---

## 2. Blog Sayfası (Products)

**Yol:** `/Blog/BlogListPage`

**Açıklama:**
Blog yazılarının listelendiği ana sayfa. Kullanıcılar yazıları kategori filtresi ile filtreleyebilir, kart veya liste görünümü arasında geçiş yapabilir. Her blog kartında kapak görseli, kategori etiketi, başlık, özet metin, yazar bilgisi, tarih ve okuma süresi yer alır.

**Özellikler:**
- 🔍 **Arama:** Üst kısımda blog yazılarında arama yapılabilir input alanı
- 🏷️ **Kategori Filtresi:** Yatay kaydırılabilir kategori butonları (Tümü, Teknoloji, Tasarım, vb.) ile içerik filtreleme
- 🃏 **Kart Görünümü:** Blog yazıları grid düzeninde, kapak görselli kartlar olarak listelenir
- 📋 **Liste Görünümü:** Blog yazıları yatay, kompakt liste satırları olarak görüntülenir
- 🔄 **Görünüm Geçişi:** Sağ üstte kart/liste görünümü arasında toggle butonları
- 👤 **Yazar Bilgisi:** Her kartta yazar avatarı ve adı
- 📅 **Meta Bilgiler:** Yayın tarihi ve tahmini okuma süresi
- 📄 **Sayfalama:** Alt kısımda sayfa numaraları ile pagination
- 📱 **Responsive Tasarım:** Mobil uyumlu grid yapısı

<img width="1866" height="956" alt="Ürünler - Kart Görünümü" src="https://github.com/user-attachments/assets/fc4eea3f-590c-45d6-8010-cdd857eedde4" />
<img width="1861" height="949" alt="Ürünler - Kategori Filtresi" src="https://github.com/user-attachments/assets/6c056032-5632-42f7-b250-e1420e09fecb" />
<img width="1864" height="953" alt="Ürünler - Liste Görünümü" src="https://github.com/user-attachments/assets/67058525-b202-4b7b-a2e3-1834c01716ce" />

---

## 3. Blog Detay Sayfası (Blog Detail)

**Yol:** `/Blog/BlogDetail/{id}`

**Açıklama:**
Seçilen blog yazısının tüm içeriğini ve ilgili bilgileri gösteren kapsamlı detay sayfası. Yazı içeriği, yazar bilgisi, yorumlar ve ilgili yazılar gibi bölümlerden oluşur.

**Özellikler:**
- 🖼️ **Kapak Görseli:** Sayfanın üst kısmında geniş blog kapak/banner görseli
- 🏷️ **Kategori & Meta Bilgiler:** Kategori etiketi, yayın tarihi, okuma süresi ve yazar adı
- 📝 **İçerik Alanı:** Zengin metin editörü ile oluşturulmuş blog yazısı içeriği (başlıklar, paragraflar, görseller)
- 👤 **Yazar Kartı:** Yazar avatarı, adı, unvanı ve kısa biyografi bilgisi
- 🔖 **Sosyal Paylaşım:** Yazıyı sosyal medyada paylaşmak için paylaşım butonları
- 🏷️ **Etiketler (Tags):** Yazıya ait anahtar kelime etiketleri
- ⭐ **Müşteri Yorumları:** Kullanıcı yorumları, yıldız puanlaması ve yorum tarihleri
- ✍️ **Yorum Formu:** Kullanıcıların yeni yorum ekleyebileceği form alanı
- 📰 **İlgili Yazılar:** Sayfanın alt kısmında benzer blog yazılarının kart görünümüyle listelenmesi
- 🧭 **Breadcrumb:** Sayfa üstünde navigasyon yolu (Ana Sayfa > Blog > Yazı Başlığı)


<img width="1861" height="952" alt="Ürün Detay - Genel Bilgiler" src="https://github.com/user-attachments/assets/fd3e4e28-c0f0-47d4-a98f-2863b75c2177" />
<img width="1862" height="954" alt="Ürün Detay - Teminat Detayları" src="https://github.com/user-attachments/assets/0af77e4f-584d-492d-87e5-ef1aa105201c" />
<img width="1866" height="890" alt="Ürün Detay - Fiyatlandırma" src="https://github.com/user-attachments/assets/3125d99d-d9ea-4948-ab94-bff3fffa8556" />
<img width="1862" height="952" alt="Ürün Detay - Müşteri Yorumları" src="https://github.com/user-attachments/assets/a14030a3-2224-4c50-90d4-86f56c806ab7" />

---

## 4. Mesaj Gönderme Bölümü (Get Message)
**Yol:** `/Blog/SendMessage`

**Açıklama:**
Kullanıcıların sigorta teklifi veya genel bilgi talebi için iletişime geçebildiği form sayfası. Sol tarafta iletişim bilgileri ve sağ tarafta doldurulabilir form alanlarından oluşur.

**Form Alanları:**
- 👤 **Ad Soyad:** Kullanıcının tam adını girdiği metin alanı
- 📧 **E-posta:** Geçerli e-posta adresi girişi
- 📞 **Telefon:** Telefon numarası girişi
- 📋 **Sigorta Türü:** Dropdown ile sigorta kategorisi seçimi
- 💬 **Mesaj:** Kullanıcının talebini açıkladığı çok satırlı metin alanı
- ✅ **KVKK Onayı:** Kişisel verilerin işlenmesine ilişkin onay checkbox'ı
- 🚀 **Gönder Butonu:** Formu göndermek için CTA butonu

**Ek Özellikler:**
- 📍 **İletişim Bilgileri:** Adres, telefon ve e-posta bilgilerinin sol panelde gösterimi
- 🗺️ **Harita:** Ofis konumunu gösteren gömülü harita alanı
- 📣 **Alt Şerit (CTA Banner):** Sayfanın altında "Hemen Teklif Al" gibi yönlendirici bir aksiyon bandı
- 🕐 **Çalışma Saatleri:** İletişim panelinde çalışma saatleri bilgisi

<img width="1864" height="954" alt="Online Teklif Al - Form" src="https://github.com/user-attachments/assets/9a230564-28b8-4b05-b7d8-964d24010703" />
<img width="1615" height="354" alt="Online Teklif Al - Alt Şerit" src="https://github.com/user-attachments/assets/92663bd3-637c-42f6-9d01-0863a7b52718" />

---
# 🛡️ ADMİN PANELİ

Admin panel, **Area** yapısı ile ayrılmıştır. Sadece Admin rolüne sahip kullanıcılar erişebilir.

**Yol:** `/Admin/...`  
**Layout:** `_AdminLayout.cshtml`

---
## 1. Dashboard Sayfası 
**Açıklama:**
Kullanıcının tüm sigorta işlemlerini, istatistiklerini ve hesap bilgilerini tek ekranda görüntüleyebildiği ana dashboard sayfası.

**Özellikler:**
- 📊 **İstatistik Kartları:** Toplam poliçe sayısı, aktif teminatlar, ödenen prim tutarı gibi özet metrik kartları
- 💰 **Bakiye Hesaplama:** Mevcut bakiye, yaklaşan ödemeler ve kalan taksit bilgilerinin anlık gösterimi
- 📈 **Veri Tahmini Grafiği:** Geçmiş verilere dayalı olarak gelecek dönem prim tahmini ve maliyet projeksiyonu grafikleri
- 🏆 **En Çok Kullanılan Ürünler:** Kullanıcının en sık tercih ettiği sigorta ürünlerinin sıralı listesi
- 🗂️ **Yorum / İşlem Geçmişi:** Geçmiş poliçe işlemleri, ödeme geçmişi ve kullanıcı yorumlarının kronolojik listesi
- 🥇 **Sıralamalar:** Ürün veya kategori bazında performans sıralamaları ve karşılaştırmalı istatistikler
- 📉 **Grafik & Görselleştirmeler:** Bar, çizgi veya pasta grafikleriyle istatistiklerin görsel sunumu
- 🔔 **Bildirim & Uyarılar:** Poliçe yenileme tarihleri, ödeme hatırlatmaları ve sistem bildirimleri
- 📅 **Tarih Aralığı Filtresi:** İstatistik ve geçmiş verilerini belirli tarih aralığına göre filtreleme
- 📱 **Responsive Tasarım:** Mobil ve masaüstü uyumlu esnek grid yapısı

<img width="1868" height="953" alt="image" src="https://github.com/user-attachments/assets/79ec0415-6377-452f-9b2e-14d6739109eb" />
<img width="1864" height="938" alt="AI Chat - Sigorta Danışmanlığı" src="https://github.com/user-attachments/assets/fdba3c3f-e2b1-4998-97b3-5cd288ed034c" />
<img width="1864" height="957" alt="AI Chat - Ürün Önerisi" src="https://github.com/user-attachments/assets/b032e8b0-5ecf-4ffe-ae02-18d4a8c15b6f" />

---

## 2. AI ChatBot Live Sayfası (Chatbot)
**Yol:** `/ChatBot/SendChatWithAI`

**Açıklama:**
Kullanıcıların yapay zeka destekli sigorta danışmanı ile gerçek zamanlı sohbet edebildiği interaktif chat arayüzü. Anlık mesajlaşma deneyimi sunarak sigorta sorularına hızlı ve akıllı yanıtlar üretir.

**Özellikler:**
- 💬 **Sohbet Arayüzü:** Kullanıcı ve AI mesajlarının balon formatında gösterildiği gerçek zamanlı chat ekranı
- 🤖 **AI Yanıt Motoru:** Sigorta alanında uzmanlaşmış yapay zeka ile anlık, bağlama duyarlı yanıtlar
- 📝 **Mesaj Giriş Alanı:** Alt kısımda serbest metin yazılabilen input ve gönder butonu
- ⚡ **Hızlı Yanıt Butonları:** Sık sorulan sorular için hazır cevap seçenekleri (Quick Reply chips)
- 🕐 **Sohbet Geçmişi:** Oturum içindeki tüm mesajların kronolojik sırayla listelenmesi
- 👤 **Kullanıcı & Bot Avatarı:** Mesaj balonlarında kullanıcı ve AI avatarlarının gösterimi
- 🔄 **Yeni Sohbet Başlatma:** Mevcut sohbeti sıfırlayarak yeni oturum açma seçeneği
- ✍️ **Yazıyor Göstergesi:** AI yanıt üretirken görüntülenen animasyonlu "yazıyor..." indikatörü
- 🌐 **Çok Dilli Destek:** Türkçe ve İngilizce dil desteği
- 📱 **Responsive Tasarım:** Mobil ve masaüstü uyumlu tam ekran chat arayüzü


<img width="1864" height="954" alt="İletişim - Form Alanı" src="https://github.com/user-attachments/assets/c7248564-894b-4348-a6b2-39d8b775b9fa" />
<img width="1867" height="951" alt="İletişim - Harita ve Bilgiler" src="https://github.com/user-attachments/assets/7c4b8e23-7539-45d6-84ad-b16fb61cb7a2" />

---


## 3. AI ile Kişiye Özel Sigorta Paket Önerisi (Sigorta Paket Önerisi)
**Açıklama:**
Kullanıcının kişisel bilgileri, yaşam tarzı ve ihtiyaçlarına göre yapay zeka tarafından analiz edilerek özelleştirilmiş sigorta paket önerileri sunan akıllı öneri sayfası.

**Özellikler:**
- 🤖 **AI Analiz Motoru:** Kullanıcı verilerini analiz ederek en uygun sigorta paketini belirleyen yapay zeka algoritması
- 📋 **Kişisel Bilgi Formu:** Yaş, meslek, aile durumu, gelir seviyesi gibi profil bilgilerinin toplandığı adım adım form yapısı
- 🎯 **Kişiye Özel Paket Önerisi:** Analiz sonucunda kullanıcıya özel oluşturulmuş sigorta paketi kartları
- 📊 **Öneri Skoru:** Her paketin kullanıcı profiline uygunluk yüzdesi ve açıklama metni
- 🛡️ **Teminat Karşılaştırması:** Önerilen paketlerin teminat detaylarının yan yana karşılaştırmalı gösterimi
- 💰 **Fiyat & Prim Bilgisi:** Her pakete ait aylık/yıllık prim tutarı ve ödeme seçenekleri
- 📈 **Risk Analizi Grafiği:** Kullanıcı profiline göre hesaplanan risk seviyesinin görsel grafik ile sunumu
- ✅ **Paket Seçimi & Devam:** Beğenilen paketi seçerek teklif veya satın alma adımına geçiş butonu
- 🔄 **Yeniden Analiz:** Bilgileri güncelleyerek yeni öneri üretme seçeneği
- 📱 **Responsive Tasarım:** Mobil ve masaüstü uyumlu esnek yapı

<img width="1866" height="951" alt="Admin Dashboard - İstatistikler" src="https://github.com/user-attachments/assets/adf983cb-d297-4ca4-9c81-d1994eaa1571" />

---

## 4. Metni Sese Dönüştüren AI Yönetimi (Text to Speech)

**Açıklama:**
Kullanıcıların metin içeriklerini yapay zeka destekli ses sentezi ile gerçek zamanlı olarak sese dönüştürebildiği yönetim sayfası. Farklı ses tonu, hız ve dil seçenekleri ile kişiselleştirilebilir ses çıktısı üretir.

**Özellikler:**
- 📝 **Metin Giriş Alanı:** Sese dönüştürülecek metnin yazıldığı veya yapıştırıldığı çok satırlı input alanı
- 🎙️ **Ses Tonu Seçimi:** Farklı AI ses karakterleri arasından seçim yapılabilmesi (erkek/kadın/nötr)
- 🌐 **Dil & Aksan Seçeneği:** Türkçe, İngilizce ve diğer dil seçenekleri ile aksan ayarı
- ⚡ **Hız Kontrolü:** Ses okuma hızını yavaş, normal veya hızlı olarak ayarlama
- 🔊 **Anlık Önizleme:** Oluşturulan ses çıktısının sayfa üzerinde oynatılabilir ses oynatıcı ile dinlenmesi
- ⬇️ **Ses İndirme:** Oluşturulan ses dosyasının MP3/WAV formatında indirilebilmesi
- 📋 **Geçmiş Kayıtlar:** Daha önce oluşturulan ses dönüşümlerinin listelenmesi ve tekrar erişim
- 🗑️ **CRUD İşlemleri:** Kayıtlı ses içeriklerini listeleme, düzenleme ve silme işlemleri
- 📊 **Kullanım İstatistikleri:** Toplam dönüştürülen karakter sayısı ve kullanım özeti
- 📱 **Responsive Tasarım:** Mobil ve masaüstü uyumlu arayüz


<img width="1869" height="956" alt="Admin Ürün - Liste ve CRUD" src="https://github.com/user-attachments/assets/4b62ad15-20dc-45c6-9d5b-894532a65212" />

---

## 5. Taıly Web Arama AI Yönetimi 
**Açıklama:**
Tavily API entegrasyonu ile gerçek zamanlı web taraması yapan ve sonuçları yapay zeka ile özetleyen akıllı arama asistanı sayfası. Kullanıcılar herhangi bir konuyu arayarak anlık web verilerine dayalı AI özeti alabilir.

**Özellikler:**
- 🔍 **Arama Giriş Alanı:** Kullanıcının doğal dilde soru veya konu girebileceği arama input alanı ve Ara butonu
- 🤖 **AI Özet Sonucu:** Tavily'nin taradığı web sonuçlarından yapay zeka tarafından üretilen sade ve anlaşılır özet metni
- 🗂️ **Tavily Ham Veri (JSON):** API'den dönen ham JSON verisinin açılır/kapanır panel içinde gösterimi
- 📡 **Gerçek Zamanlı Web Taraması:** Güncel web sayfalarından canlı veri çekerek sonuç üretme
- ⏱️ **Yanıt Süresi:** API'nin kaç saniyede yanıt verdiğinin gösterimi (`response_time`)
- 🔗 **Kaynak Linkleri:** Tarama sonucunda elde edilen web sitesi URL'lerinin listelenmesi
- 📊 **Skor Gösterimi:** Her kaynağın alaka düzeyi skorunun (`score`) JSON verisinde görüntülenmesi
- 📋 **Ham Veri İnceleme:** Geliştiriciler için tam JSON response verisinin sayfa üzerinde incelenebilmesi
- 📱 **Responsive Tasarım:** Mobil ve masaüstü uyumlu arayüz


<img width="1866" height="955" alt="Admin Kullanıcı - Kullanıcı Listesi" src="https://github.com/user-attachments/assets/6955f8a4-0269-437d-9f75-8145a7631d95" />

---
## AI ile 6.Pdf Analizi Yönetimi 
**Açıklama:**
Kullanıcıların PDF belgelerini yükleyerek yapay zeka ile analiz ettirebildiği, belge içeriğini otomatik özetleyen ve madde madde raporlayan akıllı PDF analiz sayfası.

**Özellikler:**
- 📂 **Dosya Yükleme Alanı:** Sürükle-bırak veya dosya seç butonu ile PDF yükleme alanı
- 🚀 **Analizi Başlat Butonu:** Yüklenen PDF'in AI tarafından analizini tetikleyen CTA butonu
- 📄 **Otomatik Özetleme:** Belge içeriğinin yapay zeka tarafından madde madde özetlenmesi
- 🔢 **Numaralı Başlık Yapısı:** Analiz sonucunun bölümlere ayrılmış başlıklar halinde sunulması (Poliçeyi 10 Maddede Özetle, Neleri Kapsar, Neleri Kapsamaz vb.)
- ✅ **Kapsam Analizi:** Belgenin neleri kapsadığının liste formatında çıktısı
- ❌ **Kapsam Dışı Analizi:** Belgenin neleri kapsamadığının tespit edilerek listelenmesi
- ⚠️ **Kritik Uyarılar:** Müşteri için önemli risk ve uyarı maddelerinin ayrı bölümde vurgulanması
- 📋 **Yapılandırılmış Rapor:** Analiz sonucunun okunması kolay, hiyerarşik rapor formatında sunulması
- 🖨️ **Sonuç Görüntüleme:** Analiz çıktısının sayfa üzerinde kaydırılabilir alanda gösterimi
- 📱 **Responsive Tasarım:** Mobil ve masaüstü uyumlu arayüz

<img width="1872" height="954" alt="image" src="https://github.com/user-attachments/assets/09044be7-7140-4826-9221-f7c22e67395b" />

---

## 8. Mesaj Listesi ve İstatistikler
**Açıklama:**
Kullanıcılardan gelen tüm mesajların listelendiği, AI tarafından kategorize edildiği ve öncelik sırasına göre yönetilebildiği admin mesaj yönetim sayfası.

**Özellikler:**
- 📋 **Gelen Mesaj Listesi:** Ad soyad, konu, e-posta, tarih, AI kategori, öncelik ve durum bilgilerinin tablo formatında listelenmesi
- 🤖 **AI Kategorizasyon:** Her mesajın yapay zeka tarafından otomatik kategorize edilmesi (Hasar Bildirimi, Poliçe Yenileme, Genel Soru, Kasko, Sağlık Sigortası, Konut Sigortası vb.)
- 🔴 **Öncelik Seviyesi:** Mesajların Yüksek, Orta, Düşük öncelik badge'leri ile renkli gösterimi
- 🟢 **Okundu/Okunmadı Durumu:** Her mesajın okunma durumunun renkli badge ile takibi
- 👁️ **Mesajı Aç:** Mesaj detayını görüntüleme butonu
- ✏️ **Mesaj Düzenleme:** Mevcut mesaj bilgilerini güncelleyebileceğiniz düzenleme formu (Gönderici Ad-Soyad, Konu, Email, Mesaj Detayı)
- 🗑️ **Mesaj Silme:** Mesajı sistemden kaldırma butonu
- ➕ **Yeni Mesaj Girişi:** Admin tarafından manuel yeni mesaj ekleyebileceği form (Gönderici Ad-Soyad, Konu, Email, Mesaj Detayı, Mesaj Kaydet butonu)
- 🔍 **Arama:** Mesaj listesinde anahtar kelime ile arama yapabilme
- 🧭 **Breadcrumb:** Sayfa üstünde navigasyon yolu gösterimi

<img width="1865" height="947" alt="Admin Mesaj - Mesaj Listesi" src="https://github.com/user-attachments/assets/1fce3268-677e-44c0-b3f2-98dc4303fc82" />
<img width="1865" height="953" alt="Admin Mesaj - Mesaj Detayı" src="https://github.com/user-attachments/assets/9f98223d-72bf-4982-bfb3-cb7753040a0a" />
<img width="1861" height="950" alt="Admin Mesaj - Detay Görünümü" src="https://github.com/user-attachments/assets/706a840b-4b51-45ac-82ee-c41685e60cb3" />

---
## 9. Makale Listesi ve İstatistikler

**Açıklama:**
Sisteme kayıtlı tüm blog makalelerinin listelendiği, yönetildiği ve yapay zeka ile otomatik makale oluşturulabildiği admin makale yönetim sayfası.

**Özellikler:**
- 📋 **Makale Listesi:** Başlık, kategori, yazar, tarih bilgilerinin tablo formatında sayfalanmış şekilde listelenmesi
- 🏷️ **Kategori Badge:** Her makalenin ait olduğu sigorta kategorisinin renkli etiketle gösterimi (Kasko, Konut, Sağlık, Seyahat, İşyeri Sigortası vb.)
- 👁️ **Gör:** Makaleyi önizleme butonu
- ✏️ **Düzenle:** Mevcut makale bilgilerini güncelleyebileceğiniz düzenleme formu (Başlık, Tarih, Cover Görsel URL, Main Görsel, Kategori, Yazar, Açıklama)
- 🗑️ **Sil:** Makaleyi sistemden kaldırma butonu
- ➕ **Yeni Makale:** Admin tarafından manuel yeni makale ekleme formu
- 🤖 **Yapay Zeka ile Makale Oluştur:** Konu girilerek AI'ın otomatik makale içeriği ürettiği AI Makale Oluşturucu aracı
- 📝 **AI Makale Oluşturucu:** Makale konusu input alanı ve "Makale Oluştur" butonu ile anında içerik üretimi
- 📄 **Oluşturulan Makale Önizleme:** AI tarafından üretilen makalenin sayfa üzerinde görüntülenmesi
- 📋 **Kopyala & İndir:** Üretilen makale içeriğini panoya kopyalama veya dosya olarak indirme
- 🔍 **Arama:** Makale listesinde başlık veya içerik ile arama yapabilme
- 🧭 **Breadcrumb:** Sayfa üstünde navigasyon yolu gösterimi
  
<img width="1865" height="948" alt="Admin Makale - Makale Listesi" src="https://github.com/user-attachments/assets/1b546e70-a84f-4893-83df-8338f25a82b9" />
<img width="1866" height="954" alt="Admin Makale - Makale Ekleme" src="https://github.com/user-attachments/assets/ed821de9-4f34-4986-9c5f-9ebbbcf8c6ca" />
<img width="1865" height="954" alt="Admin Makale - Makale Düzenleme" src="https://github.com/user-attachments/assets/dc8974b6-827e-42cd-965a-be47147e2f76" />

---
## 10. Yorum Listesi ve AI ile Toxiclik Analizi

**Açıklama:**
Sigorta makalelerine yapılan tüm kullanıcı yorumlarının listelendiği ve yapay zeka tarafından otomatik olarak toksisite analizine tabi tutulduğu admin yorum yönetim sayfası.

**Özellikler:**
- 📋 **Yorum Listesi:** Ad soyad, ilgili makale, tarih ve analiz durumu bilgilerinin tablo formatında listelenmesi
- 🤖 **AI Toksisite Analizi:** Her yorumun yapay zeka tarafından otomatik olarak analiz edilerek güvenli/toksik olarak sınıflandırılması
- 🟢 **Güvenli Badge:** AI tarafından güvenli bulunan yorumların yeşil "Güvenli" etiketi ile işaretlenmesi
- 🔴 **Toksik Tespit Edildi Badge:** Zararlı, hakaret içeren veya uygunsuz bulunan yorumların kırmızı "Toksik Tespit Edildi" etiketi ve pembe satır arka planı ile vurgulanması
- 🗑️ **Yorum Silme:** Toksik veya uygunsuz yorumları sistemden kaldırma butonu
- 🔍 **Yorum Arama:** Yorum listesinde anahtar kelime ile arama yapabilme
- 📅 **Tarih Bilgisi:** Her yorumun yayınlanma tarihinin listelenmesi
- 📰 **Makale Bağlantısı:** Yorumun hangi makaleye ait olduğunun kısaltılmış başlık ile gösterimi
- 🧭 **Breadcrumb:** Sayfa üstünde navigasyon yolu gösterimi

<img width="1866" height="951" alt="Admin Yorum - Yorum Listesi" src="https://github.com/user-attachments/assets/bb6813d1-2a07-4b16-8f6b-9b1f359ed68e" />

---
## 11. Ödeme Listesi ve Yönetimi
**Açıklama:**
Sistemde tanımlı tüm fiyat planlarının listelendiği, aktif/pasif durumlarının yönetildiği ve yapay zeka destekli sigorta plan önerisi oluşturulabildiği admin ödeme planları yönetim sayfası.

**Özellikler:**
- 📋 **Ödeme Planı Listesi:** Plan başlığı, fiyat ve durum bilgilerinin tablo formatında listelenmesi (Standart Paket, Ekonomik Paket, Premium Paket vb.)
- 💰 **Fiyat Bilgisi:** Her planın aylık/yıllık prim tutarının TL cinsinden gösterimi
- 🟢 **Aktif/Pasif Durum Badge:** Planın aktif (yeşil) veya pasif (kırmızı) durumunun renkli badge ile gösterimi
- 🔄 **Aktif/Pasif Yap:** Tek tıkla planın aktif veya pasif duruma alınabilmesi
- ✏️ **Güncelle:** Mevcut plan bilgilerini düzenleyebileceğiniz güncelleme butonu
- 🗑️ **Sil:** Ödeme planını sistemden kaldırma butonu
- ➕ **Yeni Fiyat Planı Girişi:** Admin tarafından manuel yeni ödeme planı ekleme
- 🤖 **AI Destekli Sigorta Plan Önerisi:** Yapay zeka ile otomatik sigorta plan önerisi oluşturma aracı
- 🔍 **Arama:** Ödeme planları arasında anahtar kelime ile arama yapabilme
- 🧭 **Breadcrumb:** Sayfa üstünde navigasyon yolu gösterimi

<img width="1869" height="793" alt="Admin Ödeme - Ödeme Listesi" src="https://github.com/user-attachments/assets/b87983e1-1812-46d5-9add-9cd52e97abdb" />

---
## 12. Hizmet Yönetimi
**Açıklama:**
Sigorta hizmetlerinin listelendiği, eklendiği ve düzenlendiği admin hizmet yönetim sayfası. Her hizmet için başlık, görsel ve açıklama bilgileri yönetilebilir.

**Özellikler:**
- 📋 **Hizmetler Listesi:** Başlık ve açıklama bilgilerinin tablo formatında listelenmesi (Araç Sigortası, Konut Sigortası, Sağlık Sigortası, Seyahat Sigortası, İş Yeri Sigortası vb.)
- 🛡️ **Hizmet İkonu:** Her hizmet satırında kalkan ikonu ile görsel tanımlama
- ✏️ **Düzenle:** Mevcut hizmet bilgilerini güncelleyebileceğiniz form (Başlık, Görsel URL, İkon Görseli, Açıklama)
- 🗑️ **Sil:** Hizmet kaydını sistemden kaldırma butonu
- ➕ **Yeni Hizmet Ekle:** Yeni hizmet oluşturmak için form sayfası (Başlık, Görsel, İkon Görseli, Açıklama, Hizmet Bilgisi Kaydet butonu)
- 🖼️ **Çift Görsel Desteği:** Her hizmet için hem kapak görseli hem de ikon görseli ayrı ayrı tanımlanabilmesi
- 📝 **Açıklama Alanı:** Hizmetin detaylı açıklamasının girilebileceği çok satırlı metin alanı
- 🔍 **Arama:** Hizmet listesinde anahtar kelime ile arama yapabilme
- 🧭 **Breadcrumb:** Sayfa üstünde navigasyon yolu gösterimi

<img width="1867" height="749" alt="Admin Hizmet - Hizmet Listesi" src="https://github.com/user-attachments/assets/2389f940-52b4-4dc3-9cd9-26e8ad84b4a3" />
<img width="1868" height="913" alt="Admin Hizmet - Hizmet Ekleme" src="https://github.com/user-attachments/assets/5b03af33-4d48-4374-b0d2-11e7f88c80c2" />
<img width="1866" height="911" alt="Admin Hizmet - Hizmet Düzenleme" src="https://github.com/user-attachments/assets/1b393132-f23a-4b33-8540-8708da627aa2" />

---

## 13. Hakkımızda Yönetimi
**Açıklama:**
Hakkımızda sayfası içerik yönetimi — üst ve alt bölümler ayrı ayrı düzenlenebilir. Yalnızca tek bir içerik kaydı tanımlanabilir, mevcut içerik Düzenle butonu ile güncellenebilir.

**Özellikler:**
- 📋 **İçerik Listesi:** Hakkımızda sayfasına ait başlık ve açıklama metninin tablo formatında listelenmesi
- 👁️ **Sitede Gör:** İçeriğin canlı sitedeki görünümüne yönlendiren önizleme butonu
- ✏️ **Düzenle:** Mevcut hakkımızda içeriğini güncelleyebileceğiniz düzenleme formu (Başlık, Açıklama metni, Görsel vb.)
- 🗑️ **Sil:** Mevcut içerik kaydını sistemden kaldırma butonu
- ➕ **Yeni Hakkımızda Yazısı Ekle:** Yeni içerik oluşturmak için ekleme butonu
- ⚠️ **Tekil İçerik Uyarısı:** Hakkımızda sayfası için yalnızca 1 adet içerik tanımlanabildiğine dair mavi bilgilendirme banner'ı
- 🔍 **İçerik Arama:** Mevcut içerikler arasında anahtar kelime ile arama yapabilme
- 🧭 **Breadcrumb:** Sayfa üstünde navigasyon yolu gösterimi (Hakkımızda > Hakkımızda Listesi)


<img width="1864" height="952" alt="Admin Hakkımızda - Üst Bölüm" src="https://github.com/user-attachments/assets/b3cef565-bc54-4114-8356-c6d743224e13" />
<img width="1863" height="952" alt="Admin Hakkımızda - Düzenleme Formu" src="https://github.com/user-attachments/assets/93872f4d-2382-4d29-96a9-cbc23f098bde" />

---

## 14. Alt Hakkımızda Yönetimi

**Açıklama:**
Hakkımızda sayfasının alt bölümünde gösterilen madde listesinin yönetildiği sayfa. Her madde ayrı ayrı eklenebilir, düzenlenebilir ve silinebilir. Gemini AI ile otomatik madde oluşturma desteği sunar.

**Özellikler:**
- 📋 **Madde Listesi:** Hakkımızda bölümüne ait tüm alt maddelerin sıralı tablo formatında listelenmesi
- ✅ **Önizleme Görünümü:** Maddelerin sitede mavi onay ikonu ile birlikte nasıl göründüğünün önizlemesi
- 👁️ **Gör:** İlgili maddeyi canlı sitede görüntüleme butonu
- ✏️ **Düzenle:** Mevcut madde metnini güncelleyebileceğiniz form (Alt Açıklama alanı ve Güncelle butonu)
- 🗑️ **Sil:** Madde kaydını sistemden kaldırma butonu
- ➕ **Yeni Madde Ekle:** Hakkımızda bölümüne yeni alt madde ekleme butonu
- 🤖 **Gemini ile Öge Oluştur:** Google Gemini AI kullanarak otomatik madde içeriği üretme butonu
- ⚠️ **Limit Bilgisi:** Hakkımızda bölümünde en fazla 3 madde tanımlanabildiğine dair sarı uyarı banner'ı
- 🔍 **Madde Arama:** Mevcut maddeler arasında anahtar kelime ile arama yapabilme
- 🧭 **Breadcrumb:** Sayfa üstünde navigasyon yolu gösterimi (Hakkımızda > Hakkımızda Alt Ögeler Listesi)


<img width="1864" height="952" alt="Admin Hakkımızda - Üst Bölüm" src="https://github.com/user-attachments/assets/b3cef565-bc54-4114-8356-c6d743224e13" />
<img width="1863" height="952" alt="Admin Hakkımızda - Düzenleme Formu" src="https://github.com/user-attachments/assets/93872f4d-2382-4d29-96a9-cbc23f098bde" />
<img width="1864" height="952" alt="Admin Hakkımızda - Üst Bölüm" src="https://github.com/user-attachments/assets/b3cef565-bc54-4114-8356-c6d743224e13" />
<img width="1863" height="952" alt="Admin Hakkımızda - Düzenleme Formu" src="https://github.com/user-attachments/assets/93872f4d-2382-4d29-96a9-cbc23f098bde" />

---
## 15. İletişim Bilgileri Bölümü




---
### Hakkımızda Alt Bölüm

<img width="1866" height="952" alt="Admin Hakkımızda - Alt Bölüm Listesi" src="https://github.com/user-attachments/assets/01c7bcb2-7af9-40e3-b020-ac59d122a417" />
<img width="1620" height="233" alt="Admin Hakkımızda - Alt Bölüm Özet" src="https://github.com/user-attachments/assets/3f8ac339-711b-48e3-b35a-04e9c939f42d" />
<img width="652" height="307" alt="Admin Hakkımızda - Alt Bölüm Detay" src="https://github.com/user-attachments/assets/ca952956-214c-443c-9c53-5d05001ebbb5" />





---
<img width="1867" height="742" alt="Admin Hakkımızda - Alt Bölüm Düzenleme" src="https://github.com/user-attachments/assets/c6df27a8-cd11-4d81-a0a6-a9b63523ac46" />
<img width="1871" height="629" alt="Admin Hakkımızda - Ekleme Formu" src="https://github.com/user-attachments/assets/ade66ab6-a77d-4593-8a9c-173280bf8834" />
<img width="1864" height="659" alt="Admin Hakkımızda - Güncelleme" src="https://github.com/user-attachments/assets/b109f78b-5dc5-460e-9f35-61658bdf24a1" />


## 6. Yorum Yönetimi

**Açıklama:** Kullanıcı yorumlarını listeleme ve moderasyon.

<img width="1866" height="951" alt="Admin Yorum - Yorum Listesi" src="https://github.com/user-attachments/assets/bb6813d1-2a07-4b16-8f6b-9b1f359ed68e" />

---

## 7. Ödeme Yönetimi

**Açıklama:** Gerçekleştirilen ödemeleri listeleme ve takip.

<img width="1869" height="793" alt="Admin Ödeme - Ödeme Listesi" src="https://github.com/user-attachments/assets/b87983e1-1812-46d5-9add-9cd52e97abdb" />

---

## 8. Hizmet Yönetimi


<img width="1867" height="749" alt="Admin Hizmet - Hizmet Listesi" src="https://github.com/user-attachments/assets/2389f940-52b4-4dc3-9cd9-26e8ad84b4a3" />
<img width="1868" height="913" alt="Admin Hizmet - Hizmet Ekleme" src="https://github.com/user-attachments/assets/5b03af33-4d48-4374-b0d2-11e7f88c80c2" />
<img width="1866" height="911" alt="Admin Hizmet - Hizmet Düzenleme" src="https://github.com/user-attachments/assets/1b393132-f23a-4b33-8540-8708da627aa2" />

---

## 9. Slider Yönetimi

**Açıklama:** Ana sayfadaki hero banner slider içeriklerini yönetme.

<img width="1869" height="877" alt="Admin Slider - Slider Listesi" src="https://github.com/user-attachments/assets/d6ef4942-c1ae-4895-aebf-0f7d64fda768" />
<img width="1864" height="950" alt="Admin Slider - Slider Ekleme" src="https://github.com/user-attachments/assets/a2825bc6-1a8a-40ad-96c6-2d7a3247dbf0" />
<img width="1866" height="950" alt="Admin Slider - Slider Düzenleme" src="https://github.com/user-attachments/assets/a1621316-8e44-4ab1-a9b5-5634bb5a51d1" />

---

## 10. Referans Yönetimi

**Açıklama:** Ana sayfada görünen müşteri referanslarını yönetme.

<img width="1865" height="952" alt="Admin Referans - Referans Listesi" src="https://github.com/user-attachments/assets/0837593d-94ef-4f9e-a1f7-cbb891842cb2" />
<img width="1865" height="948" alt="Admin Referans - Referans Ekleme" src="https://github.com/user-attachments/assets/cfed602d-a757-484a-a8f9-2d41cb882e12" />
<img width="1866" height="950" alt="Admin Referans - Referans Düzenleme" src="https://github.com/user-attachments/assets/8312ce20-8389-4fe9-b5ea-e9942888f515" />

---

## 11. Video Yönetimi

**Açıklama:** Site üzerindeki video içeriklerini ekleme ve düzenleme.

<img width="1601" height="277" alt="Admin Video - Video Listesi" src="https://github.com/user-attachments/assets/fa404ac4-1110-4040-a97f-7636181475a8" />
<img width="1610" height="427" alt="Admin Video - Video Ekleme" src="https://github.com/user-attachments/assets/402da8c4-aeaf-4656-8623-979c595042e6" />
<img width="1620" height="450" alt="Admin Video - Video Düzenleme" src="https://github.com/user-attachments/assets/bf3ae3a7-e3f7-46d1-a300-a098ca40a401" />

---

## 12. AI Modül Yönetimi

**Yol:** `/Admin/AI/Index`

**Açıklama:** Yapay zeka chatbot ayarlarını ve yanıt şablonlarını yönetme.

**Özellikler:**
- 🤖 Chatbot yanıt geçmişi
- ⚙️ AI parametreleri ayarlama
- 📊 Chatbot kullanım istatistikleri
- 📝 Özelleştirilmiş yanıt şablonları

<img width="1872" height="954" alt="Admin AI - AI Modül Yönetimi" src="https://github.com/user-attachments/assets/552fdf35-71fc-40aa-97bd-a7ed354cdf02" />

---

## 13. Kategori Yönetimi

**Açıklama:** Sigorta ürünleri için kategori listeleme ve yönetimi.

<img width="1865" height="960" alt="Admin Kategori - Kategori Listesi" src="https://github.com/user-attachments/assets/5e63b8a8-9e07-4f79-83c3-52ce56b892c8" />

---

## 14. Makale Yönetimi

**Açıklama:** Blog/makale içeriklerini oluşturma, düzenleme ve yayınlama.

<img width="1865" height="948" alt="Admin Makale - Makale Listesi" src="https://github.com/user-attachments/assets/1b546e70-a84f-4893-83df-8338f25a82b9" />
<img width="1866" height="954" alt="Admin Makale - Makale Ekleme" src="https://github.com/user-attachments/assets/ed821de9-4f34-4986-9c5f-9ebbbcf8c6ca" />
<img width="1865" height="954" alt="Admin Makale - Makale Düzenleme" src="https://github.com/user-attachments/assets/dc8974b6-827e-42cd-965a-be47147e2f76" />

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

<img width="385" height="337" alt="InsureYouAI Logo" src="https://github.com/user-attachments/assets/401855f1-8de7-4414-8869-7e387e1a4f47" />

Teşekkürler! Bu projeyi kullandığınız veya katkıda bulunduğunuz için memnuniyet duyarım.  
Her türlü geri bildirime açığım.

**İyi kodlamalar! 🚀**
