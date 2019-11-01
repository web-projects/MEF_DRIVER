using System;
using Xunit;
using Ninject;
using Ninject.Modules;
using System.Reflection;
using Devices.Common;
using Devices.Common.Interfaces;
using Devices.Verifone;

namespace Verifone.Device.Tests
{
    public class VerifoneDeviceTests
    {
        VerifoneDevice subject;

        public VerifoneDeviceTests()
        {
            subject = new VerifoneDevice();

            /*
            subject = new DiscoverDevice();

            mockDeviceProvider = new Mock<IDeviceProvider>();

            using (IKernel kernel = new StandardKernel())
            {
                kernel.Settings.InjectNonPublic = true;
                kernel.Settings.InjectParentPrivateProperties = true;

                kernel.Bind<IDeviceProvider>().ToConstant(mockDeviceProvider.Object);
                kernel.Bind<DiscoverDevice>().ToSelf();

                kernel.Inject(subject);
            }
            */
        }

        [Fact]
        public void CardDevice_ReturnsTrue_When_VerifoneCreatesVerifoneDevice()
        {
            subject = new VerifoneDevice();
            string expected = "Verifone Device";
            Assert.Equal(expected, subject.Name);
        }
    }
}
