namespace XO.Requests.Payment
{
    //Payment attributes
    public class LinkPaymentAttributes : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            // No validation on these values
            return null;
        }

        public bool? PartialPayment { get; set; }
        public bool? SplitTender { get; set; }
        public bool? Installment { get; set; }
    }
}
