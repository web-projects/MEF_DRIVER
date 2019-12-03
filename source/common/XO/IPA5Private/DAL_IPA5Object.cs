using XO.Responses.DAL;
using XO.Responses.Payment;

namespace XO.Requests.DAL
{
    public partial class LinkDALRequestIPA5Object
    {
        //public class CardData
        //{
        //    public string EncryptedTrack { get; set; }
        //    public string First6 { get; set; }
        //    public string Last4 { get; set; }
        //    public string ExpYear { get; set; }
        //    public string ExpMon { get; set; }
        //    public string Name { get; set; }

        //    public LinkEMVResponse EMVResponse { get; set; }
        //}

        //public CardData CapturedCardData { get; set; }
        public LinkCardResponse CapturedCardData { get; set; }
        public LinkDALActionResponse DALResponseData { get; set; }
        public string EncryptedTrackKSN { get; set; }
        public string EncryptedTrackIV { get; set; }
        public string EncryptedTrackData { get; set; }
        public string Track1 { get; set; }
        public string Track2 { get; set; }
        public string Zip { get; set; }
        public string OnlinePINKSN { get; set; }
        public string OnlinePINData { get; set; }
    }
}
