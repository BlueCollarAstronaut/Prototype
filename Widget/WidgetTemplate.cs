using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Framework
{
    public class WidgetTemplate
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string TemplateCodeSnippet { get; set; }
            

        public virtual string CreateCodeSnippet(string itemId) {
            return "";
        }
    }
}
