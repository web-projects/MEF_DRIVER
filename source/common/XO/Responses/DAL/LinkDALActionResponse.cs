using System.Collections.Generic;

namespace XO.Responses.DAL
{
    public class LinkDALActionResponse : LinkFutureCompatibility
    {
        public List<LinkErrorValue> Errors { get; set; }
        public string Status { get; set; }
        public string Value { get; set; }
        public bool? CardPresented { get; set; }
    }
}
