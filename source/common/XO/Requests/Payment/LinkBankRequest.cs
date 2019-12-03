using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XO.Requests
{
    public class LinkBankRequest : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            // No validation on these values
            return null;
        }

        public string RoutingNumber { get; set; }
        public string AccountNumber { get; set; }
        public LinkBankAccountType? BankAccountType { get; set; }
        public string CheckNumber { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LinkBankAccountType
    {
        Unspecified,
        Checking,
        Savings
    }
}
