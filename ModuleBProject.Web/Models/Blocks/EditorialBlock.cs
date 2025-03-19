using ModuleBProject.Web.constants;
using ModuleBProject.Web.Icons;
using ModuleBProject.Web.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace ModuleBProject.Web.Models.Blocks
{
    [ContentType(
        DisplayName = "Editorial",
        GUID = "{AC35F72B-0418-4F1F-9F4D-DDA5580BD250}",
        Description = "UUse this for a rich editorial text that will be reused in multiple places",
        GroupName = SiteGroupNames.Common
        )]
    [SiteBlockIcon]
    public class EditorialBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Main Body",
            GroupName = SystemTabNames.Content,
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables",
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }
    }
}
