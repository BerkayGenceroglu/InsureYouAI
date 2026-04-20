using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsureYouAI.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailAboutAuthorComponentPartial:ViewComponent
    {
        private readonly InsureContext _context;

        public _BlogDetailAboutAuthorComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int ArticleId)
        {
            var author = _context.Articles.Where(y => y.ArticleId == ArticleId).Include(x => x.AppUser).FirstOrDefault();
            return View(author);
        }
    }
}
