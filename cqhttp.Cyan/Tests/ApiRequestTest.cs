using System;
using cqhttp.Cyan.ApiCall.Requests;
using cqhttp.Cyan.Enums;
using cqhttp.Cyan.Instance;
using cqhttp.Cyan.Messages;
using cqhttp.Cyan.Messages.CQElements;

namespace cqhttp.Cyan.Tests {
    /// <summary></summary>
    public class ApiRequestTest {
        /// <summary></summary>
        public static void Test () {
            Message testmessage = new Message {
                data = new System.Collections.Generic.List<Messages.CQElements.Base.Element> {
                new ElementText ("first te[xt] message"),
                new ElementFace (3),
                new ElementText ("second #&text message")
                }
            };
            // CQHTTPClient client = new CQHTTPClient ("http://service.std-frank.club:233");
            CQApiClient clientws=new CQWebsocketClient("ws://service.std-frank.club:233");
            Console.ReadLine();
            // Console.WriteLine (
            //     client.SendMessageAsync (MessageType.private_, 745679136, testmessage).Result.data.ToString()
            // );
            // Console.WriteLine (
            //     client.SendTextAsync (MessageType.private_, 745679136, "testmessage").Result.data.ToString()
            // );
            // Console.WriteLine (
            //     client.SendMessageAsync (MessageType.private_, 745679136, new Messages.CommonMessages.MessageShake()).Result.data.ToString()
            // );
        }
    }
}