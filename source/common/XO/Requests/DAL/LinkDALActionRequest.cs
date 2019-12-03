using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XO.Requests.DAL
{
    public partial class LinkDALActionRequest : LinkFutureCompatibility
    {
        public XO.Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            // No validation on these values
            return null;
        }

        public LinkDALActionType? DALAction { get; set; }

        public LinkDeviceUIRequest DeviceUIRequest { get; set; }
    }

    //DAL action selection
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LinkDALActionType
    {
        SendReset,
        GetStatus,
        GetPayment,
        GetCreditOrDebit,
        GetPIN,
        GetZIP,
        GetIdentifier,
        GetIdentifierAndPayment,
        GetIdentifierAndHoldData,
        UseHeldData,
        DeviceUI
    }
}
