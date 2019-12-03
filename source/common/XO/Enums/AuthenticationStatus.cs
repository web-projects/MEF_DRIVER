using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XO.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthenticationStatus
    {
        approved,
        invalid,
        expired,
        baddata
    }

}
