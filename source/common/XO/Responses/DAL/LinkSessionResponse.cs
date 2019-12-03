using System.Collections.Generic;

namespace XO.Responses.DAL
{
    public class LinkSessionResponse : LinkFutureCompatibility
    {
        public List<LinkErrorValue> Errors { get; set; }

        public string SessionID { get; set; }
    }
}
