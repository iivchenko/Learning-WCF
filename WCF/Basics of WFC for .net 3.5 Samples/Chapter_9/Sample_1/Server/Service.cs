using System;
using System.Diagnostics;

namespace Server
{
    internal class Service : IService
    {
        private TraceSource _trace = new TraceSource("Server.Service");

        public string Say(string msg)
        {
            Console.WriteLine(msg);

            _trace.Switch = new SourceSwitch("SourceSwitch", "Verbose");

            _trace.TraceInformation(msg +"-GG");
            _trace.Flush();
            _trace.Close();

            return "Hello from server";
        }
    }
}
