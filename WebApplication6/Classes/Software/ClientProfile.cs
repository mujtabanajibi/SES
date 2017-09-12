using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Classes.Software
{
    public class ClientProfile
    {
        public ClientProfile()
        {
            AssetList = new List<Asset>();
        }

        public int ID { get; set; }
        public string OwnerName { get; set; }
        public string ContactNo { get; set; }
        public string ContactAddress { get; set; }
        public string CompanyName { get; set; }
        public string RegistrationDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public DateTime ClientLocalCountryDateTime { get; set; }

        public List<Asset> AssetList { get; set; }
    }
}