using System;
using System.Collections.Generic;
using System.Threading;
using System.Management;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceTracker.WMI;
using DeviceTracker.Properties;
namespace DeviceTracker.NetworkAdapter
{
    internal class NetworkAdapter
    {
        #region NetworkAdapter Propiedades

        public int DeviceId
        {
            get;
            private set;
        }

  
        public string Name
        {
            get;
            private set;
        }


        public int NetEnabled
        {
            get;
            private set;
        }

    
        public int NetConnectionStatus
        {
            get;
            private set;
        }

        public static string[] SaNetConnectionStatus =
        {
            Resources.NetConnectionStatus0,
            Resources.NetConnectionStatus1,
            Resources.NetConnectionStatus2,
            Resources.NetConnectionStatus3,
            Resources.NetConnectionStatus4,
            Resources.NetConnectionStatus5,
            Resources.NetConnectionStatus6,
            Resources.NetConnectionStatus7,
            Resources.NetConnectionStatus8,
            Resources.NetConnectionStatus9,
            Resources.NetConnectionStatus10,
            Resources.NetConnectionStatus11,
            Resources.NetConnectionStatus12
        };


        private enum EnumNetEnabledStatus
        {
            Disabled = -1,
            Unknow,
            Enabled
        }

        
        private enum EnumEnableDisableResult
        {
            Fail = -1,
            Unknow,
            Success
        }

        #endregion

        #region C

        public NetworkAdapter(int deviceId,
            string name,
            int netEnabled,
            int netConnectionStatus)
        {
            DeviceId = deviceId;
            Name = name;
            NetEnabled = netEnabled;
            NetConnectionStatus = netConnectionStatus;
        }

        public NetworkAdapter(int deviceId)
        {
            ManagementObject crtNetworkAdapter = new ManagementObject();
            string strWQuery = string.Format("SELECT DeviceID, ProductName, "
                + "NetEnabled, NetConnectionStatus "
                + "FROM Win32_NetworkAdapter "
                + "WHERE DeviceID = {0}", deviceId);
            try
            {
                ManagementObjectCollection networkAdapters
                    = WMIOperation.WMIQuery(strWQuery);

                foreach (ManagementObject networkAdapter in networkAdapters)
                {
                   
                    crtNetworkAdapter = networkAdapter;
                    break;
                }

                DeviceId = deviceId;
                Name = crtNetworkAdapter["ProductName"].ToString();
                NetEnabled = (
                    Convert.ToBoolean(crtNetworkAdapter["NetEnabled"].ToString()))
                    ? (int)EnumNetEnabledStatus.Enabled
                    : (int)EnumNetEnabledStatus.Disabled;

                NetConnectionStatus = Convert.ToInt32(
                    crtNetworkAdapter["NetConnectionStatus"].ToString());
            }
            catch (NullReferenceException)
            {

                DeviceId = -1;
                Name = string.Empty;
                NetEnabled = 0;
                NetConnectionStatus = -1;
            }
        }

        #endregion

        #region Get NetEnabled Status Of The NetworkAdapter


        public int GetNetEnabled()
        {
            int netEnabled = (int)EnumNetEnabledStatus.Unknow;
            string strWQuery = string.Format("SELECT NetEnabled FROM Win32_NetworkAdapter "
                + "WHERE DeviceID = {0}", DeviceId);
            try
            {
                ManagementObjectCollection networkAdapters =
                    WMIOperation.WMIQuery(strWQuery);
                foreach (ManagementObject networkAdapter in networkAdapters)
                {
                    netEnabled =
                        (Convert.ToBoolean(networkAdapter["NetEnabled"].ToString()))
                                     ? (int)EnumNetEnabledStatus.Enabled
                                     : (int)EnumNetEnabledStatus.Disabled;
                }
            }
            catch (NullReferenceException)
            {
                // If NullReferenceException return (EnumNetEnabledStatus.Unknow)
            }
            return netEnabled;
        }

        #endregion

        #region Get All NetworkAdapters


        public static List<NetworkAdapter> GetAllNetworkAdapter()
        {
            List<NetworkAdapter> allNetworkAdapter = new List<NetworkAdapter>();

            string strWQuery = "SELECT DeviceID, ProductName, "
                + "NetEnabled, NetConnectionStatus "
                + "FROM Win32_NetworkAdapter ";

            ManagementObjectCollection networkAdapters = WMIOperation.WMIQuery(strWQuery);
            foreach (ManagementObject moNetworkAdapter in networkAdapters)
            {
                try
                {
                    allNetworkAdapter.Add(new NetworkAdapter(
                        Convert.ToInt32(moNetworkAdapter["DeviceID"].ToString()),
                        moNetworkAdapter["ProductName"].ToString(),
                        (Convert.ToBoolean(moNetworkAdapter["NetEnabled"].ToString()))
                            ? (int)EnumNetEnabledStatus.Enabled
                            : (int)EnumNetEnabledStatus.Disabled,
                        Convert.ToInt32(moNetworkAdapter["NetConnectionStatus"].ToString()
                        )));
                }
                catch (NullReferenceException)
                {
                    
                }
            }

            return allNetworkAdapter;
        }

        #endregion

        #region Enable Or Disable The Network Adapter

      
        public int EnableOrDisableNetworkAdapter(string strOperation)
        {
            int resultEnableDisableNetworkAdapter = (int)EnumEnableDisableResult.Unknow;
            ManagementObject crtNetworkAdapter = new ManagementObject();

            string strWQuery = string.Format("SELECT DeviceID, ProductName, "
                + "NetEnabled, NetConnectionStatus "
                + "FROM Win32_NetworkAdapter " + "WHERE DeviceID = {0}", DeviceId);

            try
            {
                ManagementObjectCollection networkAdapters =
                    WMIOperation.WMIQuery(strWQuery);
                foreach (ManagementObject networkAdapter in networkAdapters)
                {
                    crtNetworkAdapter = networkAdapter;
                }

                crtNetworkAdapter.InvokeMethod(strOperation, null);

                Thread.Sleep(500);
                while (GetNetEnabled() != ((strOperation.Trim() == "Enable")
                                                ? (int)EnumNetEnabledStatus.Enabled
                                                : (int)EnumNetEnabledStatus.Disabled))
                {
                    Thread.Sleep(100);
                }

                resultEnableDisableNetworkAdapter =
                    (int)EnumEnableDisableResult.Success;
            }
            catch (NullReferenceException)
            {
       
                resultEnableDisableNetworkAdapter = (int)EnumEnableDisableResult.Fail;
            }

            crtNetworkAdapter.Dispose();

            return resultEnableDisableNetworkAdapter;
        }

        #endregion   
    }
}
