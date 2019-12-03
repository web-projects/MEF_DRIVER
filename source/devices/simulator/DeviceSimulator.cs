using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Devices.Common;
using Devices.Common.Interfaces;

namespace Devices.Simulator
{
    [Export(typeof(Common.Interfaces.ICardDevice))]
    [Export("Simulator-UI", typeof(ICardDevice))]
    internal class DeviceSimulator : ICardDevice
    {
        public string Name => StringValueAttribute.GetStringValue(DeviceType.Simulator);

        public void DeviceSetIdle()
        {
        }
    }
}
