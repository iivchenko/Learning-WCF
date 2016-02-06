using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Chat.Server
{
    [ServiceBehaviorAttribute(InstanceContextMode = InstanceContextMode.Single)]
    internal class RegistryService : IRegistryService
    {
        private readonly IDictionary<string, IMessageCallback> _clients;

        public RegistryService(IDictionary<string, IMessageCallback> clients)
        {
            _clients = clients;
        }

        public RegisterResponce Register(RegisterRequest request)
        {
            lock (_clients)
            {
                if (_clients.ContainsKey(request.Name))
                {
                    return new RegisterResponce { Result = RegistrationResult.BusyUserName };
                }

                var client = OperationContext.Current.GetCallbackChannel<IMessageCallback>();
                          

                client.Closed+= OnClosed;

                _clients.Add(request.Name, client);

                Console.WriteLine("'{0}' entered the chat!", request.Name);

                return new RegisterResponce { Result = RegistrationResult.Success };
            }
        }

        private void OnClosed(object sender, EventArgs e)
        {
            var pair = _clients.Single(x => x.Value == sender);

            _clients.Remove(pair);

            Console.WriteLine("'{0}' left the chat!", pair.Key);
        }
    }
}
