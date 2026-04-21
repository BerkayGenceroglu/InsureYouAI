using InsureYouAI.Context;
using InsureYouAI.Entities;
using InsureYouAI.Services;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Net.Http.Headers;
using System.Text.Json;

namespace InsureYouAI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly InsureContext _context;
        private readonly AIService _AIService;
        public DefaultController(InsureContext context, AIService aIService)
        {
            _context = context;
            _AIService = aIService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Message message)
        {
            //Database'e Mesajı Kaydetme
            message.IsRead = false;
            message.SendDate = DateTime.Now;
            var combinedText = $"{message.Subject} {message.MessageDetail}";
            var predictedCategory = await _AIService.PredictCategoryAsync(combinedText);
            var predictedPriority = await _AIService.PredictPriorityAsync(combinedText);

            message.Priority = predictedPriority;
            message.AICategory = predictedCategory;
            _context.Messages.Add(message);
            _context.SaveChanges();

            #region OpenAI API'sine Bağlanma ve Cevap Alma İşlemi
            var apikey = "";

            var prompt = @"Sen bir sigorta firmasının müşteri iletişim asistanısın.
            Kurumsal ama samimi, net ve anlaşılır bir dille yaz.
            Yanıtlarını 2–3 paragrafla sınırla.
            Eksik bilgi (poliçe numarası, kimlik vb.) varsa kibarca talep et.
            Fiyat, ödeme, teminat gibi kritik konularda kesin rakam verme, müşteri temsilcisine yönlendir.
            Hasar ve sağlık gibi hassas durumlarda empati kur.
            Cevaplarını teşekkür ve iyi dilekle bitir.";

            var userMessage = message.MessageDetail;
            
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", apikey); // ✅ Eklendi

            var requestData = new
            {
                model = "gpt-4o",
                messages = new[]
                {
                new { role = "system", content = prompt },
                new { role = "user",   content = userMessage }
            },
                temperature = 0.7
            };

            var response = await httpClient.PostAsJsonAsync(
                "https://api.openai.com/v1/chat/completions", requestData);

      
                //JsonElement bunu class olmadan okuman için bir araç, ikisi de aynı sonucu verir.Küçük projelerde JsonElement pratiktir, büyük projelerde class tanımlamak daha okunabilirdir.
                var result = await response.Content.ReadFromJsonAsync<JsonElement>();
                var assistantMessage = result
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString();
            #endregion

            #region Mail Gönderme İşlemi
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("InsureYouAI Admin", "projectbrky123@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", message.Email);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();

            bodyBuilder.TextBody = assistantMessage;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "InsureYou Email Yanıt";

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("projectbrky123@gmail.com", "vcdfuimhgfhvbfcm");
            client.Send(mimeMessage);
            client.Disconnect(true);
            #endregion

            #region OpenAI API'den Gelen Cevabı Veritabanına Kaydetme
            _context.openAIMessages.Add(new OpenAIMessage
            {
               MessageDetail = assistantMessage,
               ReceiveEmail = message.Email,
                ReceiveNameSurname = message.NameSurname ,
                SendDate = DateTime.Now
            });
            _context.SaveChanges();
            #endregion

            TempData["Message"] = "Mesajınız başarıyla gönderildi. En kısa sürede size geri dönüş yapılacaktır.";

            //Gelen Maile Göre Kullanıcıya Bir Cevap Verme İşlemi
            return Redirect("/Default/Index#contact");
        }

        public PartialViewResult SubscribeMessage()
        {
            return PartialView();
        }


        [HttpPost]
        public IActionResult SubscribeMessage(Message Message)
        {
            return View();
        }
    }
}
