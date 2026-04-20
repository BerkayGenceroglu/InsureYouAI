using InsureYouAI.Context;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.DefaultViewComponents
{
    public class _DefaultInsureServiceComponentPartial:ViewComponent
    {
        private readonly InsureContext _context;

        public _DefaultInsureServiceComponentPartial(InsureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.InsureServices.ToList();
            return View(values);
        }
    }
}
