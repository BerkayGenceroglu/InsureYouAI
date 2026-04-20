using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.DashboardViewComponents
{
    public class _DashboardWidgetComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _DashboardWidgetComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.TotalArticles = _context.Articles.Count();
            ViewBag.TotalCategories = _context.Categories.Count();
            ViewBag.TotalUsers = _context.Users.Count();
            ViewBag.TotalComments = _context.Comments.Count();

            return View();
        }

    }
}
 