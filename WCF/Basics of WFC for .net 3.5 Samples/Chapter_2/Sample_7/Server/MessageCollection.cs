using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace Server
{
    [CollectionDataContract]
    internal class MessageCollection : Collection<Message>
    {
    }
}
