using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.DefaultViewComponents
{
    public class _DefaultCounterComponentPartial:ViewComponent
    {
        private readonly InsureContext _context;

        public _DefaultCounterComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.CategoryCount = _context.Categories.Count();
            ViewBag.ServiceCount = _context.Services.Count();
            ViewBag.UserCount = _context.Users.Count();
            ViewBag.AIArticleCount = _context.Articles.Count();
            return View();
        }
    }
}
