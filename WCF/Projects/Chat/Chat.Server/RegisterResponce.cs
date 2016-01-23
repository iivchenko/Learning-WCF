using System.Runtime.Serialization;

namespace Chat.Server
{
    [DataContract]
    internal class RegisterResponce
    {
        [DataMember]
        public RegistrationResult Result { get; set; }
    }
}
