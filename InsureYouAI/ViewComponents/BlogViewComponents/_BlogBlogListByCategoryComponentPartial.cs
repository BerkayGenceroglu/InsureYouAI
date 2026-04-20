using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Core;

namespace InsureYouAI.ViewComponents.BlogViewComponents
{
    public class _BlogBlogListByCategoryComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _BlogBlogListByCategoryComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int categoryId)
        {
            var values = _context.Articles.Where(y => y.CategoryId == categoryId).Include(c => c.Category).Include(u => u.AppUser).ToList();
            return View(values);
        }
    }
}
