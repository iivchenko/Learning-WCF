using System;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        private static void Main()
        {
            // Unhandled exception on the Server. Channel will be closed.
            // to see message of the exception set this on the server
            // <serviceDebug includeExceptionDetailInFaults="true"/>
            Sample_1();
            Console.WriteLine("=== Press any key to clear screen and continue... === ");
            Console.ReadKey();
            Console.Clear();

            // FaultException exception on the Server. Channel will NOT be closed.
            Sample_2();
            Console.WriteLine("=== Press any key to clear screen and continue... === ");
            Console.ReadKey();
            Console.Clear();

            // FaultException<T> exception on the Server. Channel will NOT be closed.
            Sample_3();
            Console.WriteLine("=== Press any key to clear screen and continue... === ");
            Console.ReadKey();
            Console.Clear();

            // FaultException<T> exception on the Server. Channel will NOT be closed.
            // Print a little bit more details into console.
            Sample_4();
            Console.WriteLine("=== Press any key to clear screen and continue... === ");
            Console.ReadKey();
            Console.Clear();
        }

        private static void Sample_1()
        {
            var client = new Learning_WCF.ServiceClient();

            try
            {
                client.ThrowNotImplementedException();
            }
            catch (Exception e)
            {
                Console.WriteLine("=============");
                Console.WriteLine(e);
                Console.WriteLine("=============\n\n\n\n");
            }

            try
            {
                client.ThrowNotImplementedException();
            }
            catch (Exception e)
            {
                Console.WriteLine("=============");
                Console.WriteLine(e);
                Console.WriteLine("=============\n\n\n\n");
            }
        }

        private static void Sample_2()
        {
            var client = new Learning_WCF.ServiceClient();

            try
            {
                client.ThrowFaulException();
            }
            catch (Exception e)
            {
                Console.WriteLine("=============");
                Console.WriteLine(e);
                Console.WriteLine("=============\n\n\n\n");
            }

            try
            {
                client.ThrowFaulException();
            }
            catch (Exception e)
            {
                Console.WriteLine("=============");
                Console.WriteLine(e);
                Console.WriteLine("=============\n\n\n\n");
            }
        }

        private static void Sample_3()
        {
            var client = new Learning_WCF.ServiceClient();

            try
            {
                client.ThrowGenericFaultException();
            }
            catch (Exception e)
            {
                Console.WriteLine("=============");
                Console.WriteLine(e);
                Console.WriteLine("=============\n\n\n\n");
            }

            try
            {
                client.ThrowGenericFaultException();
            }
            catch (Exception e)
            {
                Console.WriteLine("=============");
                Console.WriteLine(e);
                Console.WriteLine("=============\n\n\n\n");
            }
        }

        private static void Sample_4()
        {
            var client = new Learning_WCF.ServiceClient();

            try
            {
                client.ThrowGenericFaultException();
            }
            catch (FaultException<Learning_WCF.ErrorDetails> e)
            {
                Console.WriteLine("=============");
                Console.WriteLine(e);
                Console.WriteLine("=============");
                Console.WriteLine("Code: {0}", e.Code.Name);
                Console.WriteLine("Action: {0}", e.Action);
                Console.WriteLine("Reason: {0}", e.Reason);
                Console.WriteLine("Detail Code: {0}", e.Detail.Code);
                Console.WriteLine("Detail Description: {0}", e.Detail.Description);
                Console.WriteLine("Detail Name: {0}", e.Detail.Name);
                Console.WriteLine("=============\n\n\n\n");
            }

            try
            {
                client.ThrowGenericFaultException();
            }
            catch (FaultException<Learning_WCF.ErrorDetails> e)
            {
                Console.WriteLine("=============");
                Console.WriteLine(e);
                Console.WriteLine("=============");
                Console.WriteLine("Code: {0}", e.Code.Name);
                Console.WriteLine("Action: {0}", e.Action);
                Console.WriteLine("Reason: {0}", e.Reason);
                Console.WriteLine("Detail Code: {0}", e.Detail.Code);
                Console.WriteLine("Detail Description: {0}", e.Detail.Description);
                Console.WriteLine("Detail Name: {0}", e.Detail.Name);
                Console.WriteLine("=============\n\n\n\n");
            }
        }
    }
}
