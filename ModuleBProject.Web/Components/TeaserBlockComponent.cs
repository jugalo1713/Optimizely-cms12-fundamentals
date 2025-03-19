using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using ModuleBProject.Web.constants;
using ModuleBProject.Web.Models.Blocks;
using ModuleBProject.Web.Models.ViewModels;

namespace ModuleBProject.Web.Components
{
    [TemplateDescriptor(Tags = new[] { SiteTags.Full },
    AvailableWithoutTag = true)]
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

    [TemplateDescriptor(Tags = new[] { SiteTags.Wide })]
    public class TeaserBlockWideComponent : BlockComponent<TeaserBlock>
    {
        protected override IViewComponentResult InvokeComponent(
        TeaserBlock currentBlock)
        {
            TeaserBlockViewModel viewmodel = new()
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = new Random().Next(300, 900)
            };
            return View(viewName: "wide", model: viewmodel);
        }
    }

    [TemplateDescriptor(Tags = new[] { SiteTags.Narrow })]
    public class TeaserBlockNarrowComponent : BlockComponent<TeaserBlock>
    {
        protected override IViewComponentResult InvokeComponent(
        TeaserBlock currentBlock)
        {
            TeaserBlockViewModel viewmodel = new()
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = new Random().Next(300, 900)
            };
            return View(viewName: "narrow", model: viewmodel);
        }
    }
}
