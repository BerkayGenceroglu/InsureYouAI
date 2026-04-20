using InsureYouAI.Context;
using InsureYouAI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsureYouAI.ViewComponents.BlogViewComponents
{
    public class _BlogAllBlogListComponentPartial:ViewComponent
    {
        private readonly InsureContext _context;

        public _BlogAllBlogListComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            //var values = _context.Articles.Include(x => x.Category).Include(y => y.AppUser).ToList();//
            var articles = _context.Articles
                .Include(y => y.Category)
                .Include(z => z.AppUser)
                .Include(c => c.Comments)
                .Select(b => new ArticleListViewModel
                {
                    ArticleId = b.ArticleId,
                    Title = b.Title,
                    CategoryName = b.Category.CategoryName,
                    Author = b.AppUser.Name + " " + b.AppUser.Surname,
                    CreatedDate = b.CreatedDate,
                    ImageUrl = b.CoverImageUrl,
                    Content = b.Content,
                    CommentCount = b.Comments.Count()
                }).ToList();
            return View(articles);
        }
    }
}
