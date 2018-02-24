using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

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
            List<NetworkAdapter> allNetworkAdapter = new List<NetworkAdapter>();


            string strWQuery = "SELECT DeviceID, ProductName, Description, "
                + "NetEnabled, NetConnectionStatus "
                + "FROM Win32_NetworkAdapter "
                + "WHERE Manufacturer <> 'Microsoft' ";
            ObjectQuery oQuery = new System.Management.ObjectQuery(strWQuery);
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oQuery);
            ManagementObjectCollection oReturnCollection = oSearcher.Get();


            foreach (ManagementObject mo in oReturnCollection)
            {
                NetEnabled = (Convert.ToBoolean(mo["NetEnabled"].ToString())) ? 1 : -1;
                allNetworkAdapter.Add(new NetworkAdapter(
                    Convert.ToInt32(mo["DeviceID"].ToString()),
                    mo["ProductName"].ToString(),
                    mo["Description"].ToString(),
                    netEnabled,
                    Convert.ToInt32(mo["NetConnectionStatus"].ToString())));
            };
            return allNetworkAdapter;



            Console.WriteLine("Pulse una tecla para terminar ...");
            Console.ReadKey();
        }
     
    }
}
