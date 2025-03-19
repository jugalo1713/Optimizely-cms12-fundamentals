using ModuleBProject.Web.Icons;
using System.ComponentModel.DataAnnotations;

namespace ModuleBProject.Web.Models.Blocks
{
    [ContentType(
        DisplayName = "Listing Block",
        GUID = "{0B199129-943B-4E65-8B18-C0D4DF78B009}",
        Description = "Choose a page in the tree, and its children will be listed, with a heading.")]
    [SiteBlockIcon]
    public class ListingBlock: BlockData
    {
        [Display(
            Name = "Heading",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [CultureSpecific]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Show children of this page",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [CultureSpecific]
        public virtual PageReference ShowChildrenOfThisPage { get; set; }
    }
}
