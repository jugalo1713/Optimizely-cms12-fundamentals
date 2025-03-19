using ModuleBProject.Web.constants;
using ModuleBProject.Web.Icons;
using System.ComponentModel.DataAnnotations;

namespace ModuleBProject.Web.Models.Pages
{
    [ContentType(
        DisplayName = "Start",
        GUID = "{3ED56ECA-3851-4D18-8EAE-95CCCA1C4332}",
        Description = "The home page for a website with an area for blocks and partial pages",
        GroupName = SiteGroupNames.Specialized,
        Order = 10)]
    [SiteStartIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) })]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
        Name = "Heading",
        Description = "Heading",
        GroupName = SystemTabNames.Content,
        Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
        Name = "MainBody",
        Description = "MainBody",
        GroupName = SystemTabNames.Content,
        Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
        Name = "MainContentArea",
        Description = "MainContentArea",
        GroupName = SystemTabNames.Content,
        Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData),
            typeof(ImageData), typeof(ContentFolder))]
        public virtual ContentArea MainContentArea { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer text",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string FooterText { get; set; }

        [Display(Name = "Search page",
            Description = "If you add a Search page to the site, set this property to reference it to enable search from every page.",
            GroupName = SiteTabNames.SiteSettings,
            Order = 40)]
        [AllowedTypes(typeof(SearchPage))]
        public virtual PageReference SearchPageLink { get; set; }
    }
}