using System;
using System.Collections.Generic;
//using XO.Responses;

namespace Devices.Sdk
{
    // TODO: Refactor to use registry
    public class ConnectionConfig
    {
        public bool Valid { get; set; } = false;
        public bool Updated { get; set; }
        public DateTime LastLoaded { get; set; }
        public DateTime LastUpdated { get; set; }
        public List<DALConfigData> ConnectionValues { get; set; }

        //public List<LinkErrorValue> ReadConfig()
        //{
        //    Valid = true;
        //    Updated = false;
        //    LastLoaded = DateTime.UtcNow;
        //    LastUpdated = DateTime.UtcNow;
        //    ConnectionValues = new List<DALConfigData>
        //    {
        //        new DALConfigData
        //        {
        //            Manufacturer = "Mock",
        //            ConnectInfos = new List<DALConnectInfo>
        //            {
        //                new DALConnectInfo
        //                {
        //                    ConnectionType = DALConnectInfo.DALConnectionType.USB,
        //                },
        //            },
        //            DynamicLibraryName = "IPA5.DAL.Device.Mock.dll"
        //        },
        //        new DALConfigData
        //        {
        //            Manufacturer = "IDTech_USDK",
        //            ConnectInfos = new List<DALConnectInfo>
        //            {
        //                new DALConnectInfo
        //                {
        //                    ConnectionType = DALConnectInfo.DALConnectionType.USB,
        //                },
        //            },
        //            DynamicLibraryName = "IPA5.DAL.Device.IDTech.IDTechUSDK.dll"
        //        },
        //        new DALConfigData
        //        {
        //            Manufacturer = "Verifone",
        //            ConnectInfos = new List<DALConnectInfo>
        //            {
        //                new DALConnectInfo
        //                {
        //                    ConnectionType = DALConnectInfo.DALConnectionType.Comm,
        //                    Connection = "COM11"
        //                }
        //            },
        //            DynamicLibraryName = "IPA5.DAL.Device.Verifone.VIPA.dll"
        //        }
        //    };

        //    return null;
        //}

        //public List<LinkErrorValue> WriteConfig()
        //{
        //    return null;
        //}

        //public List<LinkErrorValue> VerifyConfig()
        //{
        //    return null;
        //}
    }
}
