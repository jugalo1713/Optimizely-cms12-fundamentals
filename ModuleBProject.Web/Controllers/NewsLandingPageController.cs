using Microsoft.AspNetCore.Mvc;
using ModuleBProject.Web.Models.Pages;

namespace ModuleBProject.Web.Controllers
{
    public class NewsLandingPageController : PageControllerBase<NewsLandingPage>
    {
        public NewsLandingPageController(IContentLoader loader) : base(loader)
        {
        }
        public IActionResult Index(NewsLandingPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}
