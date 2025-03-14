using EPiServer.Framework.Blobs;
using EPiServer.Framework.DataAnnotations;

namespace ModuleBProject.Web.Models.Media
{
    [ContentType(
        DisplayName = "SVG File",
        GUID = "cf07592e-0f46-4a37-8907-3002d2293269",
        Description = "Use this to upload Scalable Vector Graphic (SVG) images.")]
    [MediaDescriptor(ExtensionString = "svg")]
    public class SvgFile : ImageData
    {
        public override Blob Thumbnail { get => base.BinaryData; }
    }
}
