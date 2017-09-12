using System;
using System.IO;
using System.Web.UI;

namespace WebApplication6
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sr = new StreamReader(Request.InputStream);
            string content = sr.ReadToEnd();
            if (content != "")
            {
                content = XmlFileTrimmer(content, "<?xml", "</Sender>");
                Sender sndr = DeSerializer.XMLToObjectConverter(content, "03003509231");

            }

            //Sender sndr = DeSerializer.XMLToObjectConverter
            //    (HttpContext.Current.Server.MapPath("~/" + "SenderLog" + ".xml"), "345345");
        }
        private static string XmlFileTrimmer
            (string content, string startRemovingString, string lastRemovingString)
        {
            content = content.Remove(0, content.IndexOf(startRemovingString));

            for (int i = content.Length; i > 0; i--)
            {
                string strs = content.Substring(i - lastRemovingString.Length, lastRemovingString.Length);

                if (strs.Equals(lastRemovingString))
                {
                    break;
                }
                content = content.Remove(i - 1);
            }
            return content;
        }
    }
}