using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace WebApplication6
{
    public static class DeSerializer
    {       
        public static Sender XMLToObjectConverter(string xmlString, string receivedFrom)
        {
            Sender sender = new Sender();
            var readerSettings = new XmlReaderSettings { ConformanceLevel = ConformanceLevel.Fragment };
            using (var strReader = new StringReader(xmlString))
            using (XmlReader xmlReader = XmlReader.Create(strReader, readerSettings))
            {
                if (xmlReader.IsStartElement("Sender"))
                {
                    xmlReader.MoveToContent();
                    while (xmlReader.MoveToNextAttribute())
                    {
                        switch (xmlReader.Name)
                        {
                            case "ID":
                                sender.ID = xmlReader.Value;
                                break;
                            case "Mode":
                                sender.Mode = xmlReader.Value;
                                break;
                            case "Model":
                                sender.Model = xmlReader.Value;
                                break;
                            case "BatteryLevel":
                                sender.BatteryLevel = Convert.ToInt32(xmlReader.Value);
                                break;
                            case "Charging":
                                sender.Charging = xmlReader.ReadContentAsBoolean();
                                break;
                            case "WifiSignal":
                                sender.WifiSignalStrength = Convert.ToInt32(xmlReader.Value);
                                break;
                            default:
                                break;
                        }
                    }

                    xmlReader.MoveToContent();

                    if (xmlReader.ReadToDescendant("GSMModules") || xmlReader.ReadToNextSibling("GSMModules") )
                    {
                        List<GSMModule> gsmModuleList = new List<GSMModule>();

                        xmlReader.MoveToContent();
                        XmlReader xmlInnerReader = xmlReader.ReadSubtree();

                        while (xmlInnerReader.ReadToDescendant("GSMModule") || xmlInnerReader.ReadToNextSibling("GSMModule"))
                        {
                            GSMModule gsmModule = new GSMModule();
                            xmlInnerReader.MoveToContent();

                            while (xmlInnerReader.MoveToNextAttribute())
                            {
                                switch (xmlInnerReader.Name)
                                {
                                    case "SIMNo":
                                        gsmModule.SIMNo = xmlInnerReader.Value;
                                        break;
                                    case "IMEI":
                                        gsmModule.IMEI = xmlInnerReader.Value;
                                        break;
                                    case "model":
                                        gsmModule.Model = xmlInnerReader.Value;
                                        break;
                                    case "ServiceProvider":
                                        gsmModule.ServiceProvider = xmlInnerReader.Value;
                                        break;
                                    case "SignalStrength":
                                        gsmModule.SignalStrength = xmlInnerReader.Value;
                                        break;
                                    case "PING":
                                        gsmModule.PING = xmlInnerReader.Value;
                                        break;
                                    default:
                                        break;
                                }
                            }

                            List<SMS> smsList = new List<SMS>();
                            xmlInnerReader.MoveToContent();

                            while (xmlInnerReader.ReadToDescendant("SMS") || xmlInnerReader.ReadToNextSibling("SMS"))
                            {
                                SMS sms = new SMS();
                                while (xmlInnerReader.MoveToNextAttribute())
                                {
                                    switch (xmlInnerReader.Name)
                                    {
                                        case "MsgRecievedFrom":
                                            sms.RecievedFrom = xmlInnerReader.Value;
                                            break;
                                        case "Message":
                                            sms.Message = xmlInnerReader.Value;
                                            break;
                                        case "MsgRecievedDateTime":
                                            // sms.MsgRecievedDateTime = Convert.ToDateTime(xmlInnerReader.Value);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                smsList.Add(sms);
                            }

                            gsmModule.SMSList = smsList;
                            gsmModuleList.Add(gsmModule);
                        }
                        xmlInnerReader.Close();
                        sender.GSMModuleList = gsmModuleList;
                    }

                    if (xmlReader.ReadToDescendant("Devices") || xmlReader.ReadToNextSibling("Devices"))
                    {
                        List<Device> deviceList = new List<Device>();

                        xmlReader.MoveToContent();

                        while (xmlReader.ReadToDescendant("Device") || xmlReader.ReadToNextSibling("Device"))
                        {
                            Device device = new Device();

                            XmlReader xmlInnerReader = xmlReader.ReadSubtree();
                            xmlInnerReader.MoveToContent();

                            while (xmlInnerReader.MoveToNextAttribute())
                            {
                                switch (xmlInnerReader.Name)
                                {
                                    case "ID":
                                        device.ID = xmlInnerReader.Value;
                                        break;
                                    case "Model":
                                        device.Model = xmlInnerReader.Value;
                                        break;
                                    case "SamplesInterval":
                                        device.SamplesInterval = Convert.ToInt32(xmlInnerReader.Value);
                                        break;
                                    case "UpdateInterval":
                                        device.UpdateInterval = Convert.ToInt32(xmlInnerReader.Value);
                                        break;
                                    default:
                                        break;
                                }
                            } 
                            xmlInnerReader.MoveToContent();

                            if (xmlInnerReader.ReadToDescendant("Parameters"))
                            {
                                List<Parameter> parameterList = new List<Parameter>();

                                xmlInnerReader.MoveToContent();

                                while (xmlInnerReader.ReadToDescendant("Parameter") || xmlInnerReader.ReadToNextSibling("Parameter"))
                                {
                                    Parameter parameter = new Parameter();

                                    while (xmlInnerReader.MoveToNextAttribute())
                                    {
                                        switch (xmlInnerReader.Name)
                                        {
                                            case "DateTime":
                                                //parameter.DateNTime = Convert.ToDateTime(xmlInnerReader.Value);
                                                break;
                                            case "Event":
                                                // parameter.Event = Convert.ToBoolean(xmlInnerReader.Value);
                                                break;
                                            default:
                                                break;
                                        }
                                    }

                                    xmlInnerReader.MoveToContent();

                                    while (xmlInnerReader.ReadToDescendant("Channel") || xmlInnerReader.ReadToNextSibling("Channel"))
                                    {
                                        Channel channel = new Channel();
                                        while (xmlInnerReader.MoveToNextAttribute())
                                        {
                                            switch (xmlInnerReader.Name)
                                            {
                                                case "ID":
                                                    channel.ID = Convert.ToInt32(xmlInnerReader.Value);
                                                    break;
                                                case "Value":
                                                    channel.Value = xmlInnerReader.Value;
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                        parameter.ChannelList.Add(channel);
                                    }
                                    parameterList.Add(parameter);
                                }
                                device.ParameterList = parameterList;
                            }
                            xmlInnerReader.Close();
                            deviceList.Add(device);
                        }
                        sender.DeviceList = deviceList;
                    }
                }
            }
            return sender;
        }

        public static bool ValidateXMLFile(string fileName)
        {
            XmlSchemaSet schema = new XmlSchemaSet();

            // Add the schema to the collection.
            schema.Add("", HttpContext.Current.Server.MapPath
            ("~/" + "SenderLogSchema" + ".xsd"));
            XDocument xmlDocument = XDocument.Load(HttpContext.Current.Server.MapPath
            ("~/" + fileName + ".xml"));

            bool validationErrors = false;

            xmlDocument.Validate(schema, (s, e) =>
            {
                Console.WriteLine(e.Message);
                validationErrors = true;
            });

            if (validationErrors)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}