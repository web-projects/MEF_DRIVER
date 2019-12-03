namespace XO.Requests
{
    public class LinkPayerRequest : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            // No validation on these values
            return null;
        }

        public string PayerName { get; set; }
        public string PayerAddress { get; set; }
        public string PayerZIPCode { get; set; }
    }
}
