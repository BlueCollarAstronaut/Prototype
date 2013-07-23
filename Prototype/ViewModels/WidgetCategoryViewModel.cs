using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prototype.Framework;

namespace Prototype.ViewModels
{
    public class WidgetCategoryViewModel
    {
        public string Category { get; set; }
        public WidgetTemplate[] Widgets { get; set; }
    }
}