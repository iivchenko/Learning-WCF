using System.ServiceModel;

namespace Server
{
    internal class Service : IService
    {
        public void ThrowNotImplementedException()
        {
            throw new System.NotImplementedException("Ha!!");
        }

        public void ThrowFaulException()
        {
            throw new FaultException("ooopss");
        }

        public void ThrowGenericFaultException()
        {
            var details = new ErrorDetails
            {
                Code = 666,
                Name = "Devil",
                Description = "This is the end!"
            };

            var reason = new FaultReason("This is the FulaReason");
            var code = FaultCode.CreateReceiverFaultCode("ThrowGenericFaultException", "Server.Service");

            throw new FaultException<ErrorDetails>(details, reason, code);
        }
    }
}
