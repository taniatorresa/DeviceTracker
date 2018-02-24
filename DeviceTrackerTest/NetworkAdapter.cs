using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceTrackerTest
{
    public class NetworkAdapter
    {
        public int DeviceId
        {
            get;
            private set;
        }

        /// <summary> 
        /// The ProductName of the NetworkAdapter 
        /// </summary> 
        public string Name
        {
            get;
            private set;
        }


        /// <summary> 
        /// The NetEnabled status of the NetworkAdapter 
        /// </summary> 
        public int NetEnabled
        {
            get;
            private set;
        }


        /// <summary> 
        /// The Net Connection Status Value 
        /// </summary> 
        public int NetConnectionStatus
        {
            get;
            private set;
        }

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
    }
}
