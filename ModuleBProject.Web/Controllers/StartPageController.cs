using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using ModuleBProject.Web.Models.Pages;

namespace ModuleBProject.Web.Controllers
{
    [TemplateDescriptor(Inherited = true)]
    public class StartPageController : PageController<StartPage>
    {
        public IActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}
