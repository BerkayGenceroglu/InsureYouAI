using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsureYouAI.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailContentComponentPartial:ViewComponent
    {
        private readonly InsureContext _context;

        public _BlogDetailContentComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int ArticleId)
        {
            var value = _context.Articles.Include(y =>y.Category).Include(x => x.AppUser).Where(b => b.ArticleId == ArticleId).FirstOrDefault();
            ViewBag.CommentCount = _context.Comments.Where(y => y.ArticleId ==ArticleId).Count();
            return View(value);
        }
    }
}
