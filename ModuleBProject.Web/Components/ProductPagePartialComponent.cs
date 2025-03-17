using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using ModuleBProject.Web.Models.Pages;
using ModuleBProject.Web.Models.ViewModels;
namespace ModuleBProject.Web.Components
{
    public class ProductPagePartialComponent : PartialContentComponent<ProductPage>
    {
        protected override IViewComponentResult InvokeComponent(ProductPage currentContent)
        {
            return View(PageViewModel.Create(currentContent));
        }
    }
}
