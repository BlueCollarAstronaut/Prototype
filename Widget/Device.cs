using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Framework
{
    public class Device
    {
        public string ID { get; private set; }
        public DeviceTemplate Template { get; private set; }
        
        private Device() { }

        public static Device CreateDevice(DeviceTemplate template)
        {
            if (template == null)
                throw new ArgumentNullException("template");
            return new Device
            {
                ID = Guid.NewGuid().ToString(),
                Template = template,
            };
        }
    }
}
