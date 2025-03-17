using AlloyTraining.Business.ExtensionMethods;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using EPiServer.Shell.Security;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using ModuleBProject.Web.Models.Pages;
using ModuleBProject.Web.Models.ViewModels;

namespace ModuleBProject.Web.Controllers
{
    public abstract class PageControllerBase<T>: PageController<T> where T : SitePageData    
    {
        protected readonly Injected<UISignInManager> UISignInManager;
        protected readonly IContentLoader loader;
        public PageControllerBase(IContentLoader loader)
        {
            this.loader = loader;
        }
        public async Task<IActionResult> Logout()
        {
            await UISignInManager.Service.SignOutAsync();
            return RedirectToAction("Index");
        }

        protected IPageViewModel<TPage> CreatePageViewModel<TPage>(TPage currentPage) where TPage : SitePageData
        {
            var viewmodel = PageViewModel.Create(currentPage);
            viewmodel.StartPage = loader.Get<StartPage>(ContentReference.StartPage);

            viewmodel.MenuPages = FilterForVisitor
                .Filter(loader.GetChildren<SitePageData>(ContentReference.StartPage))
                .Cast<SitePageData>()
                .Where(page => page.VisibleInMenu);

            viewmodel.Section = currentPage.ContentLink.GetSection();

            return viewmodel;
        }
    }
}
