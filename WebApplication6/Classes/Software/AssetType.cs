using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Classes.Software
{
    public class AssetType
    {
        public AssetType()
        {
            AssetRequiredFieldsList = new List<AssetRequiredFields>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<AssetRequiredFields> AssetRequiredFieldsList { get; set; }

    }
}