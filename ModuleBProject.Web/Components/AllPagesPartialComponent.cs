using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using ModuleBProject.Web.constants;
using ModuleBProject.Web.Models.Pages;
using ModuleBProject.Web.Models.ViewModels;
namespace ModuleBProject.Web.Components
{
    [TemplateDescriptor(Inherited = true,
    Tags = new[] { SiteTags.Full }, AvailableWithoutTag = true)]
    public class AllPagesFullPartialComponent : PartialContentComponent<SitePageData>
    {
        protected override IViewComponentResult InvokeComponent(SitePageData currentContent)
        {
            return View(viewName: SiteTags.Full, model: PageViewModel.Create(currentContent));
        }
    }

    [TemplateDescriptor(Inherited = true,
    Tags = new[] { SiteTags.Wide }, AvailableWithoutTag = true)]
    public class AllPagesWidePartialController : PartialContentComponent<SitePageData>
    {
        protected override IViewComponentResult InvokeComponent(SitePageData currentContent)
        {
            return View(viewName: SiteTags.Wide, model: PageViewModel.Create(currentContent));
        }
    }

    [TemplateDescriptor(Inherited = true,
    Tags = new[] { SiteTags.Narrow }, AvailableWithoutTag = true)]
    public class AllPagesNarrowPartialController : PartialContentComponent<SitePageData>
    {
        protected override IViewComponentResult InvokeComponent(SitePageData currentContent)
        {
            return View(viewName: SiteTags.Narrow, model: PageViewModel.Create(currentContent));
        }
    }

}
