using System;
using System.Collections.Generic;
using System.Composition;
using System.Text;
using Devices.Common;
using Devices.Common.Interfaces;

namespace Devices.Verifone
{
    [Export(typeof(Common.Interfaces.ICardDevice))]
    [Export("Verifone-UX300", typeof(ICardDevice))]
    internal class VerifoneDevice : ICardDevice
    {
        public string Name => "Device Verifone";

        public void DeviceSetIdle()
        {
        }
    }
}
