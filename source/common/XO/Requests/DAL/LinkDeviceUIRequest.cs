using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XO.Requests.DAL
{
    public class LinkDeviceUIRequest : LinkFutureCompatibility
    {
        public XO.Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            // No validation on these values
            return null;
        }

        public LinkDeviceUIActionType? UIAction { get; set; }
        public bool? AutoConfirmKey { get; set; }
        public bool? ReportCardPresented { get; set; }
        public int? MinLength { get; set; }
        public int? MaxLength { get; set; }
        public List<string> DisplayText { get; set; }
    }

    //DeviceUI action selection
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LinkDeviceUIActionType
    {
        DisplayIdle,
        KeyRequest,
        InputRequest,
        Display
    }
}
