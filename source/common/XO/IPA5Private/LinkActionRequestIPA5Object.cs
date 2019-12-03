using System;
using XO.Requests.DAL;
using XO.Responses;

namespace XO.Requests
{
    public partial class LinkActionRequestIPA5Object
    {
        public Guid RequestID { get; set; }     // Receiver/IPA tracking ID

        public Guid HostID { get; set; }
        public LinkSessionRequest ActiveSession { get; set; }

        public LinkActionResponse ActionResponse { get; set; }
    }
}
