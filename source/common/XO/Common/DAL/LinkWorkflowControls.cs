namespace XO.Common.DAL
{
    //Payment workflow controls (note: only values that might affect DAL workflow are included)
    public class LinkWorkflowControls : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            // No validation on these values
            return null;
        }

        public bool? CardEnabled { get; set; }
        public bool? CheckEnabled { get; set; }
        public int? WorkflowTimeout { get; set; }
        public int? TenderSelectionTimeout { get; set; }
        public int? ManualCheckTimeout { get; set; }
        public int? ServiceTimeout { get; set; }
    }
}
