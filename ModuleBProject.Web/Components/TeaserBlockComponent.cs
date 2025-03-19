using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using ModuleBProject.Web.Models.Blocks;
using ModuleBProject.Web.Models.ViewModels;

namespace ModuleBProject.Web.Components
{
    public class TeaserBlockComponent : BlockComponent<TeaserBlock>
    {
        protected override IViewComponentResult InvokeComponent(TeaserBlock currentContent)
        {
            TeaserBlockViewModel viewmodel = new()
            {
                CurrentBlock = currentContent,
                TodaysVisitorCount = new Random().Next(300, 900)
            };
            return View(viewmodel);
        }
    }
}
