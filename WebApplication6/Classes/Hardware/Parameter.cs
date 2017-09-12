using System;
using System.Collections.Generic;

namespace WebApplication6
{
    public class Parameter
    {
        public Parameter()
        {
            ChannelList = new List<Channel>();
        }

        public DateTime DateNTime { get; set; }
        public bool Event { get; set; }
        public List<Channel> ChannelList { get; set; }
    }
}