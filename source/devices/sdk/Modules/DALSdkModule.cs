using Ninject.Modules;

namespace Devices.Sdk.Modules
{
    public class DALSdkModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDevicePluginLoader>().To<DevicePluginLoader>();
        }
    }
}
