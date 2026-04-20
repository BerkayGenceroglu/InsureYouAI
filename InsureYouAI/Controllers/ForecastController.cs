using InsureYouAI.Context;
using InsureYouAI.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.Controllers
{
    public class ForecastController : Controller
    {
        private readonly InsureContext _context;
        private readonly ForecastService _forecastService;

        public ForecastController(InsureContext context)
        {
            _context = context;
            _forecastService = new ForecastService();
        }

        public IActionResult Index()
        {
            var salesData = _context.Policies.GroupBy(p => new
            {
                 p.StartDate.Year,
                 p.StartDate.Month
            }).Select(g => new
            {
                Year = g.Key.Year,
                Month = g.Key.Month,
                Count = g.Count()
            }).AsEnumerable()
            .Select(a => new PolicySaleData
            {
                Date = new DateTime(a.Year, a.Month, 1),
                SaleCount = a.Count
            }).OrderBy(c => c.Date).ToList();
            var forecast = _forecastService.ForecastPolicySales(salesData, horizon: 3);
            ViewBag.Forecast = forecast;
            return View(salesData);
        }
    }
}
