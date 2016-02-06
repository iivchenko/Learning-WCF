using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace Server
{
    internal class MyServiceBehavior : IServiceBehavior
    {
        private readonly string _supperValue;

        public MyServiceBehavior(string supperValue)
        {
            _supperValue = supperValue;
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            if (string.IsNullOrWhiteSpace(_supperValue))
            {
                throw new InvalidOperationException("Supper value can't be empty.");
            }

            Console.WriteLine("SupperValue is: {0}", _supperValue);
        }

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints,
            BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
        }
    }
}
