using System;
using System.Collections.Generic;
using System.Text;

namespace Devices.Common.Interfaces
{
    public interface ICardDevice
    {
        string Name { get; }

        void DeviceSetIdle();
    }
}
