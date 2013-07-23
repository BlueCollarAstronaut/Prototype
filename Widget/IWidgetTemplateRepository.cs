using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Framework
{
    public interface IWidgetTemplateRepository
    {
        IEnumerable<WidgetTemplate> GetWidgets();
    }
}
