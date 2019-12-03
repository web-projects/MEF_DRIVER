using System.Collections.Generic;
using XO.Common.DAL;

namespace XO.Responses.DAL
{
    public class LinkDeviceResponse : LinkFutureCompatibility
    {
        public List<LinkErrorValue> Errors { get; set; }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string TerminalId { get; set; }
        public string SerialNumber { get; set; }

        //CardWorkflowControls only used when request Action = 'DALStatus'; can be null
        public LinkCardWorkflowControls CardWorkflowControls { get; set; }
    }
}
