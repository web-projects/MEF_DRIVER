using System;
using System.Collections.Generic;
using System.Text;
using Devices.Common.Interfaces;

namespace Devices.Common.Interfaces
{
    interface IDeviceProvider
    {
        ICardDevice GetDevice(string deviceName);
    }
}
