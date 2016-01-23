using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Chat.Server
{
    class Program
    {
        static void Main()
        {
            var clients = new Dictionary<string, IMessageCallback>();
            var registerService = new RegistryService(clients);
            var messageService = new MessageService(clients);

            using (var regisrationHost = new ServiceHost(registerService))
            using (var messagingHost = new ServiceHost(messageService))
            {
                regisrationHost.Open();
                messagingHost.Open();

                Console.WriteLine("Server started\n");
                Console.WriteLine("Press any key to stop.");
                Console.ReadKey();
            }
        }
    }
}
