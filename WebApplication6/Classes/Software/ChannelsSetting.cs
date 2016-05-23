using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Classes.Software
{
    public class ChannelsSetting
    {
        public int AssetID { get; set; }
        public int ChannelNumber { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double ScalingValueMin { get; set; }
        public double ScalingValueMax { get; set; }
        public double Gain { get; set; }
        public double Offset { get; set; }
        public DateTime LastCalibrationDate { get; set; }
        public DateTime DueCalibrationDate { get; set; }
        public string DataType { get; set; }
    }
}