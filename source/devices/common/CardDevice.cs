using System;
using System.Collections.Generic;
using System.Text;
using Devices.Common.Interfaces;

namespace Devices.Common
{
    public abstract class CardDevice : ICardDevice
    {
        public string Name { get; }

        public CardDevice(string name) => Name = name;
    }
}
