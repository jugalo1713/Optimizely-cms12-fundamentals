using ModuleBProject.Web.constants;
using ModuleBProject.Web.Icons;
using ModuleBProject.Web.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace ModuleBProject.Web.Models.Pages
{
    [ContentType(DisplayName = "Standard",
        GUID = "{5C163476-E354-43A5-8067-65BDC8F7CB50}",
        GroupName = SiteGroupNames.Common,
        Description = "Use this page type unless you need a more specialized one.")]
    [SitePageIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) },
Exclude = new[] { typeof(ProductPage) })]
    public class StandardPage: SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }
        public virtual EmployeeBlock Author { get; set; }
    }
}
