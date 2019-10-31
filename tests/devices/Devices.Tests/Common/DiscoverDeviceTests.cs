using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using Ninject;
using Devices.Common;
using Devices.Common.Interfaces;

namespace Devices.Tests.Common
{
    public class DiscoverDeviceTests
    {
        DiscoverDevice subject;

        Mock<IDeviceProvider> mockDeviceProvider;

        public DiscoverDeviceTests()
        {
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
        }

        [Fact]
        public void DiscoverDevice_ShouldThrowException_WhenDeviceProviderReturnsNullDevice()
        {
            mockDeviceProvider.Setup(e => e.GetDevice(It.IsAny<string>())).Returns<ICardDevice>(null);
            Action subjectAction = () => subject.DiscoverDevices();
            Assert.Throws<Exception>(subjectAction);
        }

        [Fact]
        public void DiscoverDevice_ShouldThrowException_WhenDeviceProviderReturnsIdTechDevice()
        {
            ICardDevice device = new IdTechDevice();
            mockDeviceProvider.Setup(e => e.GetDevice(It.IsAny<string>())).Returns(device);
            Action subjectAction = () => subject.DiscoverDevices();
            Assert.Throws<Exception>(subjectAction);
        }

        [Fact]
        public void DiscoverDevice_ShouldReturnTrue_WhenDeviceIsVerifone()
        {
            ICardDevice device = new VerifoneDevice();
            mockDeviceProvider.Setup(e => e.GetDevice(It.IsAny<string>())).Returns(device);
            Assert.True(subject.DiscoverDevices());
        }
    }
}
