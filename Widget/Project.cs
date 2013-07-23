using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Framework
{
    public class Project
    {
        public Device[] Devices { get; private set; }
        public Widget[] Widgets { get; private set; }

        public Project()
        {
            Devices = new Device[]{};
            Widgets = new Widget[]{};
        }

        public void AddDevice(DeviceTemplate template)
        {
            var device = Device.CreateDevice(template);
            Devices = Devices.Union(new Device[]{ device }).ToArray();
        }
        public void RemoveDevice(Device device)
        {
            Devices = Devices.Except(new Device[] { device }).ToArray();
        }
        public void AddWidget(WidgetTemplate template)
        {
            var widget = Widget.CreateWidget(template);
            Widgets = Widgets.Union(new Widget[] { widget }).ToArray();
        }
        public void RemoveWidget(Widget widget)
        {
            Widgets = Widgets.Except(new Widget[] { widget }).ToArray();
        }
    }
}
