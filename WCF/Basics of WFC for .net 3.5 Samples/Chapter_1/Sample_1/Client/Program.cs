using System;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        static void Main()
        {
            ChannelFactory<IStockService> myChannelFactory = new ChannelFactory<IStockService>(new BasicHttpBinding(), new EndpointAddress("http://localhost:8000/EssentialWCF"));
            
            IStockService wcfClient = myChannelFactory.CreateChannel();
            
            double p = wcfClient.GetPrice("msft"); 
            
            Console.WriteLine("Price:{0}", p);
            Console.ReadKey();
        }
    }
}
