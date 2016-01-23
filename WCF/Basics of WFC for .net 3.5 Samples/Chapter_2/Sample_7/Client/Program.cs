using System;

namespace Client
{
    class Program
    {
        public const string ClientName = "Client_C2_S7";

        static void Main()
        {
            using (var client = new Learning_WCF.ServiceClient())
            {
                Console.WriteLine("== {0} ==", ClientName);

                var msg = new Learning_WCF.Message
                {
                    MessageMember = "Lets play!!"
                };

                Console.WriteLine("Sending msg: {0}", msg.MessageMember);

                var responce = client.Send(msg);

                foreach (var item in responce)
                {
                    Console.WriteLine(item.MessageMember);
                }
              
                Console.WriteLine("Press any key...");

                Console.ReadKey();
            }
        }
    }
}
