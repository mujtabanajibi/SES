using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Classes.Software
{
    public class AssetAlarm
    {
        public int AssetID { get; set; }
        public int ChannelNumber { get; set; }
        public double GreaterThan { get; set; }
        public double EqualsTo { get; set; }
        public double LessThan { get; set; }
        public string MessageContact { get; set; }
    }
}