using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace Xac_dinh_IP_may_cuc_bo
{
    class Program
    {
        static void Main(string[] args)
        {
            string HostN = Dns.GetHostName();
            Console.WriteLine("{0}", HostN);
            IPHostEntry IP = Dns.GetHostByName(HostN);
            int nIP = 0;
            foreach (IPAddress ip in IP.AddressList)
            {
                Console.Write("IP {0}: {1}", ++nIP, ip.ToString());
                Console.WriteLine();

            }
        }
    }
}
