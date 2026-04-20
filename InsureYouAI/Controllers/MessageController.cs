using InsureYouAI.Context;
using InsureYouAI.Entities;
using InsureYouAI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InsureYouAI.Controllers
{
    public class MessageController : Controller
    {
        private readonly InsureContext _context;
        private readonly AIService _AIService;

        public MessageController(InsureContext context, AIService aIService)
        {
            _context = context;
            _AIService = aIService;
        }

        public IActionResult MessageList()
        {
            ViewBag.Controller = "Mesajlar";
            ViewBag.Page = "Tarafımıza İletilen Mesaj Listesi";
            var values = _context.Messages.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(Message message)
        {

            var combinedText = $"{message.Subject} {message.MessageDetail}";
            var predictedCategory = await _AIService.PredictCategoryAsync(combinedText);
            var predictedPriority = await _AIService.PredictPriorityAsync(combinedText);

            message.Priority = predictedPriority;
            message.AICategory = predictedCategory;
            message.IsRead = false;
            message.SendDate = DateTime.Now;
            _context.Messages.Add(message);
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }
        [HttpGet]
        public IActionResult UpdateMessage(int id)
        {
            var value = _context.Messages.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateMessage(Message Message)
        {
            _context.Messages.Update(Message);
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value!);
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }
    }
}
