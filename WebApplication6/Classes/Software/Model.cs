using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Classes.Software
{
    public class Model
    {
        public Model()
        {
            ChannelDataValidationList = new List<ChannelDataValidation>();
            ConfigurableModelsList = new List<ConfigurableModels>();

        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ChannelDataValidation> ChannelDataValidationList { get; set; }
        public List<ConfigurableModels> ConfigurableModelsList { get; set; }


    }
}