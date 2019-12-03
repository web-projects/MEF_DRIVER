namespace XO.Responses.Payment
{
    public class LinkBankAccountResponse : LinkFutureCompatibility
    {
        public string AccountType { get; set; }
        public string RoutingNumber { get; set; }
        public string TrailingAccountNumber { get; set; }
        public string CheckNumber { get; set; }
        public string HolderName { get; set; }
    }
}
