using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.DashboardViewComponents
{

    public class _DashboardSubChartsComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _DashboardSubChartsComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
