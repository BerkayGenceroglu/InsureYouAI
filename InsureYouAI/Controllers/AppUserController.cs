using InsureYouAI.Context;
using InsureYouAI.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace InsureYouAI.Controllers
{
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly InsureContext _context;
        private readonly IHttpClientFactory _httpClientFactory;
        public AppUserController(UserManager<AppUser> userManager, InsureContext context, IHttpClientFactory httpClientFactory)
        {
            _userManager = userManager;
            _context = context;
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult UserList()
        {
            var users = _userManager.Users.ToList();    
            return View(users);
        }
        public async Task<IActionResult> UserProfileWithAI(string id)
        {
            var user =await _userManager.FindByIdAsync(id);
            ViewBag.Name = user.Name + " " + user.Surname;
            ViewBag.ImageUrl = user.ImageUrl;
            ViewBag.Description = user.Description;
            ViewBag.CountryCity = user.CountryCity;
            ViewBag.Education = user.Education;
            ViewBag.TitleValue = user.Title;

            //Kullanıcı Bilgilerine Göre AI ile İçerik Üretme İşlemleri Burada Yapılacak
            var userInformation = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();/* HTTP 404(Not Found) yanıtı döndürür.*/
            }
            //Kullanıcıya Ail Makale Listesi
            var articles =await _context.Articles.
                                Where(y => y.AppUserId ==id).
                                Select(b => b.Content).
                                ToListAsync();
            if (articles.Count == 0)
            {
                ViewBag.AIResult = "Bu Kullanıcıya ait analiz Yapılacak Makale Bulunamamıştır";
                return View(user);
            }


            var allArticles = string.Join("\n\n", articles);
            //Birden fazla string’i alır, aralarına senin verdiğin ayırıcıyı koyarak tek bir string haline getirir.
            var apiKey = "";

            var prompt = $@"
                            Siz bir sigorta sektöründe uzman bir içerik analistisin.
                            Elinizde, bir sigorta şirketi için bir kullanıcının yazdığı tüm makaleler var.
                            Bu makaleler üzerinden çalışan içerik üretim tarzını analiz et.

                            Analiz Başlıkları:

                            1) Konu çeşitliliği ve odak alanları (sağlık, hayat, kasko, tamamlayıcı, BES vb.)
                            2) Hedef kitle tahmini (bireysel/kurumsal, segment, persona)
                            3) Dil ve Anlatım Tarzı (tekniklik seviyesi, okunabilirlik, ikna gücü)
                            4) Sigorta terimlerini kullanma ve doğruluk düzeyi
                            5) Müşteri ihtiyaçlarına ve risk yönetimine odaklanma
                            6) Pazarlama/satış vurgusu, CTA netliği
                            7) Geliştirilmesi gereken alanlar ve net aksiyon maddeleri
                            
                                Makaleler:{allArticles}
                    Lütfen Çıktıyı profesyonel rapor formatında,madde madde detaylı ve en sonda 5 maddelik aksiyon listesi ile ver.";
            using (var client = _httpClientFactory.CreateClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                var requestData = new
                {
                    model = "gpt-3.5-turbo", //model = "gpt-3.5-turbo": Hangi yapay zeka modelini kullanacağını söylüyorsun
                    messages = new object[]
                    {
                        new { role = "system", content = "Sen Sigorta Sektöründe Blog İçeriklerini Analiz Eden bir profesyonel,uzmansın" },
                        new { role = "user", content = prompt }
                    },
                    max_tokens = 1000, //max_tokens = 1000: Üretilen cevabın maksimum uzunluğunu belirler
                    temperature = 0.7 //Yapay zekanın ne kadar yaratıcı olacağını belirler
                };
                //json dönüşümleri

                var json = JsonSerializer.Serialize(requestData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonString = await responseMessage.Content.ReadAsStringAsync();
                    var jsonDoc = JsonDocument.Parse(jsonString);
                    var value = jsonDoc.RootElement
                        .GetProperty("choices")[0]
                        .GetProperty("message")
                        .GetProperty("content")
                        .GetString();
                    ViewBag.AIContent = value;
                    return View();
                }
                else
                {
                    ViewBag.AIResult = "AI içerik oluşturulurken bir hata oluştu." + responseMessage.StatusCode;
                    return View(user);
                }
            }
        }

        public async Task<IActionResult> UserCommentWithAI(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            ViewBag.Name = user.Name + " " + user.Surname;
            ViewBag.ImageUrl = user.ImageUrl;
            ViewBag.Description = user.Description;
            ViewBag.CountryCity = user.CountryCity;
            ViewBag.Education = user.Education;
            ViewBag.TitleValue = user.Title;

            //Kullanıcı Bilgilerine Göre AI ile İçerik Üretme İşlemleri Burada Yapılacak
            var userInformation = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();/* HTTP 404(Not Found) yanıtı döndürür.*/
            }
            //Kullanıcıya Ail Makale Listesi
            var comments = await _context.Comments.
                                Where(y => y.AppUserId == id).
                                Select(b => b.CommentDetail).
                                ToListAsync();
            if (comments.Count == 0)
            {
                ViewBag.AIResult = "Bu Kullanıcıya ait analiz Yapılacak Yorum Bulunamamıştır";
                return View(user);
            }


            var AllComments = string.Join("\n\n", comments);
            //Birden fazla string’i alır, aralarına senin verdiğin ayırıcıyı koyarak tek bir string haline getirir.
            var apiKey = "";

            var prompt = $@"
                Sen kullanıcı davranış analizi yapan bir yapay zeka uzmanısın.
                Aşağıda yer alan kullanıcı yorumlarını bütüncül bir bakış açısıyla inceleyerek;
                kapsamlı bir değerlendirme yap. 

                Analiz Başlıkları:

                1) Genel Duygu Durumu (pozitif/negatif/nötr)
                2) Toksik içerik var mı? (örnekleriyle)
                3) İlgi alanları / konu başlıkları
                4) İletişim tarzı (samimi, resmi, agresif vb.)
                5) Geliştirilmesi gereken iletişim alanları
                6) 5 Maddelik kısa özet

                Yorumlar:

                {AllComments}";

            using (var client = _httpClientFactory.CreateClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                var requestData = new
                {
                    model = "gpt-3.5-turbo", //model = "gpt-3.5-turbo": Hangi yapay zeka modelini kullanacağını söylüyorsun
                    messages = new object[]
                    {
                        new { role = "system", content = "Sen Bir Kullanıcının Yaptığı Yorumları Analiz Eden Bir Uzmansın" },
                        new { role = "user", content = prompt }
                    },
                    max_tokens = 1000, //max_tokens = 1000: Üretilen cevabın maksimum uzunluğunu belirler
                    temperature = 0.7 //Yapay zekanın ne kadar yaratıcı olacağını belirler
                };
                //json dönüşümleri

                var json = JsonSerializer.Serialize(requestData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonString = await responseMessage.Content.ReadAsStringAsync();
                    var jsonDoc = JsonDocument.Parse(jsonString);
                    var value = jsonDoc.RootElement
                        .GetProperty("choices")[0]
                        .GetProperty("message")
                        .GetProperty("content")
                        .GetString();
                    ViewBag.AIContent = value;
                    return View();
                }
                else
                {
                    ViewBag.AIResult = "AI içerik oluşturulurken bir hata oluştu." + responseMessage.StatusCode;
                    return View(user);
                }
            }
        }
    }
}
