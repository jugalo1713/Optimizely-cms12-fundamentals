using Microsoft.AspNetCore.Mvc;
using ModuleBProject.Web.Models.Pages;

namespace ModuleBProject.Web.Controllers
{
    public class StandardPageController: PageControllerBase<StandardPage>
    {
        public StandardPageController(IContentLoader loader) : base(loader)
        {
        }
        public IActionResult Index(StandardPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}
