using InsureYouAI.Context;
using InsureYouAI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.DashboardViewComponents
{
    public class _DashboardPolicyTypesComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _DashboardPolicyTypesComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var policyTypes = _context.Policies.GroupBy(y => y.PolicyType).Select(c => new PolicyTypeByCountViewModel
            {
                PolicyType = c.Key,
                Count = c.Count()
            }).ToList();
            return View(policyTypes);
        }
    }
}
