using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientDiskInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Client";

            Uri uri = new Uri("net.TCP://localhost:4000/IDiskInfo"); //Adress (a)

            NetTcpBinding binding = new NetTcpBinding();//Binding (B)

            EndpointAddress endpoint = new EndpointAddress(uri);

            //Create Cannel Factory
            ChannelFactory<IDiskInfo> factory = new ChannelFactory<IDiskInfo>(binding, endpoint);//Contract(C)

            IDiskInfo chanel = factory.CreateChannel();

            string[] diskInfo = chanel.GetDiskInfo(@"d:\itstep\WCF\JastForFan\HelloWorldWCF");

            foreach (var i in diskInfo)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
            factory.Close();
        }
    }
}
