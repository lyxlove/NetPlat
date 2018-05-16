using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Web;
using LogHelper;
using System.ComponentModel;
using Microsoft.VisualBasic;
using gfVehicleLibraryAJ;

namespace ConvertInfo
{
    public class ModelReflection
    {
        public struct NameAndValue
        {
            public string Name;
            public string Value;
        }

        public PropertyInfo[] GetPropertyInfos(Type type)
        {
            return type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }

        /// <summary>
        /// 得到子类中所有属性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public void GetClassName<T>(T t, ref List<PropertyInfo> lstParent, ref List<PropertyInfo> lstChildren, bool bFindGrandpa = false)
        {
            PropertyInfo[] pIs = GetPropertyInfos(t.GetType());
            PropertyInfo[] pps;
            if (!bFindGrandpa)
            {
                pps = GetPropertyInfos(t.GetType().BaseType);
            }
            else
            {
                pps = GetPropertyInfos(t.GetType().BaseType.BaseType);
            }

            List<PropertyInfo> lstPIs = pIs.ToList();
            List<PropertyInfo> lstPps = pps.ToList();

            foreach (var v in pIs)
            {
                bool b = false;
                foreach (var j in pps)
                {
                    if (v.Name == j.Name)
                    {
                        b = true;
                        break;
                    }
                }

                if (b)
                {
                    lstParent.Add(v);
                }

                if (!b)
                {
                    lstChildren.Add(v);
                }
            }
        }

        #region AJ Para
        /// <summary>
        /// 设置model值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="strContent"></param>
        /// <returns></returns>
        public T ParaSetModelValue<T>(T t, string strType, string strContent)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strContent);

                PropertyInfo[] pps = GetPropertyInfos(t.GetType());
                Type target = t.GetType();

                XmlNode xn = doc.SelectSingleNode("//" + strType);

                XmlNodeList nodes = xn.ChildNodes;
                if (nodes.Count > 0)
                {
                    List<string> lstError = new List<string>();
                    foreach (XmlNode v in nodes)
                    {
                        try
                        {
                            PropertyInfo targetPP = target.GetProperty(v.Name);
                            object objValue = v.InnerText;
                            if (objValue != null && string.IsNullOrEmpty(objValue.ToString()) == false)
                            {
                                targetPP.SetValue(t, SD_ChanageType(objValue, targetPP.PropertyType), null);
                            }
                        }
                        catch (Exception ee)
                        {
                            lstError.Add(" 项目：[" + v.Name + "], 值：[" + v.InnerText + "]转换失败.");
                            continue;
                        }
                    }

                    #region 日志记录
                    string strCategory = Log.LogType.NetUpDown.ToString();
                    LOG_INFO logInfo = new LOG_INFO();
                    logInfo.Category = strCategory;
                    logInfo.HostName = System.Net.Dns.GetHostName();
                    logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                    logInfo.LogTime = DateTime.Now;
                    logInfo.FS_Infor = strContent;
                    logInfo.JS_Infor = "";
                    logInfo.Log_Infor = "2." + t.GetType().Name.ToString() + "xml转换成Model成功.";
                    string strErrorPart = "";
                    foreach (var v in lstError)
                    {
                        strErrorPart += v + ",";
                    }
                    if (string.IsNullOrEmpty(strErrorPart) == false)
                    {
                        logInfo.Log_Infor = logInfo.Log_Infor + "部分转换失败，失败参数为：" + strErrorPart;
                    }
                    
                    logInfo.Name = "上传下载";
                    logInfo.FunName = "ModelReflection.cs -> ParaSetModelValue";

                    Log.WriteLog(logInfo);
                    #endregion
                }
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NPFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strContent;
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "2." + t.GetType().Name.ToString() + "xml转换成Model失败,失败原因为：" + HttpUtility.UrlEncode(ex.Message);

                logInfo.Name = "联网失败";
                logInfo.FunName = "ModelReflection.cs -> ParaSetModelValue";

                Log.WriteLog(logInfo);
                #endregion
            }
            return t;
        }

        /// <summary>
        /// 设置model值,仅适用与18C62
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="strContent"></param>
        /// <returns></returns>
        public Vehicle_18C62_Para ParaSetModelValue_18C62(Vehicle_18C62_Para m_Para, string strType, string strContent)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strContent);

                PropertyInfo[] pps = GetPropertyInfos(m_Para.GetType());
                Type target = m_Para.GetType();

                XmlNode xn = doc.SelectSingleNode("//" + strType);

                XmlNodeList nodes = xn.ChildNodes;
                if (nodes.Count > 0)
                {
                    List<string> lstError = new List<string>();
                    foreach (XmlNode v in nodes)
                    {
                        try
                        {
                            if (v.Name == "rgjyjgs" || v.Name == "yqsbjyjgs")
                            {
                                ParaSetModelValue_18C62_Sub(ref m_Para, xn, v.Name);
                            }

                            PropertyInfo targetPP = target.GetProperty(v.Name);
                            object objValue = v.InnerText;
                            if (objValue != null && string.IsNullOrEmpty(objValue.ToString()) == false)
                            {
                                targetPP.SetValue(m_Para, SD_ChanageType(objValue, targetPP.PropertyType), null);
                            }
                        }
                        catch (Exception ee)
                        {
                            lstError.Add(" 项目：[" + v.Name + "], 值：[" + v.InnerText + "]转换失败.");
                            continue;
                        }
                    }

                    #region 日志记录
                    string strCategory = Log.LogType.NetUpDown.ToString();
                    LOG_INFO logInfo = new LOG_INFO();
                    logInfo.Category = strCategory;
                    logInfo.HostName = System.Net.Dns.GetHostName();
                    logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                    logInfo.LogTime = DateTime.Now;
                    logInfo.FS_Infor = strContent;
                    logInfo.JS_Infor = "";
                    logInfo.Log_Infor = m_Para.GetType().Name.ToString();
                    foreach (var v in lstError)
                    {
                        logInfo.Log_Infor = logInfo.Log_Infor + v;
                    }

                    logInfo.Name = "上传下载";
                    logInfo.FunName = "ModelReflection.cs -> ParaSetModelValue";

                    Log.WriteLog(logInfo);
                    #endregion
                }
            }
            catch (Exception ex)
            {
            }
            return m_Para;
        }

        /// <summary>
        /// 得到18C62子项值
        /// </summary>
        /// <param name="m_Para"></param>
        /// <param name="node"></param>
        /// <param name="nodeName"></param>
        private void ParaSetModelValue_18C62_Sub(ref Vehicle_18C62_Para m_Para, XmlNode node, string nodeName)
        {
            dynamic m_None = new Vehicle_18C62_RG_Para();
            Vehicle_18C62_YQ_Para m_YQ = new Vehicle_18C62_YQ_Para();
            if (nodeName.ToLower() == "rgjyjgs")
            {
                m_Para.RG = new List<Vehicle_18C62_RG_Para>();
            }

            if (nodeName.ToLower() == "yqsbjyjgs")
            {
                m_Para.YQ = new List<Vehicle_18C62_YQ_Para>();
            }

            XmlNode xn = node.SelectSingleNode(nodeName);
            if (xn.HasChildNodes)
            {
                XmlNodeList nodes = xn.ChildNodes;
                if (nodes != null && nodes.Count > 0)
                {
                    foreach (XmlNode vList in nodes)
                    {
                        if (vList.HasChildNodes)
                        {
                            var vSubChildRen = vList.ChildNodes;
                            if (nodeName.ToLower() == "yqsbjyjgs")
                            {
                                m_None = new Vehicle_18C62_YQ_Para();
                            }

                            if (nodeName.ToLower() == "rgjyjgs")
                            {
                                m_None = new Vehicle_18C62_RG_Para();
                            }
                            
                            foreach (XmlNode v in vSubChildRen)
                            {
                                Type target = m_None.GetType();
                                if (v.HasChildNodes)
                                {
                                    PropertyInfo targetPP = target.GetProperty(v.Name);
                                    object objValue = v.InnerText;
                                    if (objValue != null && string.IsNullOrEmpty(objValue.ToString()) == false)
                                    {
                                        targetPP.SetValue(m_None, SD_ChanageType(objValue, targetPP.PropertyType), null);
                                    }
                                }
                            }

                            if (m_None is Vehicle_18C62_RG_Para)
                            {
                                m_Para.RG.Add(m_None);
                            }

                            if (m_None is Vehicle_18C62_YQ_Para)
                            {
                                m_Para.YQ.Add(m_None);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 参数实体转换成XML
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="strType"></param>
        /// <returns></returns>
        public string ParaModelToXML<T>(T t, string strType)
        {
            string strRet = "";
            try
            {
                strRet = "<?xml version=\"1.0\" encoding=\"GBK\"?>";
                strRet += "<root>";
                strRet += "<" + strType + ">";

                List<PropertyInfo> lstParent = new List<PropertyInfo>();
                List<PropertyInfo> lstChildren = new List<PropertyInfo>();
                GetClassName(t, ref lstParent, ref lstChildren);

                foreach (var v in lstChildren)
                {
                    object objValue = v.GetValue(t, null);
                    if (objValue == null || string.IsNullOrEmpty(objValue.ToString()))
                    {
                        strRet += "<" + v.Name + "></" + v.Name + ">";
                    }
                    else
                    {
                        //处理传入参数是否是DateTime类型，如果是，转换成yyyy-MM-dd格式
                        DateTime dateTemp;
                        string strValue;
                        if (IsDateTime(objValue.ToString()))
                        {
                            dateTemp = Convert.ToDateTime(objValue.ToString());
                            strValue = dateTemp.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else
                        {
                            strValue = objValue.ToString();
                        }

#if RZLD
                        //日照兰大这边，18C58多个开始时间，发送给联网公司时，去掉kssj
                        if (typeof(T).Name == "Vehicle_18C58_Para" && v.Name == "kssj")
                        {
                            continue;
                        }
#endif
                        if (typeof(T).Name == "Vehicle_18C52_Para" && v.Name == "jclsh")
                        {
                            continue;
                        }

                        if (typeof(T).Name == "Vehicle_18C66_Para" && v.Name == "jclsh")
                        {
                            continue;
                        }

                        strRet += "<" + v.Name + ">" + strValue + "</" + v.Name + ">";
                    }
                }

                strRet += "</" + strType + ">";
                strRet += "</root>";

                #region 日志记录
                string strCategory = Log.LogType.NetUpDown.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strRet;
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "3. 18C82 将Model转换成XML成功";
                logInfo.Name = "上传下载";
                logInfo.FunName = "ModelReflection.cs -> ParaModelToXML()";

                Log.WriteLog(logInfo);
                #endregion
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NPFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = System.Net.Dns.GetHostName();
                logInfo.IPAddress = Log.GetIPAddress(logInfo.HostName);
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = strRet;
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = "3. 18C82 将Model转换成XML失败，失败原因：" + HttpUtility.UrlEncode(ex.Message);
                logInfo.Name = "转换失败";
                logInfo.FunName = "ModelReflection.cs -> ParaModelToXML()";

                Log.WriteLog(logInfo);
                #endregion
            }
            return strRet;
        }

        /// <summary>
        /// 仅适用与18C81,两重基类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="strType"></param>
        /// <returns></returns>
        public string ParaModelToXML_Ex<T>(T t, string strType)
        {
            string strRet = "";
            try
            {
                strRet = "<?xml version=\"1.0\" encoding=\"GBK\"?>";
                strRet += "<root>";
                strRet += "<" + strType + ">";

                List<PropertyInfo> lstParent = new List<PropertyInfo>();
                List<PropertyInfo> lstChildren = new List<PropertyInfo>();
                GetClassName(t, ref lstParent, ref lstChildren, true);

                foreach (var v in lstChildren)
                {
                    object objValue = v.GetValue(t, null);
                    if (objValue == null || string.IsNullOrEmpty(objValue.ToString()))
                    {
                        strRet += "<" + v.Name + "></" + v.Name + ">";
                    }
                    else
                    {
                        //处理传入参数是否是DateTime类型，如果是，转换成yyyy-MM-dd格式
                        DateTime dateTemp;
                        string strValue;
                        if (IsDateTime(objValue.ToString()))
                        {
                            dateTemp = Convert.ToDateTime(objValue.ToString());
                            strValue = dateTemp.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else
                        {
                            strValue = objValue.ToString();
                        }

                        strRet += "<" + v.Name + ">" + strValue + "</" + v.Name + ">";
                    }
                }

                strRet += "</" + strType + ">";
                strRet += "</root>";
            }
            catch (Exception ex)
            {

            }
            return strRet;
        }

        /// <summary>
        /// 仅适用与18C62,两重基类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="strType"></param>
        /// <returns></returns>
        public string ParaModelToXML_18C62(Vehicle_18C62_Para m_18C62, string strType)
        {
            string strRet = "";
            try
            {
                strRet = "<?xml version=\"1.0\" encoding=\"GBK\"?>";
                strRet += "<root>";
                strRet += "<" + strType + ">";

                List<PropertyInfo> lstParent = new List<PropertyInfo>();
                List<PropertyInfo> lstChildren = new List<PropertyInfo>();
                GetClassName(m_18C62, ref lstParent, ref lstChildren);

                foreach (var v in lstChildren)
                {
                    if (v.Name == "RG" || v.Name == "YQ")
                    {
                        continue;
                    }
                     
                    object objValue = v.GetValue(m_18C62, null);
                    if (objValue == null || string.IsNullOrEmpty(objValue.ToString()))
                    {
                        strRet += "<" + v.Name + "></" + v.Name + ">";
                    }
                    else
                    {
                        //处理传入参数是否是DateTime类型，如果是，转换成yyyy-MM-dd格式
                        DateTime dateTemp;
                        string strValue;
                        if (IsDateTime(objValue.ToString()))
                        {
                            dateTemp = Convert.ToDateTime(objValue.ToString());
                            strValue = dateTemp.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else
                        {
                            strValue = objValue.ToString();
                        }
                        strRet += "<" + v.Name + ">" + strValue + "</" + v.Name + ">";
                    }
                }

                #region 人工
                List<PropertyInfo> lstParent_RG = new List<PropertyInfo>();
                List<PropertyInfo> lstChildren_RG = new List<PropertyInfo>();
                strRet += "<rgjyjgs>";
                for (int i = 0; i < m_18C62.RG.Count; i++)
                {
                    if (i == 0)
                    {
                        GetClassName(m_18C62.RG[0], ref lstParent_RG, ref lstChildren_RG);
                    }
                    strRet += "<rgjyjg>";

                    foreach (var v in lstChildren_RG)
                    {
                        object objValue = v.GetValue(m_18C62.RG[i], null);
                        if (objValue == null || string.IsNullOrEmpty(objValue.ToString()))
                        {
                            strRet += "<" + v.Name + "></" + v.Name + ">";
                        }
                        else
                        {
                            //处理传入参数是否是DateTime类型，如果是，转换成yyyy-MM-dd格式
                            DateTime dateTemp;
                            string strValue;
                            if (IsDateTime(objValue.ToString()))
                            {
                                dateTemp = Convert.ToDateTime(objValue.ToString());
                                strValue = dateTemp.ToString("yyyy-MM-dd HH:mm:ss");
                            }
                            else
                            {
                                strValue = objValue.ToString();
                            }
                            strRet += "<" + v.Name + ">" + strValue + "</" + v.Name + ">";
                        }
                    }

                    strRet += "</rgjyjg>";
                }
                strRet += "</rgjyjgs>";
                #endregion

                #region 仪器
                List<PropertyInfo> lstParent_YQ = new List<PropertyInfo>();
                List<PropertyInfo> lstChildren_YQ = new List<PropertyInfo>();
                strRet += "<yqsbjyjgs>";
                for (int i = 0; i < m_18C62.YQ.Count; i++)
                {
                    if (i == 0)
                    {
                        GetClassName(m_18C62.YQ[0], ref lstParent_YQ, ref lstChildren_YQ);
                    }
                    strRet += "<yqsbjyjg>";

                    foreach (var v in lstChildren_YQ)
                    {
                        object objValue = v.GetValue(m_18C62.YQ[i], null);
                        if (objValue == null || string.IsNullOrEmpty(objValue.ToString()))
                        {
                            strRet += "<" + v.Name + "></" + v.Name + ">";
                        }
                        else
                        {
                            //处理传入参数是否是DateTime类型，如果是，转换成yyyy-MM-dd格式
                            DateTime dateTemp;
                            string strValue;
                            if (IsDateTime(objValue.ToString()))
                            {
                                dateTemp = Convert.ToDateTime(objValue.ToString());
                                strValue = dateTemp.ToString("yyyy-MM-dd HH:mm:ss");
                            }
                            else
                            {
                                strValue = objValue.ToString();
                            }
                            strRet += "<" + v.Name + ">" + strValue + "</" + v.Name + ">";
                        }
                    }

                    strRet += "</yqsbjyjg>";
                }
                strRet += "</yqsbjyjgs>";
                #endregion

                strRet += "</" + strType + ">";
                strRet += "</root>";
            }
            catch (Exception ex)
            {

            }
            return strRet;
        }
        #endregion

        /// <summary>
        /// 是否是带时间的日期格式
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        private bool IsDateTime(string strValue)
        {
            bool bDate = false;
            if (Information.IsDate(strValue) && (strValue.ToString().Contains("-") || strValue.ToString().Contains("/")) && strValue.ToString().Length > 11)
                bDate = true;
            return bDate;
        }

        #region AJ Result
        public T ResultSetModelValue<T>(T t, string strType, string strContent)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strContent);

                PropertyInfo[] pps = GetPropertyInfos(t.GetType());
                Type target = t.GetType();

                var property = t.GetType().GetProperty("PropertyName");


                XmlNode xn = doc.SelectSingleNode("//head");

                bool bResult = false;
                XmlNodeList nodes = xn.ChildNodes;
                if (nodes.Count > 0)
                {
                    //XmlNodeList subs = nodes[0].ChildNodes;
                    foreach (XmlNode v in nodes)
                    {
                        foreach (var vSX in pps)
                        {
                            if (vSX.Name == v.Name)
                            {
                                PropertyInfo targetPP = target.GetProperty(vSX.Name);
                                object objValue = HttpUtility.UrlDecode(v.InnerText);

                                targetPP.SetValue(t, SD_ChanageType(objValue, targetPP.PropertyType), null);

                                if (v.Name == "code" && v.InnerText == "1")
                                {
                                    bResult = true;
                                }
                            }
                        }
                    }
                }

                if (bResult)
                {
                    XmlNode xn_Result = doc.SelectSingleNode("//vehispara");

                    if (xn_Result != null)
                    {
                        XmlNodeList nodes_Result = xn_Result.ChildNodes;
                        if (nodes_Result.Count > 0)
                        {
                            List<string> lstError = new List<string>();
                            foreach (XmlNode v in nodes_Result)
                            {
                                try
                                {
                                    PropertyInfo targetPP = target.GetProperty(v.Name);
                                    object objValue = HttpUtility.UrlDecode(v.InnerText);

                                    if (objValue != null && string.IsNullOrEmpty(objValue.ToString()) == false)
                                    {
                                        targetPP.SetValue(t, SD_ChanageType(objValue, targetPP.PropertyType), null);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    lstError.Add("项目：[" + v.Name + "], 值：[" + v.InnerText + "]转换失败.");
                                    continue;
                                }
                            }

                            #region 日志记录
                            string strCategory = Log.LogType.NetUpDown.ToString();
                            LOG_INFO logInfo = new LOG_INFO();
                            logInfo.Category = strCategory;
                            logInfo.HostName = "";
                            logInfo.IPAddress = "";
                            logInfo.LogTime = DateTime.Now;
                            logInfo.FS_Infor = "";
                            logInfo.JS_Infor = "";
                            logInfo.Log_Infor = strType;
                            foreach (var v in lstError)
                            {
                                logInfo.Log_Infor = logInfo.Log_Infor + v;
                            }

                            logInfo.Name = "上传下载";
                            logInfo.FunName = "ModelReflection.cs -> ResultSetModelValue";

                            Log.WriteLog(logInfo);
                            #endregion
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NPFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = "";
                logInfo.IPAddress = "";
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = ex.Message;
                logInfo.Name = "上传下载";
                logInfo.FunName = "ModelReflection.cs -> ResultSetModelValue";

                Log.WriteLog(logInfo);
                #endregion
            }
            return t;
        }

        public T ResultSetModelValueEx<T>(T t, string strType, string strContent)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strContent);

                PropertyInfo[] pps = GetPropertyInfos(t.GetType());
                Type target = t.GetType();

                var property = t.GetType().GetProperty("PropertyName");


                XmlNode xn = doc.SelectSingleNode("//" + strType);

                bool bResult = false;
                XmlNodeList nodes = xn.ChildNodes;
                if (nodes.Count > 0)
                {
                    //XmlNodeList subs = nodes[0].ChildNodes;
                    foreach (XmlNode v in nodes)
                    {
                        foreach (var vSX in pps)
                        {
                            if (vSX.Name == v.Name)
                            {
                                PropertyInfo targetPP = target.GetProperty(vSX.Name);
                                object objValue = HttpUtility.UrlDecode(v.InnerText);

                                targetPP.SetValue(t, SD_ChanageType(objValue, targetPP.PropertyType), null);

                                if (v.Name == "code" && v.InnerText == "1")
                                {
                                    bResult = true;
                                    break;
                                }
                            }
                        }
                    }
                }

                if (bResult)
                {
                    XmlNode xn_Result = doc.SelectSingleNode("//vehispara");

                    if (xn_Result != null)
                    {
                        XmlNodeList nodes_Result = xn_Result.ChildNodes;
                        if (nodes_Result.Count > 0)
                        {
                            List<string> lstError = new List<string>();
                            foreach (XmlNode v in nodes_Result)
                            {
                                try
                                {
                                    foreach (var vSX in pps)
                                    {
                                        if (vSX.Name == v.Name)
                                        {
                                            PropertyInfo targetPP = target.GetProperty(v.Name);
                                            object objValue = HttpUtility.UrlDecode(v.InnerText);

                                            if (objValue != null && string.IsNullOrEmpty(objValue.ToString()) == false)
                                            {
                                                targetPP.SetValue(t, SD_ChanageType(objValue, targetPP.PropertyType), null);
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    lstError.Add("项目：[" + v.Name + "], 值：[" + v.InnerText + "]转换失败.");
                                    continue;
                                }
                            }

                            #region 日志记录
                            string strCategory = Log.LogType.NetUpDown.ToString();
                            LOG_INFO logInfo = new LOG_INFO();
                            logInfo.Category = strCategory;
                            logInfo.HostName = "";
                            logInfo.IPAddress = "";
                            logInfo.LogTime = DateTime.Now;
                            logInfo.FS_Infor = "";
                            logInfo.JS_Infor = "";
                            logInfo.Log_Infor = strType;
                            foreach (var v in lstError)
                            {
                                logInfo.Log_Infor = logInfo.Log_Infor + v;
                            }

                            logInfo.Name = "上传下载";
                            logInfo.FunName = "ModelReflection.cs -> ResultSetModelValue";

                            Log.WriteLog(logInfo);
                            #endregion
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                #region 日志记录
                string strCategory = Log.LogType.NPFail.ToString();
                LOG_INFO logInfo = new LOG_INFO();
                logInfo.Category = strCategory;
                logInfo.HostName = "";
                logInfo.IPAddress = "";
                logInfo.LogTime = DateTime.Now;
                logInfo.FS_Infor = "";
                logInfo.JS_Infor = "";
                logInfo.Log_Infor = ex.Message;
                logInfo.Name = "上传下载";
                logInfo.FunName = "ModelReflection.cs -> ResultSetModelValue";

                Log.WriteLog(logInfo);
                #endregion
            }
            return t;
        }

        public string ResultModelToXML<T>(T t, string strType, bool bChildren = true)
        {
            string strRet = "";
            try
            {
                List<PropertyInfo> lstParent = new List<PropertyInfo>();
                List<PropertyInfo> lstChildren = new List<PropertyInfo>();
                GetClassName(t,ref lstParent,ref lstChildren);

                strRet = "<?xml version=\"1.0\" encoding=\"GBK\"?>";
                strRet += "<root>";
                strRet += "<head>";
                for(int i=0;i<3;i++)
                {
                    strRet += "<" + lstParent[i].Name + ">" + lstParent[i].GetValue(t, null).ToString() + "</" + lstParent[i].Name + ">";
                }
                strRet += "</head>";
                strRet += "<body>";
                if (bChildren)
                {
                    strRet += "<" + strType + ">";
                    foreach (var v in lstChildren)
                    {
                        if (v.GetValue(t, null) == null)
                        {
                            strRet += "<" + v.Name + "></" + v.Name + ">";
                        }
                        else
                        {
                            object objValue = v.GetValue(t, null);
                            //处理传入参数是否是DateTime类型，如果是，转换成yyyy-MM-dd格式
                            DateTime dateTemp;
                            string strValue;
                            bool bIsDateTime = DateTime.TryParse(objValue.ToString(), out dateTemp);
                            if (IsDateTime(objValue.ToString()))
                            {
                                strValue = dateTemp.ToString("yyyy-MM-dd HH:mm:ss");
                            }
                            else
                            {
                                strValue = objValue.ToString();
                            }
                            strRet += "<" + v.Name + ">" + strValue + "</" + v.Name + ">";
                        }
                    }

                    strRet += "</" + strType + ">";
                }
                strRet += "</body>";
                strRet += "</root>";
            }
            catch (Exception ex)
            {
            }
            return strRet;
        }
        #endregion

        #region 实体属性反射
        /// <summary>
        /// 实体属性反射
        /// </summary>
        /// <typeparam name="S">赋值对象</typeparam>
        /// <typeparam name="T">被赋值对象</typeparam>
        /// <param name="s"></param>
        /// <param name="t"></param>
        public void AutoMapping<S, T>(S s, T t)
        {
            PropertyInfo[] pps = GetPropertyInfos(s.GetType());

            Type target = t.GetType();

            foreach (var pp in pps)
            {
                PropertyInfo targetPP = target.GetProperty(pp.Name);
                object value = pp.GetValue(s, null);

                if (targetPP != null && value != null && !string.IsNullOrEmpty(value.ToString()))
                {
                    targetPP.SetValue(t, SD_ChanageType(value,targetPP.PropertyType), null);
                }
            }
        }
        #endregion

        #region PF Request

        public T ReqXMLToModel<T>(T t, string strSigleNode, string strReqContent)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(strReqContent);
            Type target = t.GetType();

            #region SetParentValue
            List<NameAndValue> lstAttr = new List<NameAndValue>();
            XmlNode node = doc.SelectSingleNode("//Message");
            for (int i = 0; i < node.Attributes.Count; i++)
            {
                string strName = node.Attributes[i].Name;
                NameAndValue nv = new NameAndValue();
                nv.Name = strName;
                nv.Value = node.Attributes[strName].Value;
                lstAttr.Add(nv);
            }

            XmlNodeList nodeList = node.ChildNodes;

            for (int i = 0; i < nodeList.Count; i++)
            {
                for (int j = 0; j < nodeList[i].Attributes.Count; j++)
                {
                    string strName = nodeList[i].Attributes[j].Name;
                    NameAndValue nv = new NameAndValue();
                    nv.Name = strName;
                    nv.Value = nodeList[i].Attributes[strName].Value;
                    lstAttr.Add(nv);
                }
            }

            foreach (var v in lstAttr)
            {
                PropertyInfo targetPP = target.GetProperty(v.Name);
                object objValue = v.Value;
                if (objValue != null && string.IsNullOrEmpty(objValue.ToString()) == false)
                {
                    targetPP.SetValue(t, SD_ChanageType(objValue, targetPP.PropertyType), null);
                }
            }
            #endregion

            XmlNode subNode = doc.SelectSingleNode("//"+strSigleNode);
            XmlNodeList nodes_Result = subNode.ChildNodes;
            if (nodes_Result.Count > 0)
            {
                //XmlNodeList subs = nodes[0].ChildNodes;
                foreach (XmlNode v in nodes_Result)
                {
                    PropertyInfo targetPP = target.GetProperty(v.Name);
                    object objValue = v.InnerText;
                    if (objValue != null && string.IsNullOrEmpty(objValue.ToString()) == false)
                    {
                        targetPP.SetValue(t, SD_ChanageType(objValue, targetPP.PropertyType), null);
                    }
                }
            }

            return t;
        }

        public string ReqModelToXML<T>(T t, string strType)
        {
            string strRet = "";
            try
            {
                List<PropertyInfo> lstParent = new List<PropertyInfo>();
                List<PropertyInfo> lstChildren = new List<PropertyInfo>();

                GetClassName(t,ref lstParent,ref lstChildren);

                strRet += "<Message Devecie=\"" + lstParent[0].Name + "\">";
                strRet += "<Request Name=\"" + lstParent[1].Name + "\">";
                strRet += "<Row>";
                foreach (var v in lstChildren)
                {
                    strRet += "<" + v.Name + ">" + v.GetValue(t, null).ToString() + "</" + v.Name + ">";
                }
                strRet += "</Row>";
                strRet += "</Request>";
                strRet += "</Message>";
            }
            catch (Exception ex)
            {

            }

            strRet = HttpUtility.UrlEncode(strRet);

            return strRet;
        }
        #endregion

        #region PF Response
        public string RespModelToXML<T>(T t, string strType)
        {
            string strRet = "";
            try
            {
                List<PropertyInfo> lstParent = new List<PropertyInfo>();
                List<PropertyInfo> lstChildren = new List<PropertyInfo>();

                GetClassName(t, ref lstParent, ref lstChildren);

                strRet += "<Message Devecie=\"" + lstParent[0].GetValue(t,null).ToString() + "\">";
                strRet += "<Response Name=\"" + lstParent[1].GetValue(t,null).ToString() + "\">";
                strRet += "<Row>";
                foreach (var v in lstChildren)
                {
                    object objValue = v.GetValue(t, null);
                    if (objValue != null)
                    {
                        strRet += "<" + v.Name + ">" + v.GetValue(t, null).ToString() + "</" + v.Name + ">";
                    }
                }
                strRet += "</Row>";
                strRet += "</Response>";
                strRet += "</Message>";
            }
            catch (Exception ex)
            {

            }

            return strRet;
        }

        public T RespSetModelValue<T>(T t, string strType, string strContent)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(strContent);

            List<NameAndValue> lstAttr = new List<NameAndValue>();
            XmlNode node = doc.SelectSingleNode("//Message");
            for (int i = 0; i < node.Attributes.Count; i++)
            {
                string strName = node.Attributes[i].Name;
                NameAndValue nv = new NameAndValue();
                nv.Name = strName;
                nv.Value = node.Attributes[strName].Value;
                lstAttr.Add(nv);
            }

            XmlNodeList nodeList = node.ChildNodes;

            for (int i = 0; i < nodeList.Count; i++)
            {
                for (int j = 0; j < nodeList[i].Attributes.Count; j++)
                {
                    string strName = nodeList[i].Attributes[j].Name;
                    NameAndValue nv = new NameAndValue();
                    nv.Name = strName;
                    nv.Value = nodeList[i].Attributes[strName].Value;
                    lstAttr.Add(nv);
                }
            }

            XmlNode subNote = doc.SelectSingleNode("//"+strType);

            XmlNodeList subNodeList = subNote.ChildNodes;
            for (int i = 0; i < subNodeList.Count; i++)
            {
                string strName = subNodeList[i].Name;
                NameAndValue nv = new NameAndValue();
                nv.Name = strName;
                nv.Value = subNodeList[i].InnerText;
                lstAttr.Add(nv);
            }

            PropertyInfo[] pps = GetPropertyInfos(t.GetType().BaseType);
            Type target = t.GetType();

            foreach (var v in lstAttr)
            {
                PropertyInfo targetPP = target.GetProperty(v.Name);
                object objValue = v.Value;
                if (objValue != null && string.IsNullOrEmpty(objValue.ToString()) == false)
                {
                    targetPP.SetValue(t, SD_ChanageType(objValue, targetPP.PropertyType), null);
                }
            }


            return t;
           
        }
        #endregion

        /// <summary>
        /// 转换可空类型
        /// </summary>
        /// <param name="value"></param>
        /// <param name="convertsionType"></param>
        /// <returns></returns>
        public object SD_ChanageType(object value, Type convertsionType)
        {
            //判断convertsionType类型是否为泛型，因为nullable是泛型类,
            if (convertsionType.IsGenericType &&
                //判断convertsionType是否为nullable泛型类
                convertsionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null || value.ToString().Length == 0)
                {
                    return null;
                }

                //如果convertsionType为nullable类，声明一个NullableConverter类，该类提供从Nullable类到基础基元类型的转换
                NullableConverter nullableConverter = new NullableConverter(convertsionType);
                //将convertsionType转换为nullable对的基础基元类型
                convertsionType = nullableConverter.UnderlyingType;
            }
            return Convert.ChangeType(value, convertsionType);
        }

        public T DictionaryToModel<T>(T t, Dictionary<string, string> dic)
        {
            PropertyInfo[] pps = GetPropertyInfos(t.GetType());
            Type target = t.GetType();

            var property = t.GetType().GetProperty("PropertyName");

            List<string> lstKeys = dic.Keys.ToList();

            if (lstKeys.Count > 0)
            {
                foreach(var p in pps)
                { 
                    PropertyInfo targetPP = target.GetProperty(p.Name);
                    if (dic.ContainsKey(p.Name))
                    {
                        object objValue = HttpUtility.UrlDecode(dic[p.Name]);

                        targetPP.SetValue(t, SD_ChanageType(objValue, targetPP.PropertyType), null);
                    }
                }
            }

            return t;
        }

        /// <summary>
        /// model转换成Dictionary
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public Dictionary<string, string> ModelToDictionary<T>(T t)
        {
            Dictionary<string, string> dicRet = new Dictionary<string, string>();

            try
            {
                List<PropertyInfo> lstParent = new List<PropertyInfo>();
                List<PropertyInfo> lstChildren = new List<PropertyInfo>();

                GetClassName(t, ref lstParent, ref lstChildren);

                foreach (var v in lstParent)
                {
                    object objValue = v.GetValue(t, null);
                    if (dicRet.ContainsKey(v.Name) == false)
                    {
                        dicRet.Add(v.Name, objValue.ToString());
                    }
                }

                foreach (var v in lstChildren)
                {
                    object objValue = v.GetValue(t, null);
                    if (objValue == null || string.IsNullOrEmpty(objValue.ToString()))
                    {
                        if (dicRet.ContainsKey(v.Name) == false)
                        {
                            dicRet.Add(v.Name, "");
                        }
                    }
                    else
                    {
                        //处理传入参数是否是DateTime类型，如果是，转换成yyyy-MM-dd格式
                        DateTime dateTemp;
                        string strValue;
                        if (IsDateTime(objValue.ToString()))
                        {
                            dateTemp = Convert.ToDateTime(objValue.ToString());
                            strValue = dateTemp.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else
                        {
                            strValue = objValue.ToString();
                        }

                        if (dicRet.ContainsKey(v.Name) == false)
                        {
                            dicRet.Add(v.Name, strValue);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
 
            }

            return dicRet;
        }
    }
}
