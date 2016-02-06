using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Server
{
    [AttributeUsage(AttributeTargets.Method)]
    public class EmptyParametersValidationBehaviorAttribute : Attribute, IOperationBehavior
    {
        public void Validate(OperationDescription operationDescription)
        {
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        {
            dispatchOperation.ParameterInspectors.Add(new EmptyStringParameterInspector());
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        {
        }

        public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
        {
        }
    }
}
