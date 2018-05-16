using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleNetBase;
using gfVehicleLibraryAJ;
using ConvertInfo;
using LogHelper;
using System.Web;

namespace VehicleForNetWebServices
{
    public class AJ_Write_WebServices : AJ_IWrite
    {
        public AJ_Write_WebServices()
        {
            TimeOut = 30;
        }

        public int TimeOut { get; set; }

        public Vehicle_18C51_Result Write_18C51(Vehicle_18C51_Para para)
        {
            Vehicle_18C51_Result m_Vehicle_18C51_Result = new Vehicle_18C51_Result();
            try
            {
                //ModelToXML
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strWriteXmlDoc = modelToXml.ModelToXml(para.jkid, para);

                #region 填充联网公司的联网接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18C51_Result = (Vehicle_18C51_Result)xmlToModel.Result_XmlToModel(para.jkid, strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.JYCS = para.jycs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.JYXM = para.jyxm;
                log.LWType = "AJ";
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18C51_Result == null || string.IsNullOrEmpty(m_Vehicle_18C51_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C51_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "4. [18C51]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C51";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C51_Result.code = "0";
                m_Vehicle_18C51_Result.message = ex.Message;
            }

            return m_Vehicle_18C51_Result;
        }

        /// <summary>
        /// 机动车信息更新
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18C66_Result Write_18C66(Vehicle_18C66_Para para)
        {
            Vehicle_18C66_Result m_Vehicle_18C66_Result = new Vehicle_18C66_Result();
            try
            {
#if BJXY
                if (para.jcxdh == "6")
                {
                    para.jcxdh = "2";
                }
#endif

                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strWriteXmlDoc = modelToXml.ModelToXml(para.jkid, para);



                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18C66_Result = (Vehicle_18C66_Result)xmlToModel.Result_XmlToModel(para.jkid, strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.JCLSH = para.jclsh;
                if (string.IsNullOrEmpty(para.jclsh) == false)
                {
                    log.JYCS = Convert.ToInt32(log.JCLSH.Split('-')[1]).ToString();
                }
                log.LWType = "AJ";
                log.JYXM = para.jyxm;
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18C66_Result == null || string.IsNullOrEmpty(m_Vehicle_18C66_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C66_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "4. [18C66]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C66";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C66_Result.code = "0";
                m_Vehicle_18C66_Result.message = ex.Message;
            }
            return m_Vehicle_18C66_Result;
        }

        public Vehicle_18J11_Result Write_18J11(Vehicle_18J11_Para para)
        {
            Vehicle_18J11_Result m_Vehicle_18J11_Result = new Vehicle_18J11_Result();
            try
            {
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strWriteXmlDoc = modelToXml.ModelToXml("18J11", para);

                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18J11_Result = (Vehicle_18J11_Result)xmlToModel.Result_XmlToModel("18J11", strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.LWType = "AJ";
                log.JYCS = "";
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                log.JYXM = para.gwxm;
                if (m_Vehicle_18J11_Result == null || string.IsNullOrEmpty(m_Vehicle_18J11_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18J11_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "4. [18J11]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18J11";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18J11_Result.code = "0";
                m_Vehicle_18J11_Result.message = ex.Message;
            }
            return m_Vehicle_18J11_Result;
        }

        public Vehicle_18J12_Result Write_18J12(Vehicle_18J12_Para para)
        {
            Vehicle_18J12_Result m_Vehicle_18J12_Result = new Vehicle_18J12_Result();
            try
            {
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strWriteXmlDoc = modelToXml.ModelToXml("18J12", para);

                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18J12_Result = (Vehicle_18J12_Result)xmlToModel.Result_XmlToModel("18J12", strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.LWType = "AJ";
                log.JYCS = "";
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                log.JYXM = para.gwxm;
                if (m_Vehicle_18J12_Result == null || string.IsNullOrEmpty(m_Vehicle_18J12_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18J12_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "4. [18J12]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18J12";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18J12_Result.code = "0";
                m_Vehicle_18J12_Result.message = ex.Message;
            }
            return m_Vehicle_18J12_Result;
        }

        public Vehicle_18C82_Result Write_18C82(Vehicle_18C82_Para para)
        {
            Vehicle_18C82_Result m_Vehicle_18C82_Result = new Vehicle_18C82_Result();
            try
            {
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
#if BJXY
                if (para.jcxdh == "6")
                {//灯光复检，将检测线代号6改为2
                    para.jcxdh = "2";
                }
#endif
                string strWriteXmlDoc = modelToXml.ModelToXml("18C82", para);

                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18C82_Result = (Vehicle_18C82_Result)xmlToModel.Result_XmlToModel("18C82", strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.LWType = "AJ";
                log.JYCS = para.zjccs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18C82_Result == null || string.IsNullOrEmpty(m_Vehicle_18C82_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C82_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion

            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strCategory;
                logInfo.Log_Infor = "4. [18C82]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C82";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C82_Result.code = "0";
                m_Vehicle_18C82_Result.message = ex.Message;
            }
            return m_Vehicle_18C82_Result;
        }

        public Vehicle_18C59_Result Write_18C59(Vehicle_18C59_Para para)
        {
            Vehicle_18C59_Result m_Vehicle_18C59_Result = new Vehicle_18C59_Result();
            try
            {
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
#if BJXY
                if (para.jcxdh == "6")
                {//灯光复检，将检测线代号6改为2
                    para.jcxdh = "2";
                }
#endif
                string strWriteXmlDoc = modelToXml.ModelToXml("18C59", para);

                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                
                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18C59_Result = (Vehicle_18C59_Result)xmlToModel.Result_XmlToModel("18C59", strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.LWType = "AJ";
                log.JYCS = para.jycs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18C59_Result == null || string.IsNullOrEmpty(m_Vehicle_18C59_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C59_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strCategory;
                logInfo.Log_Infor = "4. [18C59]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C59";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C59_Result.code = "0";
                m_Vehicle_18C59_Result.message = ex.Message;
            }
            return m_Vehicle_18C59_Result;
        }

        public Vehicle_18C55_Result Write_18C55(Vehicle_18C55_Para para)
        {
            Vehicle_18C55_Result m_Vehicle_18C55_Result = new Vehicle_18C55_Result();
            try
            {
                NETLOG_INFO log = new NETLOG_INFO();
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
#if BJXY
                if (para.jcxdh == "6")
                {//灯光复检，将检测线代号6改为2
                    para.jcxdh = "2";
                }
#endif
                string strWriteXmlDoc = modelToXml.ModelToXml("18C55", para);
                string strResult = "";

                //已发送
                if (log.GetSuccessful(para.jylsh, para.jycs.ToString(),para.jyxm,"18C55",true))
                {
                    strResult = "已发送成功，系统直接返回";
                    m_Vehicle_18C55_Result.code = "1";
                    m_Vehicle_18C55_Result.message = "已发送成功，系统直接返回";
                    //m_Vehicle_18C55_Result.jkid = "18C55";
                }
                else
                {
                    #region 填充联网公司接口

#if RZLD
                    var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                    var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                    client.Open();
                    client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                    strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                    if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                    {
                        client.Close();
                    }
                    #endregion

                    AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                    m_Vehicle_18C55_Result = (Vehicle_18C55_Result)xmlToModel.Result_XmlToModel("18C55", strResult);
                }


                #region 联网日志记录
                
                log.LWLSH = para.jylsh;
                log.LWType = "AJ";
                log.JYCS = para.jycs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                log.JYXM = para.jyxm;
                if (m_Vehicle_18C55_Result == null || string.IsNullOrEmpty(m_Vehicle_18C55_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C55_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strCategory;
                logInfo.Log_Infor = "4. [18C55]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C55";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C55_Result.code = "0";
                m_Vehicle_18C55_Result.message = ex.Message;
            }
            return m_Vehicle_18C55_Result;
        }

        public Vehicle_18C58_Result Write_18C58(Vehicle_18C58_Para para)
        {
            Vehicle_18C58_Result m_Vehicle_18C58_Result = new Vehicle_18C58_Result();
            try
            {
                NETLOG_INFO log = new NETLOG_INFO();
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
#if BJXY
                if (para.jcxdh == "6")
                {//灯光复检，将检测线代号6改为2
                    para.jcxdh = "2";
                }
#endif
                string strWriteXmlDoc = modelToXml.ModelToXml("18C58", para);

                string strResult = "";
                  //已发送
                if (log.GetSuccessful(para.jylsh, para.jycs.ToString(), para.jyxm, "18C58",true))
                {
                    strResult = "已发送成功，系统直接返回";
                    m_Vehicle_18C58_Result.code = "1";
                    m_Vehicle_18C58_Result.message = "已发送成功，系统直接返回";
                }
                else
                {
                    #region 填充联网公司接口
#if RZLD
                    var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                    var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                    client.Open();
                    client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                    strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                    if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                    {
                        client.Close();
                    }
                    #endregion

                    AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                    m_Vehicle_18C58_Result = (Vehicle_18C58_Result)xmlToModel.Result_XmlToModel("18C58", strResult);
                }

                #region 联网日志记录
                log.LWLSH = para.jylsh;
                log.LWType = "AJ";
                log.JYCS = para.jycs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                log.JYXM = para.jyxm;
                if (m_Vehicle_18C58_Result == null || string.IsNullOrEmpty(m_Vehicle_18C58_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C58_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strCategory;
                logInfo.Log_Infor = "4. [18C58]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C58";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C58_Result.code = "0";
                m_Vehicle_18C58_Result.message = ex.Message;
            }

            return m_Vehicle_18C58_Result;
        }

        public Vehicle_18C80_Result Write_18C80(Vehicle_18C80_Para para)
        {
            Vehicle_18C80_Result m_Vehicle_18C80_Result = new Vehicle_18C80_Result();
            try
            {
                NETLOG_INFO log = new NETLOG_INFO();
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strWriteXmlDoc = modelToXml.ModelToXml("18C80", para);

                string strResult = "";

                //已发送
                if (log.GetSuccessful(para.jylsh, para.jycs.ToString(), para.jyxm, "18C80"))
                {
                    strResult = "已发送成功，系统直接返回";
                    m_Vehicle_18C80_Result.code = "1";
                    m_Vehicle_18C80_Result.message = "已发送成功，系统直接返回";
                }
                else
                {
                    #region 填充联网公司接口
#if RZLD
                    var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                    var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                    client.Open();
                    client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                    strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                    if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                    {
                        client.Close();
                    }
                    #endregion

                    AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                    m_Vehicle_18C80_Result = (Vehicle_18C80_Result)xmlToModel.Result_XmlToModel("18C80", strResult);
                }

                #region 联网日志记录
                log.LWLSH = para.jylsh;
                log.LWType = "AJ";
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                log.JYXM = para.jyxm;
                if (m_Vehicle_18C80_Result == null || string.IsNullOrEmpty(m_Vehicle_18C80_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C80_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strCategory;
                logInfo.Log_Infor = "4. [18C80]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C80";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C80_Result.code = "0";
                m_Vehicle_18C80_Result.message = ex.Message;
            }

            return m_Vehicle_18C80_Result;
        }

        public Vehicle_18C81_Result Write_18C81(Vehicle_18C81_Para para)
        {
            Vehicle_18C81_Result m_Vehicle_18C81_Result = new Vehicle_18C81_Result();
            try
            {
                NETLOG_INFO log = new NETLOG_INFO();
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
#if BJXY
                if (para.jcxdh == "6")
                {//灯光复检，将检测线代号6改为2
                    para.jcxdh = "2";
                }
#endif
                string strWriteXmlDoc = modelToXml.ModelToXml("18C81", para);

                string strResult = "";
                //已发送
                if (log.GetSuccessful(para.jylsh, para.jycs.ToString(), para.jyxm, "18C81",true))
                {
                    strResult = "已发送成功，系统直接返回";
                    m_Vehicle_18C81_Result.code = "1";
                    m_Vehicle_18C81_Result.message = "已发送成功，系统直接返回";
                }
                else
                {
                    #region 填充联网公司接口
#if RZLD
                    var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                    client.Open();
                    client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                    strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                    if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                    {
                        client.Close();
                    }
                    #endregion

                    AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                    m_Vehicle_18C81_Result = (Vehicle_18C81_Result)xmlToModel.Result_XmlToModel("18C81", strResult);
                }

                #region 联网日志记录
                log.LWLSH = para.jylsh;
                log.LWType = "AJ";
                log.JYCS = para.jycs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = HttpUtility.UrlEncode(strResult);
                log.JKName = para.jkid;
                log.JYXM = para.jyxm;
                if (m_Vehicle_18C81_Result == null || string.IsNullOrEmpty(m_Vehicle_18C81_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C81_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strCategory;
                logInfo.Log_Infor = "4. [18C81]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C81";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C81_Result.code = "0";
                m_Vehicle_18C81_Result.message = ex.Message;
            }
            return m_Vehicle_18C81_Result;
        }

        public Vehicle_18J31_Result Write_18J31(Vehicle_18J31_Para para)
        {
            Vehicle_18J31_Result m_Vehicle_18J31_Result = new Vehicle_18J31_Result();
            try
            {
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strWriteXmlDoc = modelToXml.ModelToXml(para.jkid, para);

                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();

                m_Vehicle_18J31_Result = (Vehicle_18J31_Result)xmlToModel.Result_XmlToModel(para.jkid, strResult);

                if (m_Vehicle_18J31_Result == null)
                {
                    m_Vehicle_18J31_Result = new Vehicle_18J31_Result();
                    m_Vehicle_18J31_Result.code = "0";
                    m_Vehicle_18J31_Result.message = "联网公司返回空！";
                }

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.LWType = "AJ";
                //log.JYCS = para.jycs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                log.JYXM = para.jyxm;
                if (m_Vehicle_18J31_Result == null || string.IsNullOrEmpty(m_Vehicle_18J31_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18J31_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strCategory;
                logInfo.Log_Infor = "4. [18J31]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18J31";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18J31_Result.code = "0";
                m_Vehicle_18J31_Result.message = ex.Message;
            }

            return m_Vehicle_18J31_Result;
        }

        public Vehicle_18C62_Result Write_18C62(Vehicle_18C62_Para para)
        {
            Vehicle_18C62_Result m_Vehicle_18C62_Result = new Vehicle_18C62_Result();
            try
            {
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();

                foreach (var v in para.YQ)
                {
                    v.yqbzxz = HttpUtility.UrlEncode(v.yqbzxz);
                }
#if BJXY
                if (para.jcxdh == "6")
                {//灯光复检，将检测线代号6改为2
                    para.jcxdh = "2";
                }
#endif

                string strWriteXmlDoc = modelToXml.ModelToXml(para.jkid, para);

                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);

                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18C62_Result = (Vehicle_18C62_Result)xmlToModel.Result_XmlToModel(para.jkid, strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.LWType = "AJ";
                log.JYCS = para.jycs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18C62_Result == null || string.IsNullOrEmpty(m_Vehicle_18C62_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C62_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strCategory;
                logInfo.Log_Infor = "4. [18C62]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C62";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C62_Result.code = "0";
                m_Vehicle_18C62_Result.message = ex.Message;
            }

            return m_Vehicle_18C62_Result;
        }

        public Vehicle_18C65_Result Write_18C65(Vehicle_18C65_Para para)
        {
            Vehicle_18C65_Result m_Vehicle_18C65_Result = new Vehicle_18C65_Result();
            try
            {
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strWriteXmlDoc = modelToXml.ModelToXml(para.jkid, para);

                #region 填充联网公司接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18C65_Result = (Vehicle_18C65_Result)xmlToModel.Result_XmlToModel(para.jkid, strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.LWType = "AJ";
                log.JYCS = para.jycs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.JYXM = para.fjx;
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18C65_Result == null || string.IsNullOrEmpty(m_Vehicle_18C65_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C65_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strCategory;
                logInfo.Log_Infor = "4. [18C65]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C62";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C65_Result.code = "0";
                m_Vehicle_18C65_Result.message = ex.Message;
            }

            return m_Vehicle_18C65_Result;
        }

        public Vehicle_18C52_Result Write_18C52(Vehicle_18C52_Para para)
        {
            Vehicle_18C52_Result m_Vehicle_18C52_Result = new Vehicle_18C52_Result();
            try
            {
                //ModelToXML
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strWriteXmlDoc = modelToXml.ModelToXml(para.jkid, para);

                #region 填充联网公司的联网接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18C52_Result = (Vehicle_18C52_Result)xmlToModel.Result_XmlToModel(para.jkid, strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.JCLSH = para.jclsh;
                log.JYCS = para.jycs.ToString();
                log.JYXM = "";
                log.LWType = "AJ";
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18C52_Result == null || string.IsNullOrEmpty(m_Vehicle_18C52_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C52_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "4. [18C52]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C52";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C52_Result.code = "0";
                m_Vehicle_18C52_Result.message = ex.Message;
            }

            return m_Vehicle_18C52_Result;
        }

        public Vehicle_18C72_Result Write_18C72(Vehicle_18C72_Para para)
        {
            Vehicle_18C72_Result m_Vehicle_18C72_Result = new Vehicle_18C72_Result();
            try
            {
                //ModelToXML
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strWriteXmlDoc = modelToXml.ModelToXml(para.jkid, para);

                #region 填充联网公司的联网接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18C72_Result = (Vehicle_18C72_Result)xmlToModel.Result_XmlToModel(para.jkid, strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.JYXM = "";
                log.LWType = "AJ";
                log.JYCS = "";
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18C72_Result == null || string.IsNullOrEmpty(m_Vehicle_18C72_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C72_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "4. [18C72]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C72";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C72_Result.code = "0";
                m_Vehicle_18C72_Result.message = ex.Message;
            }

            return m_Vehicle_18C72_Result;
        }

        public Vehicle_18C54_Result Write_18C54(Vehicle_18C54_Para para)
        {
            Vehicle_18C54_Result m_Vehicle_18C54_Result = new Vehicle_18C54_Result();
            try
            {
                //ModelToXML
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strWriteXmlDoc = modelToXml.ModelToXml(para.jkid, para);

                #region 填充联网公司的联网接口
                string strResult = "";
#if RZLD
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18C54_Result = (Vehicle_18C54_Result)xmlToModel.Result_XmlToModel(para.jkid, strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.JYXM = "";
                log.LWType = "AJ";
                log.JYCS = para.jycs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18C54_Result == null || string.IsNullOrEmpty(m_Vehicle_18C54_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C54_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "4. [18C54]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C54";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C54_Result.code = "0";
                m_Vehicle_18C54_Result.message = ex.Message;
            }

            return m_Vehicle_18C54_Result;
        }

        public Vehicle_18X04_Result Write_18X04(Vehicle_18X04_Para para)
        {
            Vehicle_18X04_Result m_Vehicle_18X04_Result = new Vehicle_18X04_Result();
            try
            {
                //ModelToXML
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                NETLOG_INFO log = new NETLOG_INFO();
                string strWriteXmlDoc = modelToXml.ModelToXml(para.jkid, para);
                
                string strResult = "";

                //已发送
                if (log.GetSuccessful(para.jylsh, para.jycs.ToString(), para.jyxm, "18X04"))
                {
                    strResult = "已发送成功，系统直接返回";
                    m_Vehicle_18X04_Result.code = "1";
                    m_Vehicle_18X04_Result.message = "已发送成功，系统直接返回";
                }
                else
                {
                    #region 填充联网公司接口
#if RZLD
                    var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY
                    var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                    client.Open();
                    client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                    strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                    if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                    {
                        client.Close();
                    }
                    #endregion

                    AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                    m_Vehicle_18X04_Result = (Vehicle_18X04_Result)xmlToModel.Result_XmlToModel(para.jkid, strResult);
                }

                #region 联网日志记录
                log.LWLSH = para.jylsh;
                log.JYXM = para.jyxm;
                log.LWType = "AJ";
                log.JYCS = para.jycs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18X04_Result == null || string.IsNullOrEmpty(m_Vehicle_18X04_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18X04_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "4. [18X04]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18X04";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18X04_Result.code = "0";
                m_Vehicle_18X04_Result.message = ex.Message;
            }

            return m_Vehicle_18X04_Result;
        }

        public Vehicle_18C63_Result Write_18C63(Vehicle_18C63_Para para)
        {
            Vehicle_18C63_Result m_Vehicle_18C63_Result = new Vehicle_18C63_Result();
            try
            {
                //ModelToXML
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strWriteXmlDoc = modelToXml.ModelToXml(para.jkid, para);

                #region 填充联网公司的联网接口
                string strResult = "";
#if RZLD //日照兰大
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY  //北京学院
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18C63_Result = (Vehicle_18C63_Result)xmlToModel.Result_XmlToModel(para.jkid, strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.JYXM = para.jyxm;
                log.LWType = "AJ";
                log.JYCS = para.jycs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18C63_Result == null || string.IsNullOrEmpty(m_Vehicle_18C63_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18C63_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "4. [18C63]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18C63";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18C63_Result.code = "0";
                m_Vehicle_18C63_Result.message = ex.Message;
            }

            return m_Vehicle_18C63_Result;
        }

        public Vehicle_18X05_Result Write_18X05(Vehicle_18X05_Para para)
        {
            Vehicle_18X05_Result m_Vehicle_18X05_Result = new Vehicle_18X05_Result();
            try
            {
                //ModelToXML
                AJ_ModelToXML modelToXml = new AJ_ModelToXML();
                string strWriteXmlDoc = modelToXml.ModelToXml(para.jkid, para);

                #region 填充联网公司的联网接口
                string strResult = "";
#if RZLD //日照兰大
                var client = new VehicleForNetWebService.DataService.DataServicePortTypeClient();
#elif BJXY  //北京学院
                var client = new VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoapClient();
#endif
                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, strWriteXmlDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }
                #endregion

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                m_Vehicle_18X05_Result = (Vehicle_18X05_Result)xmlToModel.Result_XmlToModel(para.jkid, strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.jylsh;
                log.JYXM = para.jyxm;
                log.LWType = "AJ";
                log.JYCS = para.jycs.ToString();
                log.JCLSH = log.GetJCLSH(log.LWLSH, log.JYCS);
                log.SendInfo = strWriteXmlDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (m_Vehicle_18X05_Result == null || string.IsNullOrEmpty(m_Vehicle_18X05_Result.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = m_Vehicle_18X05_Result.code;
                }
                log.LogTime = DateTime.Now;

                bool b = LogHelper.Log.WriteJKLog(log);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NetFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "4. [18X05]  发送给联网公司失败，失败原因为：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "上传下载";
                logInfo.FunName = "AJ_Write_WebServices.cs -> Write_18X05";

                Log.WriteLog(logInfo);
                #endregion

                m_Vehicle_18X05_Result.code = "0";
                m_Vehicle_18X05_Result.message = ex.Message;
            }

            return m_Vehicle_18X05_Result;
        }

        /// <summary>
        /// 寫入外廓尺寸待檢隊列
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18W05_Result Write_18W05(Vehicle_18W05_Para para)
        {
            Vehicle_18W05_Result _RESULT_18W05 = new Vehicle_18W05_Result();
            try
            {
                AJ_ModelToXML model2XML = new AJ_ModelToXML();
                string _QueryXMLDoc = model2XML.ModelToXml("18W05", para);

                string strResult = "";

                var client = new VehicleForNetWebService.ctwkService.JcxlwServerSoapClient();

                client.Open();
                client.InnerChannel.OperationTimeout = new TimeSpan(0, 0, TimeOut);
                strResult = client.writeObjectOut(para.xtlb, para.jkxlh, para.jkid, _QueryXMLDoc);
                if (client.State != System.ServiceModel.CommunicationState.Closed || client.State != System.ServiceModel.CommunicationState.Closing)
                {
                    client.Close();
                }

                AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
                _RESULT_18W05 = (Vehicle_18W05_Result)xmlToModel.Result_XmlToModel("18W05", strResult);

                #region 联网日志记录
                NETLOG_INFO log = new NETLOG_INFO();
                log.LWLSH = para.lsh;
                log.JYXM = "DC";
                log.LWType = "AJ";
                log.SendInfo = _QueryXMLDoc;
                log.RevcInfo = strResult;
                log.JKName = para.jkid;
                if (_RESULT_18W05 == null || string.IsNullOrEmpty(_RESULT_18W05.code))
                {
                    log.IsSuc = "0";
                }
                else
                {
                    log.IsSuc = _RESULT_18W05.code;
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
                logInfo.FunName = "AJ_Read_WebServices.cs -> Read_18W05";

                Log.WriteLog(logInfo);
            }

            return _RESULT_18W05;
        }
    }
}
