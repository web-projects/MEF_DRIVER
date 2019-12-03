namespace XO.Requests
{
    public class LinkCustomField : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Value))
            {
                return new Responses.LinkErrorValue     // TODO: update with correct values for missing required value
                {
                    Code = "CustomFieldError",
                    Type = "NameAndValueRequired",
                    Description = "You are missing fields required for this request to be processed."
                };
            }

            return null;
        }

        public string Name { get; set; }
        public string Value { get; set; }
    }
}
