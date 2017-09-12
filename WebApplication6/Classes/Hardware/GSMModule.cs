using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication6
{
    public class GSMModule
    {
        public GSMModule()
        {
            SMSList = new List<SMS>();
            GSMModulesLogging = new List<GSMModule>();
        }

        public List<SMS> SMSList { get; set; }
        public string SIMNo { get; set; }
        public string IMEI { get; set; }
        public string Model { get; set; }
        public string ServiceProvider { get; set; }
        public string SignalStrength { get; set; }
        public string PING { get; set; }
        public string SenderID { get; set; }
        public List<GSMModule> GSMModulesLogging { get; set; }
    }
}
