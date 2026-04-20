using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsureYouAI.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailCommentListComponentPartial:ViewComponent
    {
        private readonly InsureContext _context;
        private readonly ILogger<_BlogDetailCommentListComponentPartial> _logger;
        public _BlogDetailCommentListComponentPartial(InsureContext context, ILogger<_BlogDetailCommentListComponentPartial> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _context.Comments.Include(y => y.AppUser).Where(d => d.ArticleId == id && d.CommentStatus =="Yorum Onaylandı").ToListAsync();
            return View(values);
        }
    }
}
