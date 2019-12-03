using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XO.Common.DAL
{
    //DAL identification values (Enterprise only)
    public class LinkDALIdentifier : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            // No validation on these values
            return null;
        }

        public string WorkstationName { get; set; }
        public string DnsName { get; set; }
        public string IPv4 { get; set; }
        public string IPv6 { get; set; }
        public string Username { get; set; }
        public bool? Affliate { get; set; }
        public LinkDALLookupPreference? LookupPreference { get; set; }
    }

    //DAL lookup preference selection
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LinkDALLookupPreference
    {
        WorkstationName,
        DnsName,
        IPv4,
        IPv6,
        Username
    }
}
