namespace InsureYouAI.Models
{
    public class RevenueExpenseChartViewModel
    {
        public List<string> Months { get; set; }
        public List<decimal> RevenueTotalPrice { get; set; }
        public List<decimal> ExpenseTotalPrice { get; set; }
    }
}
