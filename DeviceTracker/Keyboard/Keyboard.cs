using System;
using System.Collections.Generic;
using System.Threading;
using System.Management;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceTracker.WMI;
using DeviceTracker.Properties;

namespace DeviceTracker.Keyboard
{
    internal class Keyboard
    {

        public string DeviceID
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public string Status
        {
            get;
            private set;
        }
        public Keyboard(string deviceID,
       string name,
       string status)
        {
            DeviceID = deviceID;
            Name = name;
            Status = status;
        }

        public Keyboard(string deviceID)
        {
            ManagementObject crtKeyboard = new ManagementObject();
            string strWQuery = string.Format("SELECT DeviceID, Description, "
                + " Status "
                + "FROM Win32_Keyboard "
                + "WHERE DeviceID = {0}", deviceID);
            try
            {
                ManagementObjectCollection keyboards
                    = WMIOperation.WMIQuery(strWQuery);

                foreach (ManagementObject keyboard in keyboards)
                {

                    crtKeyboard = keyboard;
                    break;
                }

                DeviceID = deviceID;
                Name = crtKeyboard["Description"].ToString();
                Status = crtKeyboard["Status"].ToString();
            }
            catch (NullReferenceException)
            {

                DeviceID = string.Empty;
                Name = string.Empty;
                Status = string.Empty;
            }
        }

        public static List<Keyboard> GetAllKeyboards()
        {
            List<Keyboard> allKeyboards = new List<Keyboard>();

            string strWQuery = "SELECT DeviceID, Description, "
                + "Status "
                + "FROM Win32_Keyboard ";

            ManagementObjectCollection keyboards = WMIOperation.WMIQuery(strWQuery);
            foreach (ManagementObject moKeyboard in keyboards)
            {
                try
                {
                    allKeyboards.Add(new Keyboard(
                        moKeyboard["DeviceID"].ToString(),
                        moKeyboard["Description"].ToString(),
                        moKeyboard["Status"].ToString()
                        ));
                }
                catch (NullReferenceException)
                {

                }
            }

            return allKeyboards;
        }

    }
}
