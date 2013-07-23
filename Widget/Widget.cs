using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Framework
{
    public class Widget
    {
        public string ID { get; private set; }
        public WidgetTemplate Template { get; private set; }

        public string CodeSnippet
        {
            get
            {
                return Template.CreateCodeSnippet(ID);
            }
        }

        public Widget(string id, WidgetTemplate template) 
        {
            ID = id;
            Template = template;
        }

        public static Widget CreateWidget(WidgetTemplate template)
        {
            if (template == null)
                throw new ArgumentNullException("template");
            return new Widget(Guid.NewGuid().ToString(), template);
        }
    }
}
