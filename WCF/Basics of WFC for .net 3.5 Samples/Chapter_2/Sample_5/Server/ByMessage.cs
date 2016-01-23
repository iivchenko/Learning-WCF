using System.Runtime.Serialization;

namespace Server
{
    [DataContract(Namespace = Program.Namespace)]
    internal class ByMessage : Message
    {
        [DataMember(Name = "Sender")]
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("By from {0}; Message {1}", Name, base.ToString());
        }
    }
}
