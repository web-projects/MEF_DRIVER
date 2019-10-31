using MEFDriver;
using System;
using Xunit;
using Ninject;
using Ninject.Modules;
using MEFDriver.Interfaces;
using System.Reflection;

namespace devices
{
    public class CardDevice : NinjectModule
    {
        MEFDriver.CardDevice subject;

        public override void Load()
        {
            Bind<ICardDevice>().To<MockDevice>();

            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var mailSender = kernel.Get<ICardDevice>();
        }

        [Fact]
        public void CardDevice_ReturnsTrue_When_VerifoneCreatesVerifoneDevice()
        {
            subject = new MEFDriver.VerifoneDevice();
            string expected = "Verifone Device";
            Assert.Equal(expected, subject.Name);
        }

        [Fact]
        public void CardDevice_ReturnsFalse_When_VerifoneCreatesIdTechDevice()
        {
            subject = new MEFDriver.IdTechDevice();
            string expected = "Verifone Device";
            Assert.NotEqual(expected, subject.Name);
        }

        [Fact]
        public void CardDevice_ReturnsTrue_When_IdTechCreatesIdTechDevice()
        {
            subject = new MEFDriver.IdTechDevice();
            string expected = "IdTech Device";
            Assert.Equal(expected, subject.Name);
        }

        [Fact]
        public void CardDevice_ReturnsFalse_When_IdTechCreatesVerifoneDevice()
        {
            subject = new MEFDriver.IdTechDevice();
            string expected = "Verifone Device";
            Assert.NotEqual(expected, subject.Name);
        }
    }
}
