using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace LogHelper
{
    public static class Log
    {
        public static bool WriteLog(LOG_INFO logInfo)
        {
            return true;
            //bool bolResult = false;
            //string strSql = "insert into LOG_INFO(JCLSH,Category,Name,FS_Infor,JS_Infor,Log_Infor,FunName,LogTime) ";
            //strSql += " values('" + logInfo.JCLSH + "','" + logInfo.Category + "','" + logInfo.Name + "','" + logInfo.FS_Infor + "','" + logInfo.JS_Infor + "','" + logInfo.Log_Infor + "','" + logInfo.FunName + "','" + logInfo.LogTime.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            //try
            //{
            //    string strConn = ReadConfig.GetValueFromXML("connectionString", "value");
            //    SqlConnection conn = new SqlConnection(strConn);
            //    conn.Open();

            //    if (conn.State == ConnectionState.Open)
            //    {
            //        SqlCommand m_cmdCommand = conn.CreateCommand();

            //        m_cmdCommand.Parameters.Clear();
            //        m_cmdCommand.CommandType = CommandType.Text;
            //        m_cmdCommand.CommandText = strSql;

            //        try
            //        {
            //            m_cmdCommand.ExecuteNonQuery();
            //            bolResult = true;
            //        }
            //        catch
            //        {
            //        }
            //        finally
            //        {
            //            m_cmdCommand.Dispose();
            //            conn.Close();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //}

            //return bolResult;
        }

        public static string GetIPAddress(string strHostName)
        {
            string strIPAddress = "";
            var IPs = System.Net.Dns.GetHostAddresses(strHostName);

            for (int i = 0; i < IPs.Length; i++)
            {
                if (IPs[i].AddressFamily.ToString() == "InterNetwork")
                {
                    strIPAddress = IPs.GetValue(i).ToString();
                    break;
                }
            }

            return strIPAddress;
        }

        public enum LogType
        {
            Error = 0, //错误
            NetSuc,    //联网成功
            NetFail,    //联网失败
            NPFail,     //联网平台错误，内部联网平台出现错误
            Normal,
            NetUpDown,      //联网的上传与下载
        }

        public static bool WriteJKLog(NETLOG_INFO log)
        {
            bool bolResult = false;

            NETLOG_INFO netLog = new NETLOG_INFO();
            //string strJKID;
            //bool bHasUpdated = netLog.GetUpdate(log.LWLSH, log.JYCS, log.JYXM, log.JKName, out strJKID);

            string strSql = "";
            //if (strJKID != "-1")
            //{
            //    if (bHasUpdated == false)
            //    {
            //        strSql = "update NET_AJ_JK_RESULT set  SendInfo ='" + log .SendInfo+ "', RevcInfo = '"+log.RevcInfo+"',LogTime ='"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"')  where ID='"+strJKID+"'";
            //    }
            //}
            //else
            //{
                strSql = "insert into NET_AJ_JK_RESULT(LWLSH,JCLSH,JYCS,LWType,JKName,JYXM,SendInfo,RevcInfo,IsSuc,LogTime) ";
                strSql += " values('" + log.LWLSH + "','" + log.JCLSH + "','" + log.JYCS + "','" + log.LWType + "','" + log.JKName + "','" + log.JYXM + "','" + log.SendInfo + "','" + log.RevcInfo + "','" + log.IsSuc + "','" + log.LogTime.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            //}

            try
            {
                string strConn = ReadConfig.GetValueFromXML("connectionString", "value");
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    SqlCommand m_cmdCommand = conn.CreateCommand();

                    m_cmdCommand.Parameters.Clear();
                    m_cmdCommand.CommandType = CommandType.Text;
                    m_cmdCommand.CommandText = strSql;

                    try
                    {
                        m_cmdCommand.ExecuteNonQuery();
                        bolResult = true;
                    }
                    catch
                    {
                    }
                    finally
                    {
                        m_cmdCommand.Dispose();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return bolResult;
        }

    }

    public class LOG_INFO
    {
         public string JCLSH {get;set;}
         public string Category{get;set;}
         public string Name{get;set;}
         public string FS_Infor{get;set;}
         public string JS_Infor{get;set;}
         public string Log_Infor{get;set;}
         public string FunName{get;set;}
         public DateTime LogTime{get;set;}
         public string IPAddress{get;set;}
         public string HostName{get;set;}
         public string OpName{get;set;}
    }

    public class NETLOG_INFO
    {
        public string JCLSH { get; set; }
        public string LWLSH { get; set; }
        public string JYCS { get; set; }
        public string LWType { get; set; }
        public string JKName { get; set; }
        public string JYXM { get; set; }
        public string SendInfo { get; set; }
        public string RevcInfo { get; set; }
        public string IsSuc { get; set; }
        public DateTime LogTime { get; set; }


        public string GetJCLSH(string strLWLSH, string strJYCS)
        {
            string strRet = "";

            try
            {

                string strConn = ReadConfig.GetValueFromXML("connectionString", "value");
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                if (strJYCS == null)
                {
                    string strGetJYCSSql = string.Format("SELECT * FROM NET_AJ_JK_RESULT WHERE LWLSH = '{0}' ORDER BY ID DESC ", strLWLSH);
                    SqlCommand cmd1 = new SqlCommand(strGetJYCSSql,conn);
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        if (dr1["JYCS"].ToString() != string.Empty)
                        {
                            strJYCS = dr1["JYCS"].ToString();
                            break;
                        }
                    }
                }

                string strSql = "select JCLSH from NET_AJ_JK_RESULT where LWLSH='" + strLWLSH + "' and JYCS='" + strJYCS + "' and (JCLSH<>'' and JCLSH is not null)";

                SqlCommand cmd = new SqlCommand(strSql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    strRet = dr["JCLSH"].ToString();
                    break;
                }

                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {

            }

            return strRet;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strLWLSH"></param>
        /// <param name="strJYCS"></param>
        /// <returns></returns>
        public bool GetSuccessful(string strLWLSH, string strJYCS, string strJYXM,string strJKID,bool IsBJXY = false)
        {
           
            bool bRet = false;
            if (IsBJXY)
            {
                return false;
            }

            //原因是新凌志联网，必须发两张照片和两个视频
            if (strJKID == "18X04" && (strJYXM == "M1" || strJYXM == "Z1"))
            {
                return false;
            }

            string strConn = ReadConfig.GetValueFromXML("connectionString", "value");
            SqlConnection conn = new SqlConnection(strConn);
            try
            {

                conn.Open();
                string strSql = "select IsSuc,ID from NET_AJ_JK_RESULT where LWType='AJ' and LWLSH='" + strLWLSH + "' and JYCS='" + strJYCS + "' and (JCLSH<>'' and JCLSH is not null) and JYXM='" + strJYXM + "' and JKName='" + strJKID + "'";

                SqlCommand cmd = new SqlCommand(strSql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                string strIsSuc = "";
                while (dr.Read())
                {
                    strIsSuc = dr["IsSuc"].ToString();
                    if (strIsSuc == "1")
                    {
                        bRet = true;
                        break;
                    }
                }

                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }

            return bRet;
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="strLWLSH"></param>
        ///// <param name="strJYCS"></param>
        ///// <param name="strJYXM"></param>
        ///// <param name="strJKID"></param>
        ///// <returns></returns>
        //public bool GetUpdate(string strLWLSH, string strJYCS, string strJYXM, string strJKID, out string strID)
        //{
        //    bool bRet = false;
        //    strID = "-1";

        //    string strConn = ReadConfig.GetValueFromXML("connectionString", "value");
        //    SqlConnection conn = new SqlConnection(strConn);
        //    try
        //    {
        //        conn.Open();

        //        string strSql = "select IsUpdate,ID from NET_AJ_JK_RESULT where IsSuc<>'1' and LWType='AJ' LWLSH='" + strLWLSH + "' and JYCS='" + strJYCS + "' and JYXM='" + strJYXM + "' and JKName='" + JKName + "'";


        //        SqlCommand cmd = new SqlCommand(strSql, conn);
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        string strIsSuc = "";
        //        while (dr.Read())
        //        {
        //            strID = dr["ID"].ToString();
        //            strIsSuc = dr["IsSuc"].ToString();
        //            if (strIsSuc == "1")
        //            {
        //                bRet = true;
        //                break;
        //            }
        //        }

        //        conn.Close();
        //        conn.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        if (conn != null)
        //        {
        //            conn.Close();
        //            conn.Dispose();
        //        }
        //    }

        //    return bRet;
        //}
    }
}
