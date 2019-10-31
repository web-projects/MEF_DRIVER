using System;
using System.Collections.Generic;
using System.Text;
using Devices.Common.Interfaces;
using Ninject;

namespace Devices.Common
{
    class DiscoverDevice
    {
        [Inject]
        internal IDeviceProvider DeviceProvider { get; set; }

        public bool DiscoverDevices()
        {
            ICardDevice device = DeviceProvider.GetDevice("Verifone Device");

            if (device == null)
                throw new Exception("Unable to get a device");

            if (!(device is VerifoneDevice))
                throw new Exception("Only Verifone Devices are currently supported.");

            return true;
        }
    }
}
