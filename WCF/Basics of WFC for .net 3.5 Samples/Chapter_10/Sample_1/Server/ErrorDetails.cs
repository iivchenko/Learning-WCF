using System.Runtime.Serialization;

namespace Server
{
    [DataContract]
    internal class ErrorDetails
    {
        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
