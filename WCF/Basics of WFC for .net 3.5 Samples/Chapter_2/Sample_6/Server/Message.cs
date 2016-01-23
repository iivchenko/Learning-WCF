using System.Runtime.Serialization;

namespace Server
{
    [DataContract(Namespace = Program.Namespace)]
    internal class Message
    {
        [DataMember(Name = "Message", IsRequired = true)]
        public string Msg { get; set; }

        public override string ToString()
        {
            return Msg;
        }
    }
}
