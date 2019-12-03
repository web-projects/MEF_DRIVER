namespace Devices.Sdk
{
    public class DALConnectInfo
    {
        public enum DALConnectionType
        {
            Unknown,
            Comm,
            USB,
            TCPIP
        }

        public DALConnectionType ConnectionType { get; set; }
        public string Connection { get; set; }
        public int? Speed { get; set; }
        public int? Timeout { get; set; }
    }
}
