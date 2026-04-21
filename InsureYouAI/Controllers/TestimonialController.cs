using InsureYouAI.Context;
using InsureYouAI.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json;

namespace InsureYouAI.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly InsureContext _context;

        public TestimonialController(InsureContext context)
        {
            _context = context;
        }

        public IActionResult TestimonialList()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial Testimonial)
        {
            _context.Testimonials.Add(Testimonial);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial Testimonial)
        {
            _context.Testimonials.Update(Testimonial);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        public async Task<IActionResult> CreateTestimonialWithClaudeAI()
        {
            string ApiKey = "";
            //Anthropic Claude API'sine erişim için şifren (anahtarın

            string Prompt = "Bir Sigorta Şirketi için Testimonial Bölümü yani Referanslar bölümü oluşturdum,6 tane Örnek Veri Girişleri Gerekiyor Kişinin Adı-Soyadı,Unvanı,Yorumu,Görsel Url Olucak Bana istediklerimi oluştur ve ver";
            //Claude'a ne yapmasını istediğini söyleyen mesaj

            using var client = new HttpClient();
            //HTTP istekleri göndermek için bir "tarayıcı" oluşturur. using sayesinde işi bitince otomatik temizlenir

            client.BaseAddress = new Uri("https://api.anthropic.com/");
            //Tüm isteklerin gideceği ana adresi belirler.

            client.DefaultRequestHeaders.Add("x-api-key", ApiKey);
            client.DefaultRequestHeaders.Add("anthropic-version", "2024-06-01");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //a) x - api - key
            //Ne yapar: API anahtarını header'a ekler.
            //b) anthropic - version
            //Ne yapar: Hangi API versiyonunu kullandığını belirtir.
            //c) Accept
            //Ne yapar: "Ben cevabı JSON formatında istiyorum" der.

            var requestBody = new
            {
                model = "claude-3-opus-20240229",/*Hangi Claude modelini kullanacağını belirtir.*/
                max_tokens = 512,/*Claude'un maksimum kaç kelime/token üretebileceğini sınırla*/
                temperature = 0.5,/*Cevabın yaratıcılık/rastgelelik seviyesi.*/
                messages = new[]
                {
                    new
                    {
                        role = "user",
                        content = Prompt
                    }
                }
            };

            var jsonContent = new StringContent(JsonSerializer.Serialize(requestBody));
            //C# nesnesini JSON string'ine çevirir ve HTTP içeriği olarak hazırlar

            var responseMessage = await client.PostAsync("v1/messages", jsonContent);
            // v1 / message endpoint'ine POST isteği gönderir 

            if (!responseMessage.IsSuccessStatusCode)
            {
                ViewBag.services = new List<string>
                {
                    $"Claude AI Servisleri Getirilirken Bir Hata Oluştu: {responseMessage.StatusCode}"
                };
                return View();
            }

            var responseString = await responseMessage.Content.ReadAsStringAsync();
            //HTTP cevabının içeriğini string olarak okur

            using var doc = JsonDocument.Parse(responseString);
            //: JSON string'ini bir jsondocument türünde bir nesneye çevirir

            var fullText = doc.RootElement
                            .GetProperty("content")[0]
                            .GetProperty("text")
                            .GetString();
            //JSON'un en üst seviyesine (root) erişir.
            //Content adlı prop dizesindeki ilk elamana erişir.
            //ulaşılan elmanın text adlı prop'una erişir ve string olarak alır.


            var testimonials = fullText.Split('\n')
                               .Where(x => !string.IsNullOrWhiteSpace(x))
                               .Select(x => x.TrimStart('1', '2', '3', '4', '5', '.', ' '))
                               .ToList();
            // Metni her satır başında böler.
            //Boş veya sadece boşluk içeren satırları filtreler (atar).
            //Her satırın başındaki rakamları, noktaları ve boşlukları siler.
            ViewBag.testimonials = testimonials;
            return View();
        }
    }
}
