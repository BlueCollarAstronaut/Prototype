using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prototype.Framework;

namespace Prototype.Models
{
    public class WorkspaceModel
    {
        public WorkspaceModel()
        {
            Widgets = new WidgetTemplate[] { };
        }

        public WidgetTemplate[] Widgets{ get; set;}
        public void AddWidgets(params WidgetTemplate[] widgets)
        {
            Widgets = Widgets.Union(widgets).ToArray();
        }
    }
}