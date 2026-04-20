using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.DefaultViewComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        private readonly InsureContext _ınsureContext;

        public _DefaultTestimonialComponentPartial(InsureContext ınsureContext)
        {
            _ınsureContext = ınsureContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _ınsureContext.Testimonials.ToList();
            return View(values);
        }
    }
}
