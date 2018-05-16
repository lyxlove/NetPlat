using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Web;

namespace LogHelper
{
    public static class ReadConfig
    {
        public static string GetValueFromXML(string nodeName,string arrtiName)
        {
            string strRet = "";
            try
            {
                XmlDocument doc = new XmlDocument();
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"bin\NetConfig.xml";

                doc.Load(strPath);

                XmlElement rootElem = doc.DocumentElement;
                XmlNode node = rootElem.SelectSingleNode("//" + nodeName);

                XmlNodeList lstNodes = node.ChildNodes;

                foreach (XmlNode v in lstNodes)
                {
                    if (v.Attributes["isused"].Value == "1")
                    {
                        strRet = v.Attributes[arrtiName].Value;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                strRet = @"data source=JCX-server\localdb;initial catalog=IVS30;persist security info=True;user id=sa;password=; MultipleActiveResultSets=true;";
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "查找配置文件出错：配置文件路径为" + AppDomain.CurrentDomain.BaseDirectory + @"\bin\NetConfig.xml" + "错误消息为：" + ex.Message;

                logInfo.Name = "读取配置文件";
                logInfo.FunName = "ReadConfig.cs -> GetValueFromXML(" + nodeName + "," + arrtiName + ")";

                Log.WriteLog(logInfo);
                #endregion
            }
            return strRet;
        }
    }
}
