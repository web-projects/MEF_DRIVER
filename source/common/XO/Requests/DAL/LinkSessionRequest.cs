using System.Collections.Generic;
using XO.Common.DAL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XO.Requests.DAL
{
    public partial class LinkSessionRequest : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true, LinkDALRequest sessionLinkDALRequest = null)
        {
            // No validation on these values; validate child objects

            Responses.LinkErrorValue validationErrors = null;

            if (sessionLinkDALRequest == null)
            {
                validationErrors = new Responses.LinkErrorValue     // TODO: update with correct values for missing required value
                {
                    Code = "DALRequestRequired",
                    Type = "MissingDALRequest",
                    Description = "You are missing fields required for this request to be processed."
                };
            }

            if (validationErrors == null)
                validationErrors = WorkflowControls?.Validate(synchronousRequest);

            if (validationErrors == null)
                validationErrors = CardWorkflowControls?.Validate(synchronousRequest);

            if (validationErrors == null && (IdleActions != null))
            {
                foreach (var idleAction in IdleActions)
                {
                    if (validationErrors == null)
                        validationErrors = idleAction?.Validate(synchronousRequest, sessionLinkDALRequest);
                }
            }

            return validationErrors;
        }

        public LinkSessionActionType? SessionAction { get; set; }

        public bool? Exclusive { get; set; }
        public LinkDALRequest DALRequest { get; set; }
        public int? DefaultCVMAmount { get; set; }
        public string DefaultCVMCurrencyCode { get; set; }
        public LinkWorkflowControls WorkflowControls { get; set; }
        public LinkCardWorkflowControls CardWorkflowControls { get; set; }
        public List<LinkActionRequest> IdleActions { get; set; }


        //Note: specific to internal IPA operations; not defined for customer use; customer input parsers should return error if these values are specified
        public LinkActionRequestIPA5Object LinkObjects { get; set; }
    }


    //DAL action selection
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LinkSessionActionType
    {
        Initialize,
        Shutdown,
        Verify,
        ForceShutdown
    }
}
