using System;

namespace Client
{
    class Program
    {
        public const string ClientName = "Client_C2_S5";

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

                client.Send(msg);

                var helloMsg = new Learning_WCF.HelloMessage()
                {
                    Sender = "Ivan",
                    MessageMember = "Hello!!"
                };

                Console.WriteLine("Sending hello msg: {0}", helloMsg.MessageMember);

                client.Send(helloMsg);

                var byMsg = new Learning_WCF.ByMessage()
                {
                    Sender = "Ivan",
                    MessageMember = "By!!"
                };

                Console.WriteLine("Sending by msg: {0}", byMsg.MessageMember);

                client.Send(byMsg);

                Console.WriteLine("Press any key...");

                Console.ReadKey();
            }
        }
    }
}
