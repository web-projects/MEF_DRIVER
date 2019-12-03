using System;

using System.Net;
using System.Net.Sockets;

namespace Common.Helpers
{
    public static class Client
    {
        public static string GetWorkstationName()
        {
            string ClientName = Dns.GetHostName();

            try
            {
                //this will attempt to get the system variable ENDPOINTNAME - if it is not there then default to the Citrix ClientName variable.
                //TODO: We need to verify the requirement. ENDPOINTNAME was used in TCIPA 4.3, if this is not being used for the exact same purpose, please consider using a different name.
                string EndPointName = Environment.GetEnvironmentVariable("ENDPOINTNAME");
                string EnvClientName = Environment.ExpandEnvironmentVariables("%CLIENTNAME%");
                if (!String.IsNullOrEmpty(EndPointName))
                {
                    ClientName = EndPointName;
                }
                else if (EnvClientName != "%CLIENTNAME%")
                {
                    ClientName = EnvClientName;
                }
            }
            catch (Exception ex)
            {
                //logger?.LogError($"Reciever_IPA5: GetWorkstationName error");
            }

            return ClientName;
        }

        public static string GetDNSName()
        {
            return Dns.GetHostName();
        }

        public static string GetIPv4Address()
        {
            string response;
            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("10.0.2.4", 65530);  // Random IP and port
                var endPoint = socket.LocalEndPoint as IPEndPoint;
                response = endPoint?.Address.ToString();
            }
            return response;
        }

        public static string GetIPv6Address()
        {
            var response = string.Empty;
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                {
                    response = ip.ToString();
                    break;
                }
            }
            return response;
        }

        
     }
}
