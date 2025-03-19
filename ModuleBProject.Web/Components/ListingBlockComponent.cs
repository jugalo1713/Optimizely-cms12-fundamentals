using EPiServer.Filters;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using ModuleBProject.Web.Models.Blocks;
using ModuleBProject.Web.Models.ViewModels;

namespace ModuleBProject.Web.Components
{
    public class ListingBlockComponent : BlockComponent<ListingBlock>
    {
        private readonly IContentLoader _loader;
        public ListingBlockComponent(IContentLoader loader)
        {
            _loader = loader;
        }
        protected override IViewComponentResult InvokeComponent(ListingBlock currentContent)
        {
            ListingBlockViewModel viewmodel = new()
            {
                Heading = currentContent.Heading
            };

            if (currentContent.ShowChildrenOfThisPage != null)
            {
                IEnumerable<PageData> children = _loader.GetChildren<PageData>(
                currentContent.ShowChildrenOfThisPage);
                // Remove pages:
                // 1. that are not published
                // 2. that the visitor does not have Read access to
                // 3. that do not have a page template
                IEnumerable<IContent> filteredChildren =
                FilterForVisitor.Filter(children);
                // 4. that do not have "Display in navigation" selected
                viewmodel.Pages = filteredChildren.Cast<PageData>()
                .Where(page => page.VisibleInMenu);
            }
            return View(viewmodel);
        }

    }
}
