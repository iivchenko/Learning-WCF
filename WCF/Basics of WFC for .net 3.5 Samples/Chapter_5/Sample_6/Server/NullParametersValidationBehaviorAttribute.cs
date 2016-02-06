using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Server
{
    [AttributeUsage(AttributeTargets.Method)]
    public class NullParametersValidationBehaviorAttribute : Attribute, IOperationBehavior
    {
        public void Validate(OperationDescription operationDescription)
        {
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        {
            dispatchOperation.ParameterInspectors.Add(new NullStringParameterInspector());
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        {
        }

        public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
        {
        }
    }
}
