using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prototype.Framework;

namespace Prototype.Mocks
{
    public class MockWidgetRepository
        : IWidgetTemplateRepository
    {
        private WidgetTemplate[] _widgets = new WidgetTemplate[]{
               new MockSliderWidgetTemplate(), 
            };

        public WidgetTemplate GetWidget(string widgetName)
        {
            return _widgets.First(x => x.Name == widgetName);
        }

        public IEnumerable<WidgetTemplate> GetWidgets()
        {
            return _widgets;
        }
    }

}