using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Configurations
    {
        public static string UserName = "admin";
        public static string Password = "admin";
        public static string UrlIPAddress = "";

        public static string GetCurrentUrl()
        {
            string url = string.Empty;
            string apppath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\app.txt";
            string str = System.IO.File.ReadAllText(apppath);
            string data = getBetween(str, "value", "/>");
            data = data.Trim('=');
            data = data.Trim('"');
            UrlIPAddress = data;
            string portdata = getBetween(str, "ws_port", "/>");
            portdata = portdata.Trim('"', ' ');
            string[] tempdata = portdata.Split('=');
            portdata = tempdata[1].ToString().Trim('"');
            if (!string.IsNullOrEmpty(portdata))
            {
                url = @"http://" + data + ":" + portdata + "/Ws_kansai/WB_Kansai.asmx";
            }
            else
            {
                url = @"http://" + data + "/Ws_kansai/WB_Kansai.asmx";
            }


            return url;
        }

        static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }

    }
}
