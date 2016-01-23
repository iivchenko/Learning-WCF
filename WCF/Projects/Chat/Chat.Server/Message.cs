using System.Runtime.Serialization;

namespace Chat.Server
{
    [DataContract]
    internal class Message
    {
        [DataMember(IsRequired = true)]
        public string Sender { get; set; }

        [DataMember(Name = "Message", IsRequired = true)]
        public string Msg { get; set; }
    }
}
