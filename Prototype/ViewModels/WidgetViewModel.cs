using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prototype.Framework;

namespace Prototype.ViewModels
{
    public class WidgetViewModel
    {
        public Project Project { get; set; }
        public WidgetTemplate[] AvailableWidgets { get; set; }
    }
}