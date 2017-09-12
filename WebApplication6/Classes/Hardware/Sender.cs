using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication6
{
    public class Sender
    {
        public Sender()
        {
            DeviceList = new List<Device>();
            GSMModuleList = new List<GSMModule>();
            SenderDataLogging = new List<Sender>();
        }

        public List<GSMModule> GSMModuleList { get; set; }
        public List<Device> DeviceList { get; set; }
        public List<Sender> SenderDataLogging { get; set; }

        public string ID { get; set; }
        public string Mode { get; set; }
        public string Model { get; set; }
        public int BatteryLevel { get; set; }
        public bool Charging { get; set; }
        public int WifiSignalStrength { get; set; }
        public string RecieveStatus { get; set; }
        public string RecievedFrom { get; set; }
        public DateTime RecieveDateNTime { get; set; }
        public DateTime LastSync { get; set; }
    }
}