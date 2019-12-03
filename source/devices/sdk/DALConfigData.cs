using System.Collections.Generic;

namespace Devices.Sdk
{
    public class DALConfigData
    {
        public string Manufacturer { get; set; }
        public string DynamicLibraryName { get; set; }
        public List<DALConnectInfo> ConnectInfos { get; set; }
    }
}
