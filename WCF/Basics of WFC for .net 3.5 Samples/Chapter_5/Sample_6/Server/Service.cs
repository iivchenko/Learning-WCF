using System;
using System.ServiceModel;
using System.Threading;

namespace Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    internal class Service : IService
    {
        private int _numberOfCalls;
        private object _lock;

        public Service()
        {
            _numberOfCalls = 0;
            _lock = new object();
            Console.WriteLine("{0}: New instance.", DateTime.Now);
        }

        [NullParametersValidationBehavior]
        [EmptyParametersValidationBehavior]
        public Responce Send(string msg)
        {
            lock (_lock)
            {
                _numberOfCalls++;
                Console.WriteLine("{0}: Msg:{1}; Thread {2}", DateTime.Now, msg, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(5000);

                return new Responce
                {
                    NumberOfCalls = _numberOfCalls,
                    ServerThread = Thread.CurrentThread.ManagedThreadId
                };
            }
        }
    }
}
