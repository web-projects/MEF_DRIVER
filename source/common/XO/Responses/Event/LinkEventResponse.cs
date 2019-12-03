using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XO.Responses.Event
{
    public class LinkEventResponse : LinkFutureCompatibility
    {
        public string EventType { get; set; }
        public string EventCode { get; set; }
        public string Description { get; set; }
        public Guid EventID { get; set; }
        public int OrdinalID { get; set; }
        public string[] EventData { get; set; }

        //Event Type
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeType
        {
            DISPLAY,
            INPUT,
            PAYMENT
        }

        //Event Code
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventCodeType
        {
            DEVICE_MESSAGE_DISPLAY,
            DEVICE_MESSAGE_INSERT_CARD,
            DEVICE_MESSAGE_INSERT_CARD_AGAIN,
            DEVICE_MESSAGE_CHOOSE_CARD_TYPE,
            DEVICE_MESSAGE_ENTER_ZIP,
            DEVICE_MESSAGE_REMOVE_CARD,
            DEVICE_MESSAGE_ENTER_PIN,
            DEVICE_DEBIT_SELECTED,
            DEVICE_CREDIT_SELECTED,
            DEVICE_CARD_CANNOT_READ,
            DEVICE_CARD_INSERTED,
            DEVICE_CARD_REMOVED,
            DEVICE_KEY_PRESSED,
            DEVICE_ZIP_ENTERED,
            DEVICE_PIN_ENTERED,
            DEVICE_REQUEST_CARDTYPE,
            DEVICE_REQUEST_CARD_INSERT,
            DEVICE_REQUEST_CARD_REMOVE,
            DEVICE_REQUEST_KEY_PRESS,
            DEVICE_REQUEST_ZIP_ENTER,
            DEVICE_REQUEST_PIN_ENTER,
            PAYMENT_PROCESSING,
            PAYMENT_STATUS,
            PAYMENT_COMPLETE

        }
    }
}
