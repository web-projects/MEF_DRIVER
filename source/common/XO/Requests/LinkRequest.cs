using System.Collections.Generic;

namespace XO.Requests
{
    //Base IPALink5 request
    //Note: request sent from POS and used internally by all IPA components
    public partial class LinkRequest : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate()
        {
            if (LinkObjects != null)
            {
                return new Responses.LinkErrorValue     // TODO: update with correct values for missing required value
                {
                    Code = "LinkObjectRequired",
                    Type = "MissingLinkObject",
                    Description = "You are missing fields required for this request to be processed."
                };
            }

            return null;
        }

        public string MessageID { get; set; }
        public int TCCustID { get; set; }
        public string TCPassword { get; set; }
        public bool? Synchronous { get; set; }
        public int? Timeout { get; set; }
        public string AgencyKey { get; set; }
        public string IPALicenseKey { get; set; }
        public string UserName { get; set; }

        public List<LinkActionRequest> Actions { get; set; }

        //Note: specific to internal IPA operations; not defined for customer use; customer input parsers should return error if these values are specified
        public LinkRequestIPA5Object LinkObjects { get; set; }
    }
}
