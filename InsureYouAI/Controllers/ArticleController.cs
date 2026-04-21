using InsureYouAI.Context;
using InsureYouAI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace InsureYouAI.Controllers
{
    public class ArticleController : Controller
    {
        private readonly InsureContext _context;

        public ArticleController(InsureContext context)
        {
            _context = context;
        }

        public IActionResult ArticleList()
        {
            ViewBag.Controller = "Makaleler";
            ViewBag.Page = "Makaleler Listesi";
            var values = _context.Articles.Include(y => y.AppUser).Include(x => x.Category).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateArticle()
        {
            ViewBag.Controller = "Makaleler";
            ViewBag.Page = "Makale Ekle";
            var categories = _context.Categories.Select(y => new SelectListItem
            {
                Text = y.CategoryName,
                Value = y.CategoryId.ToString()
            }).ToList();
            ViewBag.Categories = categories;


            var authors = _context.Users.Select(y => new SelectListItem
            {
                Text = y.Name + " " + y.Surname,
                Value = y.Id.ToString()
            }).ToList();
            ViewBag.Authors = authors;
            return View();
        }

        [HttpPost]
        public IActionResult CreateArticle(Article article)
        {
            article.CreatedDate = DateTime.Now;
            _context.Articles.Add(article);
            _context.SaveChanges();
            return RedirectToAction("ArticleList");
        }
        [HttpGet]
        public IActionResult UpdateArticle(int id)
        {
            ViewBag.Controller = "Makaleler";
            ViewBag.Page = "Makale Güncelle ";
            var categories = _context.Categories.Select(y => new SelectListItem
            {
                Text = y.CategoryName,
                Value = y.CategoryId.ToString()
            }).ToList();
            ViewBag.Categories = categories;


            var authors = _context.Users.Select(y => new SelectListItem
            {
                Text = y.Name + " " + y.Surname,
                Value = y.Id.ToString()
            }).ToList();
            ViewBag.Authors = authors;
           
            var value = _context.Articles.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateArticle(Article article)
        {
            _context.Articles.Update(article);
            _context.SaveChanges();
            return RedirectToAction("ArticleList");
        }

        public IActionResult DeleteArticle(int id)
        {
            var value = _context.Articles.Find(id);
            _context.Articles.Remove(value!);
            _context.SaveChanges();
            return RedirectToAction("ArticleList");
        }

        [HttpGet]
        public IActionResult CreateArticleWithOpenAI()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateArticleWithOpenAI(string prompt)
        {
            var apiKey = "";

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            //Bu client ile gönderdiğim her istekte bu header olsun
            //"Bearer":Bu kimlik doğrulama türüdür
            //Bak, benim API anahtarım var(sk-proj - xxx...)Bu anahtarı Bearer yöntemiyle kontrol et

            var requestData = new
            {
                model = "gpt-3.5-turbo", //model = "gpt-3.5-turbo": Hangi yapay zeka modelini kullanacağını söylüyorsun
                messages = new[]
                {
                    new{ role="system",content="Sen bir sigorta şirketi için çalışan ,içerik yazarlığı yapan yapay zekasın.Kullancıının verdiği özet ve anahtar kelimelere göre,sigortacılık sektörüyle ilgili makale üret.En Az 1000 karakter Olsun."},/*,Yapay zekaya karakterini, görevini ve nasıl davranması gerektiğini bildirir.*/
                    new {role="user",content=prompt}//Kullanıcının girdiği metin
                },
                temperature = 0.7 //Yapay zekanın ne kadar yaratıcı olacağını belirler
            };

                //📝 3.content Ne Demek?
                //Content = mesajın içeriği.
                //system için → talimat
                //user için → soru, komut, metin
                //assistant için → AI’ın cevabı

            var response = await client.PostAsJsonAsync("https://api.openai.com/v1/chat/completions", requestData);
            //PostAsJsonAsync:Veriyi otomatik olarak JSON formatına çevirip gönderen bir extension metoddur.
            //Arka planda şunu yapıyor:
            //requestData nesnesini alıyor
            //JsonSerializer ile JSON’a çeviriyor
            //Gövdeye(body) JSON olarak ekliyor
            //Content - Type: application / json ekliyor
            //OpenAI’ye öyle gönderiyor
            //Yani JSON’a dönüştürme işlemini sen yapmıyorsun;
            //PostAsJsonAsync otomatik yapıyor.
            if (response.IsSuccessStatusCode)
            {
                
                var result = await response.Content.ReadFromJsonAsync<OpenAIResponse>();
                var content = result.Choices[0].Message.Content;
                //: OpenAI birden fazla cevap seçeneği gönderebilir, biz ilkini alıyoruz
                ViewBag.Article = content;
            }
            else
            {
                ViewBag.Article = "Bir Hata Oluştu:" + response.StatusCode;
            }
            return View();
        }
        //OpenAI'dan gelen JSON verisini C# nesnesine çevirmek için bu sınıfları kullanıyoruz:
        public class OpenAIResponse
        {
            public List<Choice> Choices { get; set; }
        }
        public class Choice
        {
            public Message Message { get; set; }
        }
        public class Message
        {
            public string Role { get; set; }
            public string Content { get; set; }
        }
    }
}
//“ReadAsStringAsync veriyi byte dizisinden C# stringine çevirir, ama otomatik deserialize etmez.”
//“ReadFromJsonAsync byte’ı otomatik stringe çevirir, sonra otomatik C# nesnesine deserialize eder.”
