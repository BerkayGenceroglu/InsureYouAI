using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace InsureYouAI.Controllers
{
    public class ImageAIController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ImageAIController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult CreateImageWithOpenAI()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateImageWithOpenAI(string prompt)
        {
            string apiKey = "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";
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            var request = new
            {
                prompt = prompt,
                n = 1,
                size = "512x512"
            };
            var data = JsonSerializer.Serialize(request);
            var content = new StringContent(data,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://api.openai.com/v1/images/generations",content);

            if (!responseMessage.IsSuccessStatusCode)
            {
                ViewBag.Error = "Open AI Hatası:" + await responseMessage.Content.ReadAsStringAsync();
                return View();
            }

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonDocument.Parse(jsonData);
            var value = result.RootElement.
                        GetProperty("data")[0].
                        GetProperty("url").
                        GetString();
            return View(model: value);
            //View’e “model olarak value’yu gönder” demektir.
        }
    }
}
