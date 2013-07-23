using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prototype.Framework;

namespace Prototype.Mocks
{
    public class MockDeviceRepository
        : IDeviceTemplateRepository
    {
        private DeviceTemplate[] _Devices = new DeviceTemplate[]{
            new DeviceTemplate { ID= "1", Category="Audio", Manufacturer="Sony", Name="Stereo" },
            new DeviceTemplate { ID= "2", Category="Video", Manufacturer="LG", Name="Projector" },
            new DeviceTemplate { ID= "3", Category="Lighting", Manufacturer="GE", Name="Lamp" },
        };

        public MockDeviceRepository() { }


        public IEnumerable<DeviceTemplate> GetDevices()
        {
            return _Devices;
        }
    }
}