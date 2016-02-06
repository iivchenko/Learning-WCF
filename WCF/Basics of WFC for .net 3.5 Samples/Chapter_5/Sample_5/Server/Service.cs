using System.Linq;
using System.ServiceModel;

namespace Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    internal class Service : IService
    {
        private static TransactionalCollection<int> _transactionalCollection = new TransactionalCollection<int>();

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public void Add(int value)
        {
            _transactionalCollection.Add(value);
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = false)]
        public void Remove(int value)
        {
            _transactionalCollection.Remove(value);

            OperationContext.Current.SetTransactionComplete();
        }

        [OperationBehavior(TransactionScopeRequired = false)] 
        public StorageCollection GetAll()
        {
            return new StorageCollection(_transactionalCollection.ToList());
        }
    }
}
