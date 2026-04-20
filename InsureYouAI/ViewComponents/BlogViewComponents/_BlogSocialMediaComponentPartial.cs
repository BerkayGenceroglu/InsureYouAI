using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.BlogViewComponents
{
    public class _BlogSocialMediaComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
