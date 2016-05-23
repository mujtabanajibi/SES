using System;
using System.Collections.Generic;

namespace WebApplication6
{
    public class Device
    {
        public Device()
        {
            ParameterList = new List<Parameter>();
        }

        public List<Parameter> ParameterList { get; set; }
        public string ID { get; set; }
        public string Model { get; set; }
        public int UpdateInterval { get; set; }
        public int SamplesInterval { get; set; }
        public string SenderID { get; set; }

    }
}