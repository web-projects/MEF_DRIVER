using System;
using System.Collections.Generic;
using System.Text;

namespace XO.IPA5Private.Listener
{
    public class ListenerPackage
    {
        public enum ListenerAction { Subscribe, Publish, Unsubscribe, SubscribeConfirmSuccess, SubscribeConfirmFail,
            PublishConfirmSuccess, PublishConfirmFail, UnsubscribeConfirmSuccess, UnsubscribeConfirmFail
        };
        public ListenerAction Action;
        public string ListenerMessage;
        public string[] Topics;
        public object Data;
        public Guid SenderConnectionClientID;
        public Guid GlobalComponentID;
    }
}
