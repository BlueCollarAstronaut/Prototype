using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Widgets;
using Prototype.Framework;

namespace Repositories
{
    public class WidgetTemplateRepository
        : IWidgetTemplateRepository
    {
        private WidgetTemplate[] _Templates;

        public WidgetTemplateRepository()
        {
        }

        private void Initialize()
        {
            // TODO: This should dynamically find all relevant items:

            List<WidgetTemplate> templateList = new List<WidgetTemplate>();
            templateList.Add(new HorizontalSliderWidgetTemplate());
            templateList.Add(new VerticalSliderWidgetTemplate());
            _Templates = templateList.ToArray();
        }


        public IEnumerable<WidgetTemplate> GetWidgets()
        {
            if (_Templates == null)
                Initialize();
            return _Templates;
        }
    }
}
