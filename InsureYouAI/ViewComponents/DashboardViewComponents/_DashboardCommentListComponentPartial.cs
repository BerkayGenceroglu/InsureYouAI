using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace InsureYouAI.ViewComponents.DashboardViewComponents
{
    public class _DashboardCommentListComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _DashboardCommentListComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var comments = await _context.Comments.Include(y => y.AppUser).OrderByDescending(c =>c.CommentId).Take(7).ToListAsync();
            return View(comments);
        }
    }
}
