using System;

namespace Server
{
    internal class Service : IService
    {
        public string Say(string msg)
        {
            Console.WriteLine(msg);

            return "Hell from server: " + msg;
        }
    }
}
