using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Devices.Common.Interfaces;

namespace Devices.Simulator
{
    [Export(typeof(Common.Interfaces.ICardDevice))]
    [Export("Simulator-UI", typeof(ICardDevice))]
    internal class DeviceSimulator : ICardDevice
    {
        public string Name => "Simulator Device";

        public void DeviceSetIdle()
        {
        }
    }
}
