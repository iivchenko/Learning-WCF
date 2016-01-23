using System.Runtime.Serialization;

namespace Server
{
    [DataContract(Namespace = Program.Namespace)]
    internal class HelloMessage : Message
    {
        [DataMember(Name = "Sender")]
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Hello from {0}; Message {1}", Name, base.ToString());
        }
    }
}
