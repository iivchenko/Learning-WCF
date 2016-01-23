using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Timers;

namespace Server
{
    internal class Service : IService
    {
        private readonly IDictionary<string, IClientCallback> _clients;
        private readonly Timer _timer;

        public Service()
        {
            _clients = new Dictionary<string, IClientCallback>();
            _timer = new Timer(3000);
            
            _timer.Elapsed += (sender, args) =>
            {
                foreach (var client in _clients)
                {
                    client.Value.Update(string.Format("Message form {0} to {1}", Program.ServerName, client.Key));
                }
            };

            _timer.Enabled = true;
        }

        public void Register(string client)
        {
            if (!_clients.Keys.Contains(client))
            {
                _clients.Add(client, OperationContext.Current.GetCallbackChannel<IClientCallback>());

                Console.WriteLine("{0} registered", client);
            }
        }
    }
}
