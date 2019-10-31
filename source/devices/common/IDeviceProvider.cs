using System;
using System.Collections.Generic;
using System.Text;
using Devices.Common.Interfaces;

namespace Devices.Common
{
    interface IDeviceProvider
    {
        ICardDevice GetDevice(string deviceName);
    }
}
