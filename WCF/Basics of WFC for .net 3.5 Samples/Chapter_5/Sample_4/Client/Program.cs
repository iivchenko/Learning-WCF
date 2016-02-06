using System;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main()
        {
            using (var client = new Learning_WCF.ServiceClient())
            {
                Console.WriteLine("== Client ==");

                Task.WaitAll(
                    client.SendAsync("Hello_1").ContinueWith(WriteResult),
                    client.SendAsync("Hello_2").ContinueWith(WriteResult),
                    client.SendAsync("Hello_3").ContinueWith(WriteResult));

                Console.WriteLine("Press any key..");
                Console.ReadKey();
            }
        }

        private static void WriteResult(Task<Learning_WCF.Responce> responce)
        {
            Console.WriteLine("Number of calls: {0}; Server thread ID: {1}", responce.Result.NumberOfCalls, responce.Result.ServerThread);
        }
    }
}
