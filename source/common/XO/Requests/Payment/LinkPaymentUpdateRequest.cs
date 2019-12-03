namespace XO.Requests.Payment
{
    public class LinkPaymentUpdateRequest : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            return null;
        }

        public int RequestedAmount { get; set; }
        public bool CompletePayment { get; set; }
        public bool CancelPayment { get; set; }
        public LinkPaymentAttributes PaymentAttributes { get; set; }
    }
}
