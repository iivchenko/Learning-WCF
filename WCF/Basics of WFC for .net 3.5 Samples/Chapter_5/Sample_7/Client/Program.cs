using System;
using System.IO;

namespace Client
{
    class Program
    {
        static void Main()
        {
            using (var client = new Learning_WCF.ServiceClient())
            using (var reader = new StreamReader(client.Send(@"D:\OneDrive\Video\В.Г. Жданов - Верни себе зрение\disk1.avi")))
            {
                while(!reader.EndOfStream)
                    Console.WriteLine(reader.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
