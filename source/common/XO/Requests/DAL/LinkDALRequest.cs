using System;
using XO.Common.DAL;

namespace XO.Requests.DAL
{
    //DAL controls
    public partial class LinkDALRequest : LinkFutureCompatibility
    {
        public Responses.LinkErrorValue Validate(bool synchronousRequest = true)
        {
            // No validation on these values
            return null;
        }

        public LinkDALIdentifier DALIdentifier { get; set; }

        public LinkDeviceIdentifier DeviceIdentifier { get; set; }

        public Guid? HeldCardDataID { get; set; }


        //Note: specific to internal IPA operations; not defined for customer use; customer input parsers should return error if these values are specified
        public LinkDALRequestIPA5Object LinkObjects { get; set; }
    }
}
