using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.DashboardViewComponents
{
    public class _DashboardSubWidgetComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _DashboardSubWidgetComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.TotalCategoryCount = _context.Categories.Count();
            ViewBag.TotalArticleCount = _context.Articles.Count();
            ViewBag.TotalPoliciesCount = _context.Policies.Count();

            var startOfMont = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var startOfNextMonth = startOfMont.AddMonths(1);
            ViewBag.TotalPoliciesByThisMonthCount = _context.Policies.Where(p => p.CreatedDate >= startOfMont && p.CreatedDate < startOfNextMonth).Count();

            ViewBag.TotalCommentsCount = _context.Comments.Count();
            ViewBag.TotalUserCount = _context.Users.Count();
            ViewBag.AvgPolicyAmount = _context.Policies.Average(p => p.PremiumAmount);
            ViewBag.LatestRevenueAmount = _context.Revenues.OrderByDescending(b => b.RevenueId).Take(1).Select(n => n.Amount).FirstOrDefault();
            return View();
        }


    }
}
