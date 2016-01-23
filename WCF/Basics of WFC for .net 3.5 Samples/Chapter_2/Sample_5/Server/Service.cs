using System;

namespace Server
{
    internal class Service : IService
    {
        public void Send(Message msg)
        {
            Console.WriteLine(msg);
        }
    }
}
