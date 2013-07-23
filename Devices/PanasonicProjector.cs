using Prototype.Framework;

namespace Devices
{
    public class PanasonicProjector
        : DeviceTemplate
    {
        public PanasonicProjector()
            : base()
        {
            this.ID = "{95BDC5B9-802C-4135-9DDC-1A6B1BAC384B}";
            this.Category = "Video";
            this.Name = "Projector";
            this.Manufacturer = "Panasonic";
        }
    }
}
