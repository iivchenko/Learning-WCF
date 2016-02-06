﻿using System;
using System.ServiceModel;
using System.Threading;

namespace Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    internal class Service : IService
    {
        public Service()
        {
            Console.WriteLine("{0}: New instance.", DateTime.Now);
        }

        public string Send(string msg)
        {
            Console.WriteLine("{0}: Msg:{1}; Thread {2}", DateTime.Now, msg, Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);

            return Thread.CurrentThread.ManagedThreadId + " " + msg;
        }
    }
}
