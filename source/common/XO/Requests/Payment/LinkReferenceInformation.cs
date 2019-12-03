namespace XO.Requests
{
    public class LinkReferenceInformation : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            // No validation on these values
            return null;
        }

        public string Ticket { get; set; }
        public string MerchantTransactionID { get; set; }
    }
}
