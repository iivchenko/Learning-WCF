using System;
using System.ServiceModel.Dispatcher;

namespace Server
{
    class EmptyStringParameterInspector : IParameterInspector
    {
        public object BeforeCall(string operationName, object[] inputs)
        {
            foreach (var input in inputs)
            {
                var tmp = input as string;
                if (input != null && input == "")
                {
                    throw new ArgumentException("Cant be empty");
                }
            }

            return null;
        }

        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
        }
    }
}
