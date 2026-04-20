using InsureYouAI.Context;
using InsureYouAI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Threading.Tasks;

namespace InsureYouAI.ViewComponents.DashboardViewComponents
{
    public class _DashboardSubChart1ComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _DashboardSubChart1ComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _context.Policies.GroupBy(y => y.PolicyType).Select(x =>
                new 
                {
                    Type = x.Key,
                    Count = x.Count()
                }).ToListAsync();
            ViewBag.PolicyType = values.Select(y => y.Type).ToList();
            ViewBag.PolicyCounts = values.Select(y => y.Count).ToList();
            ViewBag.TotalPolicyCount = values.Sum(y => y.Count);
            return View();
        }
    }
}
