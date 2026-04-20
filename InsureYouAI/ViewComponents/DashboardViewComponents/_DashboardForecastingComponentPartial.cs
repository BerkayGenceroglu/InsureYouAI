using InsureYouAI.Context;
using InsureYouAI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using Microsoft.ML.Transforms.TimeSeries;

namespace InsureYouAI.ViewComponents.DashboardViewComponents
{
    public class _DashboardForecastingComponentPartial : ViewComponent
    {
        private readonly InsureContext _context;

        public _DashboardForecastingComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var startDate = DateTime.Now.AddMonths(-6);

            // 1) VERİ HAZIRLIĞI (SON 6 AY + YEAR-MONTH FIX)
            var rawData = _context.Policies
                .Where(x => x.CreatedDate >= startDate)
                .AsEnumerable()
                .GroupBy(x => x.PolicyType)
                .Select(g => new
                {
                    PolicyType = g.Key,
                    MonthlyCounts = g
                        .GroupBy(z => new { z.CreatedDate.Year, z.CreatedDate.Month })
                        .Select(s => new
                        {
                            MonthIndex = s.Key.Year * 12 + s.Key.Month,
                            Count = s.Count()
                        })
                        .OrderBy(s => s.MonthIndex)
                        .ToList()
                })
                .ToList();

            var ml = new MLContext();
            var result = new List<PolicyForecastViewModel>();

            foreach (var item in rawData)
            {
                var mlData = item.MonthlyCounts
                    .Select(m => new PolicyMonthlyData
                    {
                        Value = m.Count
                    });

                var dataView = ml.Data.LoadFromEnumerable(mlData);

                // 2) SSA MODEL (DAHA SAĞLAM AYAR)
                var pipeline = ml.Forecasting.ForecastBySsa(
                    outputColumnName: "Forecast",
                    inputColumnName: "Value",
                    windowSize: 2                                                    ,
                    seriesLength: 6,
                    trainSize: item.MonthlyCounts.Count,
                    horizon: 1
                );

                var model = pipeline.Fit(dataView);//Model Oluşturuluyor

                var engine = model.CreateTimeSeriesEngine<PolicyMonthlyData, PolicyForecastOutput>(ml);//Tahmin motoru oluşturuluyor

                var prediction = engine.Predict();//Tahmin yapılıyor

                int predicted = Math.Max(0, (int)prediction.Forecast[0]);// Negatif tahminleri sıfıra çekiyoruz

                // Sonuçları listeye ekliyoruz
                result.Add(new PolicyForecastViewModel
                {
                    PolicyType = item.PolicyType,
                    ForecastCount = predicted
                });
            }

            // 3) YÜZDE HESABI (DOUBLE FIX)
            var total = result.Sum(x => x.ForecastCount);

            foreach (var item in result)
            {
                item.Percentage = total > 0
                    ? item.ForecastCount * 100 / total
                    : 0;
            }

            return View(result);
        }
    }

            // ML INPUT
            public class PolicyMonthlyData
            {
                public float Value { get; set; }
            }

            // ML OUTPUT
            public class PolicyForecastOutput
            {
                public float[] Forecast { get; set; }
            }
}