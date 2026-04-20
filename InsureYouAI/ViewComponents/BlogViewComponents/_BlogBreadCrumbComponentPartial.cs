using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.BlogViewComponents
{
    public class _BlogBreadCrumbComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
