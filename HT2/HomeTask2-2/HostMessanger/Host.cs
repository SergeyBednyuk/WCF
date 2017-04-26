using System;
using System.ServiceModel;
using System.Threading;

namespace HostMessanger
{
    class Host
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(MassengerServiceDll.Messenger)))
            {
                host.Open();
                Console.WriteLine("Host works....");
                Console.ReadKey();
                host.Close();
                Console.WriteLine("Host shut down after 5 sec");
                Thread.Sleep(5000);
            }
        }
    }
}
