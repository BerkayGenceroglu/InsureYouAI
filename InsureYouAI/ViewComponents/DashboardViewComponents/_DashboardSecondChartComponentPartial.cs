using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.DashboardViewComponents
{
    public class _DashboardSecondChartComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _DashboardSecondChartComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Policies.GroupBy(y => y.PolicyType).Select(x => new Models.AiAnalysisChartViewModel
            {
                Name = x.Key,
                Value = x.Count()
            }).Take(3).ToList();
            return View(values);
        }
    }
}
