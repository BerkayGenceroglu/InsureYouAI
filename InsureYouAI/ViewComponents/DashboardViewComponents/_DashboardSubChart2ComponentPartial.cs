using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace InsureYouAI.ViewComponents.DashboardViewComponents
{
    public class _DashboardSubChart2ComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _DashboardSubChart2ComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var EnddateTime = new DateTime(2026, 5, 1);
            var StartdateTime = new DateTime(2025, 10, 1);

            var monthlyData = await _context.Policies
                 .Where(x => x.CreatedDate >= new DateTime(2025, 10, 1) &&
                            x.CreatedDate <= new DateTime(2026, 5, 1))
                .GroupBy(p => p.StartDate.Month)
                .Select(g => new
                {
                    Month = g.Key,
                    TotalPremium = g.Sum(x => x.PremiumAmount)
                })
                .ToListAsync();

            // 12 aylık dizi (boş ayları 0 olarak gösterecek)
            decimal[] revenues = new decimal[12];
            foreach (var item in monthlyData)
            {
                revenues[item.Month - 1] = item.TotalPremium;
            }

            ViewBag.MonthlyRevenues = revenues;

            return View();
        }
    }
}
