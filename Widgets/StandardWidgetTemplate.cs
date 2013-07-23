using System.Configuration;
using Prototype.Framework;

namespace Widgets
{
    public abstract class StandardWidgetTemplate
        : WidgetTemplate
    {
        protected string ImageKey;

        protected StandardWidgetTemplate(string imageKey)
            : base()
        {
            ImageKey = imageKey;
            TemplateCodeSnippet = GetStandardCodeSnippet();
        }

        protected string GetStandardCodeSnippet()
        {
            string src = ConfigurationManager.AppSettings.Get(ImageKey);
            string snippet = string.Format("<img src='{0}' style='height:100%; width:100%;' />",
                /* 0 */ src);
            return snippet;
        }
    }
}
