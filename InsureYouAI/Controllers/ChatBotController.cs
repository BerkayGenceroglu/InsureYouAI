using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.Controllers
{
    public class ChatBotController : Controller
    {
        public IActionResult SendChatWithAI()
        {
            return View();
        }
    }
}
