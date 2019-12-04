using Devices.Common.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Sdk
{
    class Program
    {
        static internal List<ICardDevice> AvailableCardDevices { get; private set; }
        static internal ICardDevice TargetDevice { get; set; }

        [Inject]
        static IDevicePluginLoader DevicePluginLoader { get; set; }

        static void Main(string[] args)
        {
            string pluginPath = Path.Combine(Environment.CurrentDirectory, "DevicePlugins");
            if(Initialize(pluginPath))
            {
                LoadPlugin();
            }

        }

        static bool Initialize(string pluginPath)
        {
            // TODO: Find available plugins available to us.
            DevicePluginLoader = new DevicePluginLoader();
            AvailableCardDevices = DevicePluginLoader.FindAvailableDevices(pluginPath);

            // TODO: Utilizing the plugins we must check our configuration to determine
            // the preferred device we are interested in working with.
            if (AvailableCardDevices?.Count > 0)
            {
                TargetDevice = AvailableCardDevices[0];
            }

            return TargetDevice != null;
        }

        static void LoadPlugin()
        {
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine("List of available device plugins:");
            Console.WriteLine("===================================");
            foreach (var pluginName in DevicePluginLoader.GetAvailableDevicePlugins())
            {
                Console.WriteLine(pluginName);
            }
            Console.WriteLine();
            Console.WriteLine($"load: {TargetDevice.Name}");
            DevicePluginLoader.LoadDevicePlugin(TargetDevice.GetType().Name);
        }
    }
}