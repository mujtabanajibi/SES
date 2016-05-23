using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Classes.Software
{
    public class ChannelDataValidation
    {
        public string ModelID { get; set; }
        public int ChannelNumber { get; set; }
        public string DataType { get; set; }
        public string Unit { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
    }
}