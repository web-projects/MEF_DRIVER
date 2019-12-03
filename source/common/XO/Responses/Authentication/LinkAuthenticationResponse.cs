using System;
using XO.Enums;

namespace XO.Responses.Authentication
{
    public class LinkAuthenticationResponse : LinkFutureCompatibility
    {

        public AuthenticationStatus Status { get; set; }
        public string AuthToken { get; set; }
        public DateTime Expiration { get; set; }
    }

}
