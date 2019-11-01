using System;
using System.Collections.Generic;
using System.Text;
using Devices.Common.Devices;
using Devices.Common.Interfaces;

namespace Devices.Common.Providers
{
    internal class PaymentDeviceProvider : IDeviceProvider
    {
        public ICardDevice GetDevice(string deviceName) => null;
        /*public ICardDevice GetDevice(string deviceName) =>
            deviceName switch
            {
                "Verifone Device" => new VerifoneDevice(),
                "IdTech Device" => new IdTechDevice(),
                "Simulator Device" => new DeviceSimulator(),
                null => throw new Exception("Invalid device name specified")
            };*/
    }
}
