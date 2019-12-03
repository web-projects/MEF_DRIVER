namespace XO.Common.DAL
{
    //Signature threshold values by card brand
    public class LinkThresholdAmount : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            if (string.IsNullOrEmpty(CardBrand) || (Threshold == null))
            {
                return new Responses.LinkErrorValue     // TODO: update with correct values for missing required value
                {
                    Code = "CardBrandAndThresholdRequired",
                    Type = "CardBrandAndThresholdRequired",
                    Description = "You are missing fields required for this request to be processed."
                };
            }

            return null;
        }

        public string CardBrand { get; set; }
        public int? Threshold { get; set; }
    }
}
