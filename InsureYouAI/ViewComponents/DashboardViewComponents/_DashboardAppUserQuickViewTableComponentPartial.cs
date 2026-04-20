using InsureYouAI.Context;
using InsureYouAI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsureYouAI.ViewComponents.DashboardViewComponents
{
    public class _DashboardAppUserQuickViewTableComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _DashboardAppUserQuickViewTableComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var users = _context.Policies.Include(y => y.appuser).GroupBy(y => y.AppUserId).OrderByDescending(g => g.Count())
                .Select(b => new UsersViewModel
                {
                    ImageUrl = b.FirstOrDefault().appuser.ImageUrl,
                    NameSurname = b.FirstOrDefault().appuser.Name + " " + b.FirstOrDefault().appuser.Surname,
                    UserTotalPolicyCount = b.Count(),
                    UserTotalPolicyAmount = (int)b.Sum(x => x.PremiumAmount)
                }).Take(8).ToList();
            return View(users);
        }
    }
}
