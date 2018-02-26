using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Net.NetworkInformation;

namespace DeviceTrackerTest
{
    class Program
    {
        static void Main(string[] args)
        {

         
                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in adapters)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    Console.WriteLine(adapter.Description);
                    Console.WriteLine("  DNS suffix .............................. : {0}",
                        properties.DnsSuffix);
                    Console.WriteLine("  DNS enabled ............................. : {0}",
                        properties.IsDnsEnabled);
                    Console.WriteLine("  Dynamically configured DNS .............. : {0}",
                        properties.IsDynamicDnsEnabled);
                }
                Console.WriteLine();
            
            Console.WriteLine("Pulse una tecla para terminar ...");
            Console.ReadKey();
        }
     
    }
}
