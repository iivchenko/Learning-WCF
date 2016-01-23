using System;

namespace Server
{
    internal class Service : IService
    {
        public void Send(Message msg)
        {
            Console.WriteLine("Header: {0}", msg.Header);
            Console.WriteLine("Body: {0}", msg.Body);
        }
    }
}
