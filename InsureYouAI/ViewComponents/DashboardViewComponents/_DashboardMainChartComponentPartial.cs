using InsureYouAI.Context;
using InsureYouAI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.DashboardViewComponents
{
    public class _DashboardMainChartComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _DashboardMainChartComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            //Revenue
            var RevenueData = _context.Revenues.GroupBy(y => y.ProcessDate.Month).Select(x => new
            {
                Month = x.Key,
                TotalAmount = x.Sum(y => y.Amount)
            }).OrderBy(x => x.Month).ToList();

            //Expense
            var ExpenseData = _context.Expenses.GroupBy(y => y.ProcessDate.Month).Select(x => new
            {
                Month = x.Key,
                TotalAmount = x.Sum(y => y.Amount)
            }).OrderBy(x => x.Month).ToList();

            //All Months
            var AllMonths = RevenueData.Select(x => x.Month).Union(ExpenseData.Select(x => x.Month)).OrderBy(x => x).ToList();

            var model = new RevenueExpenseChartViewModel
            {
                Months = AllMonths.Select(x => new System.Globalization.DateTimeFormatInfo().GetAbbreviatedMonthName(x)).ToList(),
                RevenueTotalPrice = AllMonths.Select(x => RevenueData.FirstOrDefault(r => r.Month == x)?.TotalAmount ?? 0).ToList(),
                ExpenseTotalPrice = AllMonths.Select(x => ExpenseData.FirstOrDefault(e => e.Month == x)?.TotalAmount ?? 0).ToList()
            };
            return View(model);
        }
    }
}
