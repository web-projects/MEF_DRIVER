using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XO.Responses.Payment
{
    public class LinkPaymentResponse : LinkFutureCompatibility
    {
        public List<LinkErrorValue> Errors { get; set; }

        public LinkPaymentResponseStatus? Status { get; set; }
        public string EntryModeStatus { get; set; }
        public List<LinkNameValueResponse> TCLinkResponse { get; set; }
        public string TCTransactionID { get; set; }
        public DateTime? TCTimestamp { get; set; }
        public int? CollectedAmount { get; set; }
        public string BillingID { get; set; }
        public LinkCardResponse CardResponse { get; set; }
        public LinkBankAccountResponse AccountResponse { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LinkPaymentResponseStatus
    {
        Error,
        Approved,
        Accepted,
        Declined,
        Cancelled,
        InProgress,
        NotFound,
        PaymentTimeout
    }
}
