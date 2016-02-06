using System;
using System.ServiceModel.Dispatcher;

namespace Server
{
    class NullStringParameterInspector : IParameterInspector 
    {
        public object BeforeCall(string operationName, object[] inputs)
        {
            foreach (var input in inputs)
            {
                if (input == null)
                {
                    throw new ArgumentException("Cant be null");
                }
            }

            return null;
        }

        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
        }
    }
}
