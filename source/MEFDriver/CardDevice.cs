using MEFDriver.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MEFDriver
{
    public class CardDevice : ICardDevice
    {
        public string Name { get; }
        public CardDevice(string name) { this.Name = name;  }
    }
}
