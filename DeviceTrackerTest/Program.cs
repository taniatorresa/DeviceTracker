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
            string strWQuery = "SELECT DeviceID, Name, Description, "
                + "Status "
                + "FROM Win32_Keyboard ";
            ManagementObjectCollection keyboards = WMIOperation.WMIQuery(strWQuery);
            foreach (ManagementObject moKeyboard in keyboards)
            {
                try
                {
                    Console.WriteLine("ID " + moKeyboard["DeviceId"].ToString());
                    Console.WriteLine("nombre " + moKeyboard["Name"].ToString());
                    Console.WriteLine("Descripcion " + moKeyboard["Description"].ToString());
                    Console.WriteLine("Estatus" +moKeyboard["Status"].ToString());
                }
                catch (NullReferenceException)
                {

                }
             


                Console.WriteLine("Pulse una tecla para terminar ...");
                Console.ReadKey();
            }
        }
        

    }
}