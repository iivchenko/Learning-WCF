using System;

namespace Server
{
    internal class Service : IService
    {
        public MessageCollection Send(Message msg)
        {
            Console.WriteLine(msg);

            return new MessageCollection
            {
                msg, 
                msg, 
                msg
            };
        }
    }
}
