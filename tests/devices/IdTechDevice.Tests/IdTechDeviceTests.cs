using System;
using Xunit;
using Ninject;
using Ninject.Modules;
using System.Reflection;
using Devices.Common;
using Devices.Common.Interfaces;

namespace IdTechDevice.Tests
{
    public class IdTechDeviceTests
    {
        IdTechDevice subject;

        public IdTechDeviceTests()
        {
            subject = new IdTechDevice();
        }

        [Fact]
        public void CardDevice_ReturnsTrue_When_IdTechCreatesIdTechDevice()
        {
            subject = new IdTechDevice();
            string expected = "IdTech Device";
            Assert.Equal(expected, subject.Name);
        }
    }
}
