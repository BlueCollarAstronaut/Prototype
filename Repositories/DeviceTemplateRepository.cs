using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Devices;
using Prototype.Framework;

namespace Repositories
{
    public class DeviceTemplateRepository
        : IDeviceTemplateRepository
    {
        private DeviceTemplate[] _Templates;
        
        public DeviceTemplateRepository()
        {
        }

        private void Initialize()
        {
            // TODO: This should dynamically find all relevant items:

            List<DeviceTemplate> templateList = new List<DeviceTemplate>();
            templateList.Add(new PanasonicProjector());
            templateList.Add(new SonyStereo());
            _Templates = templateList.ToArray();
        }


        public IEnumerable<DeviceTemplate> GetDevices()
        {
            if (_Templates == null)
                Initialize();
            return _Templates;
        }
    }
}
