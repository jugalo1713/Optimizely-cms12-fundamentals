using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace ModuleBProject.Web.Models.Media
{
    [ContentType(
        DisplayName = "Image File",
        GUID = "{BF0622CA-8A11-4546-B798-CD011CAC9159}",
        Description = "Use this to upload image files.")]
    [MediaDescriptor(ExtensionString = "png,gif,jpg,jpeg")]
    public class ImageFile: ImageData
    {
        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }
    }
}
