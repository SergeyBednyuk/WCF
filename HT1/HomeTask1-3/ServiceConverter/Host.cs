using System;
using System.ServiceModel;
using System.Threading;

namespace ServiceConverter
{
    class Host
    {
        static void Main(string[] args)
        {
            Console.Title = "Host";

            ServiceHost host = new ServiceHost(typeof(Service));

            host.Open();
            Console.WriteLine("Host works....");
            Console.ReadKey();
            Console.WriteLine("Host shut down after 5 sec");
            Thread.Sleep(5000);
            host.Close();
        }
    }
}
