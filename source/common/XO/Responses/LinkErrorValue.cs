﻿namespace XO.Responses
{
    public class LinkErrorValue : LinkFutureCompatibility
    {
        public string Type { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
