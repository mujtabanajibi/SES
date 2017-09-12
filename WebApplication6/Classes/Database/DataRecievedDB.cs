using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6
{
    public static class DataRecievedDB
    {
        public static void SaveSenderData(Sender sender)
        {
            //Check whether the received xml file is test mode or logging
            
            //if mode is test
            if (sender.Mode.Equals("Test"))
            {

            }

            //else if mode is normal
            else if (sender.Mode.Equals("Normal"))
            {
                
            }
        }
    }
}