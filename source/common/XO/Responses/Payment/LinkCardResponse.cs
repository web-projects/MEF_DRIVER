using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XO.Responses.Payment
{
    public class LinkCardResponse : LinkFutureCompatibility
    {
        public string AuthorizationCode { get; set; }
        public string LeadingMaskedPAN { get; set; }
        public string TrailingMaskedPAN { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string CardholderName { get; set; }
        public bool SignatureRequested { get; set; }
        public string TenderType { get; set; }
        public bool DebitCard { get; set; }
        public LinkEMVResponse EMVData { get; set; }
        public LinkCardPaymentResponseEntryMode EntryMode { get; set; }
        public string AVSStatus { get; set; }
        public string CommercialCard { get; set; }
        public string CardIdentifier { get; set; }
        public Guid? HeldCardDataID { get; set; }
        public LinkOnlineApproval OnlineApproval { get; set; }
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum LinkCardPaymentResponseEntryMode
    {
        None,
        Swipe,
        EMV,
        Manual,
        Contactless,
        ContactlessEMV
    }
}
