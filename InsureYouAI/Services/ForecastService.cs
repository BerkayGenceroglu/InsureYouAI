using Microsoft.ML;
using Microsoft.ML.Transforms.TimeSeries;

namespace InsureYouAI.Services
{
    public class PolicySaleData
    {
        public DateTime Date { get; set; }
        public float SaleCount { get; set; }
    }
    public class PolicySalesForecast
    {
        public float[] ForecastedValues { get; set; }
        public float[] LowerBoundValues { get; set; }
        public float[] UpperBoundValues { get; set; }
    }

    public class ForecastService
    {
        private readonly MLContext _mlContext;

        public ForecastService( )
        {
            _mlContext = new MLContext();
        }

        public PolicySalesForecast ForecastPolicySales(List<PolicySaleData> salesData, int horizon = 3)
        {
            int count = salesData.Count;

            var dataView = _mlContext.Data.LoadFromEnumerable(salesData);
            var pipeline = _mlContext.Forecasting.ForecastBySsa(
                outputColumnName: "ForecastedValues",
                inputColumnName: "SaleCount",
                windowSize: Math.Max(2, count / 4),
                seriesLength: Math.Max(4,count / 2),
                trainSize: count - horizon,
                horizon: horizon,
                confidenceLevel: 0.95f,
                confidenceLowerBoundColumn: "LowerBoundValues",
                confidenceUpperBoundColumn: "UpperBoundValues"
                );
            var model = pipeline.Fit(dataView);
            var forecastEngine = model.CreateTimeSeriesEngine<PolicySaleData, PolicySalesForecast>(_mlContext);
            return forecastEngine.Predict();
        }
    }
}
