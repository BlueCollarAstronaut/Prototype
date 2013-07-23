using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prototype.Framework;

namespace Prototype.ViewModels
{
    public class DeviceListViewModel
    {
        public DeviceTemplate[] Devices { get; set; }

        public string[] _Manufacturers;
        public string[] Manufacturers
        {
            get
            {
                if (_Manufacturers == null)
                {
                    if (Devices != null)
                    {
                        _Manufacturers = Devices.Select(x => x.Manufacturer).Distinct().ToArray();
                    }
                }
                return _Manufacturers;
            }
            private set { _Manufacturers = value; }
        }



    }
}