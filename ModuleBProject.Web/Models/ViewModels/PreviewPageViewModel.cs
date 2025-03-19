using ModuleBProject.Web.Models.Pages;

namespace ModuleBProject.Web.Models.ViewModels
{
    public class PreviewPageViewModel : PageViewModel<SitePageData>
    {
        public PreviewPageViewModel(SitePageData currentPage,
        IContent contentToPreview) : base(currentPage)
        {
            PreviewContentArea.Items.Add(new ContentAreaItem
            { ContentLink = contentToPreview.ContentLink });
        }
        public ContentArea PreviewContentArea { get; set; }
        = new ContentArea();
    }
}
