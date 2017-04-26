using System;
using System.ServiceModel;
using System.Threading;

namespace ServiceHost
{
    class Host
    {
        static void Main(string[] args)
        {
            Console.Title = "Host";

            System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof (Service));

            host.Open();
            Console.WriteLine("Host works....");
            Console.ReadKey();
            Console.WriteLine("Host shut down after 5 sec");
            Thread.Sleep(5000);
            host.Close();
        }
    }
}
