using System.Runtime.Serialization;

namespace Chat.Server
{
    [DataContract]
    internal class RegisterRequest
    {
        [DataMember]
        public string Name { get; set; }
    }
}
