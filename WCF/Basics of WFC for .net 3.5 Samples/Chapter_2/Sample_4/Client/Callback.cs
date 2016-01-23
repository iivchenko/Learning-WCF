using System;

namespace Client
{
    internal class Callback : Learning_WCF.IServiceCallback
    {
        public void Update(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
