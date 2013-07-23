using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prototype.Framework;

namespace Prototype.ViewModels
{
    public class DeviceViewModel
    {
        public Project Project { get; set; }
        public DeviceTemplate[] AvailableDevices { get; set; }
    }
}