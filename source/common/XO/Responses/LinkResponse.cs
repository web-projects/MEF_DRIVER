using System.Collections.Generic;

namespace XO.Responses
{
    //Base IPA5 response
    //Note: response returned to POS after processing by IPA
    public class LinkResponse : LinkFutureCompatibility
    {
        //Matches IPALinkRequest MessageID value
        public string MessageID { get; set; }

        public List<LinkErrorValue> Errors { get; set; }

        public List<LinkActionResponse> Responses { get; set; }
    }
}
