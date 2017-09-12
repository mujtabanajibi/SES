using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6
{
    public class SMS
    {
        public string SimNo { get; set; }
        public string Message { get; set; }
        public DateTime MsgRecievedDateTime { get; set; }
        public string RecievedFrom { get; set; }
        public DateTime DateNTime { get; set; }
    }
}