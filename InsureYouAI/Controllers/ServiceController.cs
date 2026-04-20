using InsureYouAI.Context;
using InsureYouAI.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace InsureYouAI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly InsureContext _context;

        public ServiceController(InsureContext context)
        {
            _context = context;
        }

        public IActionResult ServiceList()
        {
            var values = _context.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(Service Service)
        {
            _context.Services.Add(Service);
            _context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = _context.Services.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service Service)
        {
            _context.Services.Update(Service);
            _context.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        public IActionResult DeleteService(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ServiceList");
        }


        public async Task<IActionResult> CreateServiceWithClaudeAI()
        {
            string ApiKey = "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";
            //Anthropic Claude API'sine erişim için şifren (anahtarın

            string Prompt = "Bir Sigorta Şirketi için Hizmetler Bölümü Hazırlamanı İstiyorum.Burada 5 Farklı Hizmet Olmalı.Bana Maksimum 100 Karakterden oluşan cümlelerle 5 tane Hizmet İçeriği Yazar Mısın ?";
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


            var services = fullText.Split('\n')
                               .Where(x => !string.IsNullOrWhiteSpace(x))
                               .Select(x => x.TrimStart('1','2','3','4','5','.',' '))
                               .ToList();
            // Metni her satır başında böler.
            //Boş veya sadece boşluk içeren satırları filtreler (atar).
            //Her satırın başındaki rakamları, noktaları ve boşlukları siler.
            ViewBag.services = services;
            return View();
        }
    }
}
