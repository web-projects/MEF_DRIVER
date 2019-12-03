using System.Collections.Generic;
using XO.Common.DAL;

namespace XO.Responses.DAL
{
    public class LinkDALResponse : LinkFutureCompatibility
    {
        public List<LinkErrorValue> Errors { get; set; }

        public LinkDALIdentifier DALIdentifier { get; set; }
        public List<LinkDeviceResponse> Devices { get; set; }
        public bool OnlineStatus { get; set; }

        //WorkflowControls only used when request Action = 'DALStatus'; can be null
        public LinkWorkflowControls WorkflowControls { get; set; }
    }
}
