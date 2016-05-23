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
                //check if sender is saved 
                if (SenderIsSaved(sender.ID))
                { 
                        // then check if saved and matched then return 0
                        if (SavedOrMatchedDevices()&& SavedOrMatchedGSMModules())
	                    {
		                    // return a Ok response to sender 		 
	                    }
                        //else if not save then save devices or gsmmodule data
                        else
	                    {
                            if (!SaveDevices())
	                        {
		 
	                        }
                            else if (!SaveGSMModules())
	                        {
		 
	                        }
	                    }
                     }
                //else not available then
                else
                {
                    SaveSenderDataToDatabase();
                    //then save the sender, device, gsmmodule data to their respective tables 
                }
            }
            //else if mode is normal
            else if (sender.Mode.Equals("Normal"))
            {
                //then compare the sender, device and Gsmmodule to their respective tables
                //if all matched then
                if (VerifySender() && VerifyDevices() && VerifyGsmmodule())
	            {
		        //then  check assets table 
                //save Allocated devices 
                    SaveAllocatedDevices(sender.DeviceList);
                    SaveGSMModulesLogging(sender.GSMModuleList);
                    SaveSMSes(sender.GSMModuleList);
			               
                //send Ok response to sender       
	            }
                
                //else not matched then
                else
	            {
                  //sends the device a test command to reconfigure the sender, device, gsmmodule
	            }
            }
        }

        private static void SaveSMSes(List<GSMModule> list)
        {
            throw new NotImplementedException();
        }

        private static void SaveGSMModulesLogging(List<GSMModule> list)
        {
            throw new NotImplementedException();
        }

        private static void SaveGSMModulesLogging()
        {
            throw new NotImplementedException();
        }

        private static void SaveAllocatedDevices(List<Device> list)
        {
            throw new NotImplementedException();
        }

        private static bool VerifySender()
        {
            throw new NotImplementedException();
        }

        private static bool VerifyDevices()
        {
            throw new NotImplementedException();
        }

        private static bool VerifyGsmmodule()
        {
            throw new NotImplementedException();
        }

        private static bool SavedOrMatchedDevices()
        {
            throw new NotImplementedException();
        }

        private static bool SaveDevices()
        {
            throw new NotImplementedException();
        }

        private static bool SaveGSMModules()
        {
            throw new NotImplementedException();
        }

        private static bool SavedOrMatchedGSMModules()
        {
            throw new NotImplementedException();
        }

        private static bool SenderIsSaved(string senderID)
        {
            //
            throw new NotImplementedException();
        }

        private static void SaveSenderDataToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}