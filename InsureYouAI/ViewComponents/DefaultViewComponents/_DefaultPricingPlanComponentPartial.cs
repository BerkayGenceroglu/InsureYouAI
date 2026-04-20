using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsureYouAI.ViewComponents.DefaultViewComponents
{
    public class _DefaultPricingPlanComponentPartial:ViewComponent
    {
        private readonly InsureContext _context;

        public _DefaultPricingPlanComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var ActivePricingPlanItem1 = _context.PricingPlans.Where(x => x.IsFeature == true).FirstOrDefault();
            var ActivePricingPlanItem2 = _context.PricingPlans.Where(x => x.IsFeature == true).OrderByDescending(y => y.PricingPlanId).FirstOrDefault();

            ViewBag.PricingPlanTitle1 = ActivePricingPlanItem1!.Title;
            ViewBag.PricingPlanPrice1 = ActivePricingPlanItem1!.Price;
            ViewBag.PricingPlanId1 = ActivePricingPlanItem1!.PricingPlanId;

            ViewBag.PricingPlanTitle2 = ActivePricingPlanItem2!.Title;
            ViewBag.PricingPlanPrice2 = ActivePricingPlanItem2!.Price;
            ViewBag.PricingPlanId2 = ActivePricingPlanItem2!.PricingPlanId;


            var models = _context.PricingPlanItems.Where(x => x.PricingPlanId == ActivePricingPlanItem1.PricingPlanId || x.PricingPlanId == ActivePricingPlanItem2.PricingPlanId).ToList();
            return View(models);
        }
    }
}
