using Prototype.Framework;

namespace Devices
{
    public class SonyStereo
        : DeviceTemplate
    {
        public SonyStereo()
            : base()
        {
            this.ID = "{9D4D41D9-AC4A-4736-A45E-CDFEF8D6542C}";
            this.Category = "Audio";
            this.Name = "Stereo";
            this.Manufacturer = "Sony";
        }
    }
}
