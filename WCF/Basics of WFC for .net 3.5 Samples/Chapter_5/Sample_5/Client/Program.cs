using System;
using System.Collections.Generic;
using System.Transactions;

namespace Client
{
    class Program
    {
        static void Main()
        {
            using (var client = new Learning_WCF.ServiceClient())
            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                Console.WriteLine("Transaction succeded.");
                Write(client.GetAll());

                client.Add(1);
                
                scope.Complete(); // Commit transaction results
            }

            using (var client = new Learning_WCF.ServiceClient())
            {
                Write(client.GetAll());
            }

            using (var client = new Learning_WCF.ServiceClient())
            using (new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                Console.WriteLine("Transaction canceled.");
                
                Write(client.GetAll());

                client.Add(2);

                // scope.Complete(); - don't use transaciton Complete so it will rollback reuslts.
            }

            using (var client = new Learning_WCF.ServiceClient())
            {
                Write(client.GetAll());
            }

            Console.ReadKey();
        }

        private static void Write(IEnumerable<int> collection)
        {
            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
