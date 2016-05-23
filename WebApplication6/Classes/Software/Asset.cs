using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Classes.Software
{
    public class Asset
    {
        public Asset()
        {
            AssetDetailList = new List<AssetDetail>();
            AssetAlarmList = new List<AssetAlarm>();
            ChannelsSettingList = new List<ChannelsSetting>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string DeviceID { get; set; }
        public int ClientID { get; set; }
        public string ViewSettings { get; set; }
        public string LoggingTableName { get; set; }
        public string Model { get; set; }
        public string AssetsTypeID { get; set; }

        public List<AssetDetail> AssetDetailList { get; set; }
        public List<AssetAlarm> AssetAlarmList { get; set; }
        public List<ChannelsSetting> ChannelsSettingList { get; set; }
    }
}