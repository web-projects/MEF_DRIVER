using System;
using System.Collections.Generic;
using System.Composition;
using System.Text;
using Devices.Common;
using Devices.Common.Interfaces;

namespace Devices.IdTech
{
    [Export(typeof(Common.Interfaces.ICardDevice))]
    [Export("IdTech-VP5300", typeof(ICardDevice))]
    internal class IdTechDevice : ICardDevice
    {
        public string Name => "Device IdTech";

        public void DeviceSetIdle()
        { 
        }
    }
}
