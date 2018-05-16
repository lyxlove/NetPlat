using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleNetBase;
using gfVehicleLibraryAJ;
using ConvertInfo;
using LogHelper;
using System.Threading.Tasks;

namespace VehicleForNetWebServices
{
    public class AJ_Read_WebServices : AJ_IRead
    {
        public AJ_Read_WebServices()
        {
            TimeOut = 30;
        }

        public int TimeOut { get; set; }

        public Vehicle_18C49_Result Read_18C49(Vehicle_18C49_Para para)
        {
            Vehicle_18C49_Result m_Vehicle_18C49_Result = new Vehicle_18C49_Result();
            AJ_ModelToXML modelToXml = new AJ_ModelToXML();
            string strQueryXmlDoc = modelToXml.ModelToXml("18C49", para);

            #region 填充联网公司接口
            string strResult = "";
#if RZLD
            var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
            var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
            client.Open();
            client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
            strResult = client.queryObjectOut(para.xtlb, para.jkxlh, para.jkid, strQueryXmlDoc);
            if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
            {
                client.Close();
            }
            #endregion

            AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
            m_Vehicle_18C49_Result = (Vehicle_18C49_Result)xmlToModel.Result_XmlToModel("18C49", strResult);

            #region 联网日志记录
            NETLOG_INFO log = new NETLOG_INFO();
            log.LWLSH = para.hpzl + (string.IsNullOrEmpty(para.hphm) ? "" : para.hphm);
            log.LWType = "AJ";
            log.SendInfo = strQueryXmlDoc;
            log.RevcInfo = strResult;
            log.JKName = para.jkid;
            log.JYXM = "";
            if (m_Vehicle_18C49_Result == null || string.IsNullOrEmpty(m_Vehicle_18C49_Result.code))
            {
                log.IsSuc = "0";
            }
            else
            {
                log.IsSuc = m_Vehicle_18C49_Result.code;
            }
            log.LogTime = DateTime.Now;

            bool b = LogHelper.Log.WriteJKLog(log);
            #endregion

            return m_Vehicle_18C49_Result;
        }

        public Vehicle_18C50_Result Read_18C50(Vehicle_18C50_Para para)
        {
            Vehicle_18C50_Result m_Vehicle_18C50_Result = new Vehicle_18C50_Result();
            try
            {
                //ModelToXML
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strQueryXmlDoc = modelToXml.ModelToXml("18C50", para);

                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
            var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.queryObjectOut(para.xtlb, para.jkxlh, para.jkid, strQueryXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18C50_Result = (Vehicle_18C50_Result)xmlToModel.Result_XmlToModel("18C50", strResult);

                #region 日志记录
                string strCategory = Log.LogType.NetUpDown.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = System.Net.Dns.GetHostAddresses(logInfo.HostName).GetValue(1).ToString();
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strQueryXmlDoc;
                logInfo.JS_Infor = strResult;
                logInfo.Log_Infor = "18C50";
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Read_WebServices.cs -> Read_18C50";

                Log.WriteLog(logInfo);
                #endregion
            }
            catch(Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = System.Net.Dns.GetHostAddresses(logInfo.HostName).GetValue(1).ToString();
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "18C50:" + ex.Message;
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Read_WebServices.cs -> Read_18C50";

                Log.WriteLog(logInfo);
                #endregion

            }

            return m_Vehicle_18C50_Result;
        }

        public Vehicle_18J52_Result Read_18J52(Vehicle_18J52_Para para)
        {
            Vehicle_18J52_Result m_Vehicle_18J52_Result = new Vehicle_18J52_Result();
            try
            {
                //ModelToXML
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strQueryXmlDoc = modelToXml.ModelToXml("18J52", para);

                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
            var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.queryObjectOut(para.xtlb, para.jkxlh, para.jkid, strQueryXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18J52_Result = (Vehicle_18J52_Result)xmlToModel.Result_XmlToModel("18J52", strResult);

                #region 日志记录
                string strCategory = Log.LogType.NetUpDown.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = System.Net.Dns.GetHostAddresses(logInfo.HostName).GetValue(1).ToString();
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strQueryXmlDoc;
                logInfo.JS_Infor = strResult;

                logInfo.Log_Infor = "18J52" + m_Vehicle_18J52_Result.ccrq + "," + m_Vehicle_18J52_Result.clpp1;
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Read_WebServices.cs -> Read_18J52";

                Log.WriteLog(logInfo);

                NETLOG_INFO netInfo = new NETLOG_INFO();
                netInfo.JKName = "18J52";
                netInfo.RevcInfo = strResult;
                netInfo.SendInfo = strQueryXmlDoc;
                netInfo.JCLSH = m_Vehicle_18J52_Result.hphm;
                netInfo.JYCS = m_Vehicle_18J52_Result.jycs.ToString();
                netInfo.LogTime = DateTime.Now;
                netInfo.IsSuc = m_Vehicle_18J52_Result.code;
                netInfo.JYXM = m_Vehicle_18J52_Result.jyxm;
                Log.WriteJKLog(netInfo);
                #endregion
            }
            catch (Exception ex)
            {
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = System.Net.Dns.GetHostAddresses(logInfo.HostName).GetValue(1).ToString();
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "18J52->"+ex.Message;
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Read_WebServices.cs -> Read_18J52";

                Log.WriteLog(logInfo);
            }

            return m_Vehicle_18J52_Result;
        }

        public Vehicle_18J80_Result Read_18J80(Vehicle_18J80_Para para)
        {
            Vehicle_18J80_Result m_Vehicle_18J80_Result = new Vehicle_18J80_Result();

            return m_Vehicle_18J80_Result;
        }

        public Vehicle_18X01_Result Read_18X01(Vehicle_18X01_Para para)
        {
            Vehicle_18X01_Result m_Vehicle_18X01_Result = new Vehicle_18X01_Result();
            try
            {
                //ModelToXML
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strQueryXmlDoc = modelToXml.ModelToXml("18X01", para);

                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
            var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.queryObjectOut(para.xtlb, para.jkxlh, para.jkid, strQueryXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18X01_Result = (Vehicle_18X01_Result)xmlToModel.Result_XmlToModel("18X01", strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.JYXM = "F1";
                log.LWType = "AJ";
                log.SendInfo = strQueryXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18X01_Result == null || string.IsNullOrEmpty(m_Vehicle_18X01_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18X01_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = System.Net.Dns.GetHostAddresses(logInfo.HostName).GetValue(1).ToString();
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "18X01->" + ex.Message;
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Read_WebServices.cs -> Read_18X01";

                Log.WriteLog(logInfo);
            }

            return m_Vehicle_18X01_Result;
        }

        public Vehicle_18X02_Result Read_18X02(Vehicle_18X02_Para para)
        {
            Vehicle_18X02_Result m_Vehicle_18X02_Result = new Vehicle_18X02_Result();
            try
            {
                //ModelToXML
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strQueryXmlDoc = modelToXml.ModelToXml("18X02", para);

                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
            var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.queryObjectOut(para.xtlb, para.jkxlh, para.jkid, strQueryXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18X02_Result = (Vehicle_18X02_Result)xmlToModel.Result_XmlToModel("18X02", strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.JYXM = "C1";
                log.LWType = "AJ";
                log.SendInfo = strQueryXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18X02_Result == null || string.IsNullOrEmpty(m_Vehicle_18X02_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18X02_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = System.Net.Dns.GetHostAddresses(logInfo.HostName).GetValue(1).ToString();
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "18X02->" + ex.Message;
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Read_WebServices.cs -> Read_18X02";

                Log.WriteLog(logInfo);
            }

            return m_Vehicle_18X02_Result;
        }

        public Vehicle_18X03_Result Read_18X03(Vehicle_18X03_Para para)
        {
            Vehicle_18X03_Result m_Vehicle_18X03_Result = new Vehicle_18X03_Result();
            try
            {
                //ModelToXML
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strQueryXmlDoc = modelToXml.ModelToXml("18X03", para);

                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
            var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.queryObjectOut(para.xtlb, para.jkxlh, para.jkid, strQueryXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18X03_Result = (Vehicle_18X03_Result)xmlToModel.Result_XmlToModel("18X03", strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.JYXM = "DC";
                log.LWType = "AJ";
                log.SendInfo = strQueryXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18X03_Result == null || string.IsNullOrEmpty(m_Vehicle_18X03_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18X03_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = System.Net.Dns.GetHostAddresses(logInfo.HostName).GetValue(1).ToString();
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "18X03->" + ex.Message;
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Read_WebServices.cs -> Read_18X03";

                Log.WriteLog(logInfo);
            }

            return m_Vehicle_18X03_Result;
        }

        /// <summary>
        /// 查詢外廓尺寸測量結果
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18W06_Result Read_18W06(Vehicle_18W06_Para para)
        {
            Vehicle_18W06_Result _RESULT_18W06 = new Vehicle_18W06_Result();
            try
            {
                AJ_ModelToXML model2XML = new AJ_ModelToXML();
                string _QueryXMLDoc = model2XML.ModelToXml("18W06", para);

                string strResult = "";

                var client = new VehicleForNetWebService.ctwkService.JcxlwServerSoapClient();

                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.queryObjectOut(para.xtlb, para.jkxlh, para.jkid, _QueryXMLDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                _RESULT_18W06 = (Vehicle_18W06_Result)xmlToModel.Result_XmlToModel("18W06", strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.lsh;
                log.JYXM = "DC";
                log.LWType = "AJ";
                log.SendInfo = _QueryXMLDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (_RESULT_18W06 == null || string.IsNullOrEmpty(_RESULT_18W06.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = _RESULT_18W06.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = System.Net.Dns.GetHostAddresses(logInfo.HostName).GetValue(1).ToString();
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "18X03->" + ex.Message;
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Read_WebServices.cs -> Read_18W06";

                Log.WriteLog(logInfo);
            }

            return _RESULT_18W06;
        }
    }
}
