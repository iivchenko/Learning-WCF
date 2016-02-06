using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace Server
{
    [CollectionDataContract]
    internal class StorageCollection : Collection<int>
    {
        public StorageCollection()
        {
        }

        public StorageCollection(IList<int> source)
            :base(source)
        {
        }
    }
}
