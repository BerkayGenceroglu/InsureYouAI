using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.BlogViewComponents
{
    public class _BlogLast3RecentBlogComponentPartial:ViewComponent
    {
        private readonly InsureContext _context;

        public _BlogLast3RecentBlogComponentPartial(InsureContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var blogs = _context.Articles.OrderByDescending(b => b.ArticleId).Take(3).ToList();
            return View(blogs);
        }
    }
}
