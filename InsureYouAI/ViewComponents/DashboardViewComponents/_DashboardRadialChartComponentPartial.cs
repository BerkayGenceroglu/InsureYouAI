using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.DashboardViewComponents
{
    public class _DashboardRadialChartComponentPartial : ViewComponent
    {
        private readonly InsureContext _ınsureContext;

        public _DashboardRadialChartComponentPartial(InsureContext ınsureContext)
        {
            _ınsureContext = ınsureContext;
        }

        public IViewComponentResult Invoke()
        {
            var TotalPolicyCount = _ınsureContext.Policies.Count();
            var ActivePolicyCount = _ınsureContext.Policies.Where(p => p.Status == "active").Count();
            ViewBag.TotalPolicyCount = TotalPolicyCount;
            ViewBag.CompletedPolicyCount = ActivePolicyCount;
            return View();
        }
    }
}
