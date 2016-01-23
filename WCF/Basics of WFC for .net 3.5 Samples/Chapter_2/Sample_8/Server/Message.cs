using System.ServiceModel;

namespace Server
{
    [MessageContract]
    internal class Message
    {
        [MessageHeader]
        public string Header { get; set; }

        [MessageBodyMember]
        public string Body { get; set; }
    }
}
