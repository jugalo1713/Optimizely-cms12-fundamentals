using Microsoft.AspNetCore.Mvc;
using ModuleBProject.Web.Models.Pages;

namespace ModuleBProject.Web.Controllers
{
    public class ProductPageController: PageControllerBase<ProductPage>
    {
        public ProductPageController(IContentLoader loader) : base(loader)
        {
        }
        public ActionResult Index(ProductPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}
