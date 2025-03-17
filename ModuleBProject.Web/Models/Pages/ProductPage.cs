using EPiServer.Shell.ObjectEditing;
using ModuleBProject.Web.Business.SelectionFactories;
using ModuleBProject.Web.constants;
using ModuleBProject.Web.Icons;
using System.ComponentModel.DataAnnotations;

namespace ModuleBProject.Web.Models.Pages
{
    [ContentType(
        DisplayName = "Product",
        GUID = "{2074F4AB-347C-4EE7-8F9A-4892A0437D8C}",
        GroupName = SiteGroupNames.Specialized,
        Description = "Use this for software products that Alloy sells"
        )]
    [SiteCommerceIcon]
    public class ProductPage: StandardPage
    {
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            Theme = "theme1";
        }

        [Display(
            Name = "Product Name",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [SelectOne(SelectionFactoryType = typeof(ThemeSelectionFactory))]
        public virtual string Theme { get; set; }

        [Display(
            Name = "Unique selling points",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [Required]
        [CultureSpecific]
        public virtual IList<string> UniqueSellingPoints { get; set; }
    }
}
