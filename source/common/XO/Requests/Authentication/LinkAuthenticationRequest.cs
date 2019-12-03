namespace XO.Requests
{
    public class LinkAuthenticationRequest : LinkFutureCompatibility
    {

        private const string DefaultAction = "auth";
        private const string DefaultAuthType = "tclink";
        //future auth type "query" for Query API

        public Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            if (TCCustID <= 0)
            {
                return new Responses.LinkErrorValue
                {
                    Code = "ZeroCustID",
                    Type = "AuthenticationFieldRequired",
                    Description = "A nonzero CustID is required for authentication."
                };
            }

            if (string.IsNullOrWhiteSpace(TCPassword))
            {
                return new Responses.LinkErrorValue
                {
                    Code = "MissingPassword",
                    Type = "AuthenticationFieldRequired",
                    Description = "A password is required for authentication."
                };
            }
            return null;
        }

        public LinkAuthenticationRequest()
        {
            Action = DefaultAction;
            AuthType = DefaultAuthType;
        }

        public string Action { get; }
        public long TCCustID { get; set; }
        public string AuthType { get; }
        public string TCPassword { get; set; }
        public string Operator { get; set; }

    }
}
