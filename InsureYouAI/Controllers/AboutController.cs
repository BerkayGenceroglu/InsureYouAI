using InsureYouAI.Context;
using InsureYouAI.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace InsureYouAI.Controllers
{
    public class AboutController : Controller
    {
        private readonly InsureContext _context;

        public AboutController(InsureContext context)
        {
            _context = context;
        }

        public IActionResult AboutList()
        {
            ViewBag.Controller = "Hakkımızda";
            ViewBag.Page = "Hakkımızda Listesi";
            var values = _context.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            ViewBag.Controller = "Hakkımızda";
            ViewBag.Page = "Hakkımızda Ekle";
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            _context.Abouts.Add(about);
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            ViewBag.Controller = "Hakkımızda";
            ViewBag.Page = "Hakkımızda Güncelle";
            var value = _context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            _context.Abouts.Update(about);
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public IActionResult DeleteAbout(int id)
        {
            var value = _context.Abouts.Find(id);
            _context.Abouts.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public async Task<IActionResult> CreateAboutWithGemini()
        {
            var Apikey = "";
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
                                text ="Kurumsal Bir Sigorta Firması için Etkileyici,Güven Verici ve Profesyonel bir Hakkımızda alt madde Yazıları Oluştur."
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
