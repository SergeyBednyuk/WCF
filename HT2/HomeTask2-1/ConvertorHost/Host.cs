using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConvertorHost
{
    class Host
    {
        static void Main(string[] args)
        {
            Console.Title = "Host";

            using (var _host = new ServiceHost(typeof(ServiceConvertorDll.Converter)))
            {
                _host.Open();

                Console.WriteLine("Host works....");
                Console.ReadKey();
                _host.Close();

                Console.WriteLine("Host shut down after 5 sec");
                Thread.Sleep(5000);
            }
        }
    }
}
