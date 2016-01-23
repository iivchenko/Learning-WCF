using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Server
{
    class Program
    {
        static void Main()
        {
            var serviceHost = new ServiceHost(typeof(StockService), new Uri("http://localhost:8000/EssentialWCF"));

            var behavior = new ServiceMetadataBehavior
            {
                HttpGetEnabled = true
            };

            serviceHost.Description.Behaviors.Add(behavior);

            serviceHost.AddServiceEndpoint(typeof(IStockService), new BasicHttpBinding(), "");
            serviceHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            serviceHost.Open();
            
            Console.WriteLine("Press any key to exit.\n\n"); 
            Console.ReadKey();

            serviceHost.Close();
        }
    }
}
