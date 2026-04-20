using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailPrevAndNextPostComponentPartial:ViewComponent
    {
        private readonly InsureContext _context;

        public _BlogDetailPrevAndNextPostComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int ArticleId)
        {
            var article = _context.Articles.FirstOrDefault(a => a.ArticleId == ArticleId);

            var PrevArticle = _context.Articles.Where(a => a.ArticleId < ArticleId).OrderByDescending(a => a.ArticleId).FirstOrDefault();
            var NextArticle = _context.Articles.Where(a => a.ArticleId > ArticleId).OrderBy(a => a.ArticleId).FirstOrDefault();

            ViewBag.PrevArticle = PrevArticle.Title;
            ViewBag.NextArticle = NextArticle.Title;
            return View();
        }
    }
}
