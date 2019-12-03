
namespace XO.Common.DAL
{
    //Device identification values
    public class LinkDeviceIdentifier : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            // No validation on these values
            return null;
        }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
    }
}
