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
                    client.SendAsync("Hello_1").ContinueWith(x => Console.WriteLine(x.Result)),
                    client.SendAsync("Hello_2").ContinueWith(x => Console.WriteLine(x.Result)),
                    client.SendAsync("Hello_3").ContinueWith(x => Console.WriteLine(x.Result)));

                Console.WriteLine("Press any key..");
                Console.ReadKey();
            }
        }
    }
}
