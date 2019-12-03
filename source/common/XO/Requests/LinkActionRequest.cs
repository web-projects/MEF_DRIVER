using XO.Requests.DAL;
using XO.Requests.Payment;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XO.Requests
{
    public class LinkActionRequest : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true, LinkDALRequest sessionLinkDALRequest = null)
        {
            var genericErrorResponse = new Responses.LinkErrorValue     // TODO: update with correct values for missing required value
            {
                Code = "GenericLinkError",
                Type = "UnknownErrorInActionValidation",
                Description = "You are missing fields required for this request to be processed."
            };

            if (LinkObjects != null)
            {
                return genericErrorResponse;
            }

            if (!synchronousRequest && string.IsNullOrEmpty(RequestID))
            {
                return genericErrorResponse;
            }

            if (sessionLinkDALRequest != null)
            {
                // Validating IdleActions; only DeviceUI currently allowed

                if (((Action ?? LinkAction.Payment) != LinkAction.DALAction) || ((DALActionRequest?.DALAction ?? LinkDALActionType.GetPayment) != LinkDALActionType.DeviceUI))
                    return genericErrorResponse;
            }

            return ValidateAction(Action, genericErrorResponse, sessionLinkDALRequest, synchronousRequest);
        }

        private Responses.LinkErrorValue ValidateAction(LinkAction? payment, Responses.LinkErrorValue genericErrorResponse,
            LinkDALRequest sessionLinkDALRequest, bool synchronousRequest)
        {
            switch (payment ?? LinkAction.Payment)
            {
                case LinkAction.Payment:
                    if (PaymentRequest == null)
                        return genericErrorResponse;

                    var paymentRequestError = PaymentRequest.Validate(synchronousRequest);
                    // Note: DALRequest may also be required, but that cannot be determined until further in the workflow
                    if (paymentRequestError != null)
                        return paymentRequestError;
                    break;


                case LinkAction.ActionStatus:
                    if (string.IsNullOrEmpty(RequestID))
                        return genericErrorResponse;
                    break;


                case LinkAction.PaymentUpdate:
                    if (PaymentUpdateRequest == null)
                        return genericErrorResponse;

                    var paymentUpdateRequestError = PaymentUpdateRequest.Validate(synchronousRequest);
                    // Note: DALRequest may also be required, but that cannot be determined until further in the workflow
                    if (paymentUpdateRequestError != null)
                        return paymentUpdateRequestError;
                    break;


                case LinkAction.DALAction:
                    if ((DALActionRequest == null) || ((DALRequest == null) && (sessionLinkDALRequest == null)) || ((DALRequest != null) && (sessionLinkDALRequest != null)))
                        return genericErrorResponse;

                    var dalActionRequestError = DALActionRequest.Validate(synchronousRequest);
                    if (dalActionRequestError != null)
                        return dalActionRequestError;

                    dalActionRequestError = DALRequest?.Validate(synchronousRequest);
                    if (dalActionRequestError != null)
                        return dalActionRequestError;
                    break;


                case LinkAction.EstablishProxy:
                    if (DALRequest == null)
                        return genericErrorResponse;

                    var dalRequestError = DALRequest.Validate(synchronousRequest);
                    if (dalRequestError != null)
                        return dalRequestError;
                    break;
            }

            return null;
        }

        public string MessageID { get; set; }
        public string RequestID { get; set; }
        public string SessionID { get; set; }
        public LinkAction? Action { get; set; }
        public bool? AbortOnError { get; set; }
        public int? Timeout { get; set; }


        //Payment only used when Action = 'Payment'; can be null
        public LinkPaymentRequest PaymentRequest { get; set; }


        //Payment only used when Action = 'PaymentUpdate'; can be null
        public LinkPaymentUpdateRequest PaymentUpdateRequest { get; set; }


        //DAL action request used when Action = 'Payment' or 'DALAction'; can be null
        public LinkDALActionRequest DALActionRequest { get; set; }

        //DAL controls; can be null
        public LinkDALRequest DALRequest { get; set; }


        //Session controls; can be null
        public LinkSessionRequest SessionRequest { get; set; }


        //Note: specific to internal IPA operations; not defined for customer use; customer input parsers should return error if these values are specified
        public LinkActionRequestIPA5Object LinkObjects { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LinkAction
    {
        Payment,
        ActionStatus,
        PaymentUpdate,
        DALAction,
        EstablishProxy,
        Report,
        Session
    }
}
