using InsureYouAI.Context;
using InsureYouAI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.BlogViewComponents
{
    public class _BlogCategoriesComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _BlogCategoriesComponentPartial(InsureContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            //var categories = _context.Categories.ToList();

            var categories = _context.Categories.Select(x => new CategoryArticleCountViewModel
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                ArticleCount = x.Articles.Count
            }).ToList();
            return View(categories);
        }
    }
}
