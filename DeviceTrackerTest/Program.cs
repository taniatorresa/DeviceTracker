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
            ConnectionOptions conOptions = new ConnectionOptions();
            ManagementPath path = new  ManagementPath("\\\\.\\root\\cimv2");
            ManagementScope mngscope = new ManagementScope(path, conOptions);
      

            mngscope.Connect();
            //Conexion al WMI services 

          
            Console.WriteLine("Pulse una tecla para terminar ...");
            Console.ReadKey();
        }
    }
}
