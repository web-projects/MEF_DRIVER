using System;
using System.Collections.Generic;

namespace XO.Responses.Payment
{
    public class LinkPaymentUpdateResponse : LinkFutureCompatibility
    {
        List<LinkErrorValue> Errors { get; set; }
        public string Status { get; set; }
        public DateTimeOffset TCTimestamp { get; set; }
        public int RequestedAmount { get; set; }
    }
}
