using EPiServer.Web;
using ModuleBProject.Web.constants;
using System.ComponentModel.DataAnnotations;

namespace ModuleBProject.Web.Models.Pages
{
    public abstract class SitePageData: PageData
    {
        [Display(
            Name = "Meta Title",
            GroupName = SiteTabNames.SEO,
            Order = 10)]
        [UIHint(UIHint.Textarea)]
        [CultureSpecific]
        [StringLength(60, MinimumLength = 5)]
        public virtual string MetaTitle { get; set; }

        [Display(
            Name = "Meta Keywords",
            GroupName = SiteTabNames.SEO,
            Order = 20)]
        [UIHint(UIHint.Textarea)]
        [CultureSpecific]
        public virtual string MetaKeywords { get; set; }

        [Display(
            Name = "Meta Description",
            GroupName = SiteTabNames.SEO,
            Order = 30)]
        [UIHint(UIHint.Textarea)]
        [CultureSpecific]
        public virtual string MetaDescription { get; set; }

        [Display(
            Name = "Page Image",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        [UIHint(UIHint.Image)]
        [CultureSpecific]
        public virtual ContentReference PageImage { get; set; }
    }
}
