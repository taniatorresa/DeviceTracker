﻿using System.Management;
namespace DeviceTrackerTest
{
    public class WMIOperation
    {
        public static ManagementObjectCollection WMIQuery(string strwQuery)
        {
            ObjectQuery oQuery = new ObjectQuery(strwQuery);
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oQuery);
            ManagementObjectCollection oReturnCollection = oSearcher.Get();
            return oReturnCollection;
        }
    }
}
