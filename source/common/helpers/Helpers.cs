using System;
using XO.Requests;

namespace Common.Helper
{
    public static class Helpers
    {
        public static void SetActionResponse(LinkRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            if (request.LinkObjects == null)
            {
                request.LinkObjects = new LinkRequestIPA5Object();
            }

            if (request.LinkObjects.LinkActionResponseList == null)
            {
                request.LinkObjects.LinkActionResponseList = new System.Collections.Generic.List<XO.Responses.LinkActionResponse>();
            }

            if (request.LinkObjects.LinkActionResponseList.Count == 0)
            {
                request.LinkObjects.LinkActionResponseList.Add(new XO.Responses.LinkActionResponse());
            }
        }

        public static void SetActionResponseError(LinkRequest request, string code, string type, string description)
        {
            SetActionResponse(request);

            if (request.LinkObjects.LinkActionResponseList[0].Errors == null)
            {
                request.LinkObjects.LinkActionResponseList[0].Errors = new System.Collections.Generic.List<XO.Responses.LinkErrorValue>();
            }

            request.LinkObjects.LinkActionResponseList[0].Errors.Add(new XO.Responses.LinkErrorValue
            {
                Code = code,
                Type = type,
                Description = description
            });
        }
    }
}
