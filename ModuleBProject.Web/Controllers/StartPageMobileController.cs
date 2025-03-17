using EPiServer.Framework.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using ModuleBProject.Web.Models.Pages;

namespace ModuleBProject.Web.Controllers
{
    [TemplateDescriptor(Inherited = true, AvailableWithoutTag = false,
            Tags = new[] { EPiServer.Framework.Web.RenderingTags.Mobile })]
    public class StartPageMobileController : PageControllerBase<StartPage>
    {
        public StartPageMobileController(IContentLoader loader) : base(loader)
        {
        }

        public IActionResult Index(StartPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}
