using InsureYouAI.Context;
using InsureYouAI.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using Newtonsoft.Json;

namespace InsureYouAI.Controllers
{
    public class AboutItemController : Controller
    {
        private readonly InsureContext _context;

        public AboutItemController(InsureContext context)
        {
            _context = context;
        }

        public IActionResult AboutItemList()
        {
            ViewBag.Controller = "Hakkımızda";
            ViewBag.Page = "Hakkımızda Alt Ögeler Listesi";
            var values = _context.AboutItems.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAboutItem()
        {
            ViewBag.Controller = "Hakkımızda";
            ViewBag.Page = "Hakkımızda Alt Öge Ekle";
            return View();
        }

        [HttpPost]
        public IActionResult CreateAboutItem(AboutItem aboutItem)
        {
            _context.AboutItems.Add(aboutItem);
            _context.SaveChanges();
            return RedirectToAction("AboutItemList");
        }
        [HttpGet]
        public IActionResult UpdateAboutItem(int id)
        {
            ViewBag.Controller = "Hakkımızda";
            ViewBag.Page = "Hakkımızda Alt Öge Güncelle";
            var value = _context.AboutItems.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAboutItem(AboutItem aboutItem)
        {
            _context.AboutItems.Update(aboutItem);
            _context.SaveChanges();
            return RedirectToAction("AboutItemList");
        }

        public IActionResult DeleteAboutItem(int id)
        {
            var value = _context.AboutItems.Find(id);
            _context.AboutItems.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("AboutItemList");
        }

        [HttpGet]
        public async Task<IActionResult> CreateAboutItemWithGemini()
        {
            var Apikey = "AIzaSyA4Jqzag-VWY1FfC0Dal4PZgiGniQpvS08";
            var Model = "gemini-2.5-flash";
            var Url = $"https://generativelanguage.googleapis.com/v1/models/{Model}:generateContent?key={Apikey}";
            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new
                            {
                                text ="Bir sigorta şirketinin hakkımda yazısının altında  5 tane  Türkçe alt madde yazar mısın örneğin: \"Geleceğinizi Güvence Altına Alan Kapsamlı ve Güvenilir Bir Sigorta Sunuyoruz "
                            }
                        }
                    }

                 }
            };
            var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            var responseMessage = await client.PostAsync(Url, content);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                using var jsonDoc = JsonDocument.Parse(jsonData);
                //JsonDocument.Parse(jsonData) metodu, JSON dizesini okuyarak, üzerinde gezinebileceğimiz ve belirli verilere hızlıca erişebileceğimiz salt okunur bir dökümana(DOM - Document Object Model) çevirir.
                var generatedText = jsonDoc.RootElement
                    .GetProperty("candidates")[0]
                    .GetProperty("content")
                    .GetProperty("parts")[0]
                    .GetProperty("text")
                    .GetString();
                ViewBag.value = generatedText;
                //jsonDoc.RootElement ifadesi, JSON belgesinin kök öğesine erişir. Bu kök öğe, JSON verisinin en üst düzey yapısını temsil eder.
                //GetProperty("candidates")[0] ifadesi, kök öğe içindeki "candidates" adlı özelliğe erişir ve bu özelliğin ilk öğesini (indeks 0) alır.
                //GetProperty("content") ifadesi, "candidates" öğesi içindeki "content" adlı özelliğe erişir.
                //GetProperty("parts")[0] ifadesi, "content" öğesi içindeki "parts" adlı özelliğe erişir ve bu özelliğin ilk öğesini (indeks 0) alır.
                //GetString() metodu, son olarak erişilen öğenin string değerini alır.
            }

            return View();
        }
    }
}
