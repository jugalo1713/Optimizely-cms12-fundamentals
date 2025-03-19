using EPiServer.Filters;
using EPiServer.Find.Cms;
using EPiServer.Find.Framework;
using EPiServer.Find;
using Microsoft.AspNetCore.Mvc;
using ModuleBProject.Web.Models.Pages;
using ModuleBProject.Web.Models.ViewModels;
using AlloyTraining.Business.ExtensionMethods;

namespace ModuleBProject.Web.Controllers
{
    public class SearchPageController : PageControllerBase<SearchPage>
    {
        public SearchPageController(IContentLoader loader) : base(loader)
        {
        }
        public IActionResult Index(SearchPage currentPage, string q)
        {
            SearchPageViewModel viewmodel = new(currentPage);
            viewmodel.StartPage = loader.Get<StartPage>(ContentReference.StartPage);

            viewmodel.MenuPages = FilterForVisitor.Filter(
            loader.GetChildren<SitePageData>(ContentReference.StartPage))
                .Cast<SitePageData>()
                .Where(page => page.VisibleInMenu);

            viewmodel.Section = currentPage.ContentLink.GetSection();

            if (!string.IsNullOrWhiteSpace(q))
            {
                viewmodel.SearchText = q;
                ITypeSearch<SitePageData> query = SearchClient.Instance
                    .Search<SitePageData>() // 1. only site pages
                    .For(q) // 2. free-text query
                    .FilterForVisitor() // 3. only what the visitor can read
                    .FilterOnCurrentSite(); // 4. only under the Start page
                                            // (e.g. to exclude Wastebasket)

                IContentResult<SitePageData> results = query.GetContentResult();
                viewmodel.SearchResults = results
                .Select(x => new Result
                {
                    Title = x.MetaTitle ?? x.Name,
                    Description = x.MetaDescription?.TruncateAtWord(20),
                    Url = x.PageLink.ExternalURLFromReference()
                }).ToList();
            }
            return View(viewmodel);
        }
    }
}