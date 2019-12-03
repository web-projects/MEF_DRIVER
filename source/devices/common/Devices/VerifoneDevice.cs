using Devices.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Composition;
using System.Text;

namespace Devices.Common.Devices
{
    [Export(typeof(Common.Interfaces.ICardDevice))]
    [Export("Verifone Device", typeof(ICardDevice))]
    internal class VerifoneDevice : ICardDevice
    {
        public string Name => "Device Verifone";

        public void DeviceSetIdle()
        {
        }
    }
}
