using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Chat.Server
{
    [ServiceBehaviorAttribute(InstanceContextMode = InstanceContextMode.Single)]
    internal class MessageService : IMessageService
    {
        private readonly IDictionary<string, IMessageCallback> _clients;

        public MessageService(IDictionary<string, IMessageCallback> clients)
        {
            _clients = clients;
        }

        public void Send(Message msg)
        {
            lock (_clients)
            {
                Console.WriteLine("User {0} sent message '{1}'", msg.Sender, msg.Msg);

                foreach (var client in _clients.Where(x => x.Key != msg.Sender).Select(x => x.Value))
                {
                    client.Send(msg);
                }
            }
        }
    }
}
