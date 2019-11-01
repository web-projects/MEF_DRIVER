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

        public bool DiscoverDevices(string name)
        {
            ICardDevice device = DeviceProvider.GetDevice(name);

            if (device == null)
                throw new Exception("Unable to get a device");

            //if (!(device is VerifoneDevice))
            //    throw new Exception("Only Verifone Devices are currently supported.");

            return device.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
