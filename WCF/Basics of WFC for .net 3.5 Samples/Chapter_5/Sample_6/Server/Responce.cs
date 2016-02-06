using System.Runtime.Serialization;

namespace Server
{
    [DataContract]
    internal class Responce
    {
        [DataMember]
        public int NumberOfCalls { get; set; }

        [DataMember]
        public int ServerThread { get; set; }
    }
}
