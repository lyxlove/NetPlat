using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AJNetLib;
using gfVehicleLibraryAJ;
using ConvertInfo;
using ProcessManage;

namespace AJNetDll
{
    public class QueryVehicle:IQueryVehicle
    {
        public ReturnInfo QueryByJKId(QueryCondition queryCondition)
        {
            ReturnInfo retInfo = new ReturnInfo();
            try
            {
                string strJKID = queryCondition.DicQueryPara["jkid"];
                switch (strJKID)
                {
                    case "18W06":
                        Vehicle_18W06_Para m_18W06 = Get_18W06_FromDic(queryCondition.DicQueryPara);

                        Vehicle_18W06_Result m_Result_18W06 = Query_18W06(m_18W06);
                        retInfo.IsSucessful = m_Result_18W06.code == "1" ? true : false;
                        if (retInfo.IsSucessful)
                        {
                            Dictionary<string, string> dicRet = new Dictionary<string, string>();
                            dicRet.Add("jclsh ", m_Result_18W06.jclsh);
                            dicRet.Add("sbbh", m_Result_18W06.sbbh);
                            dicRet.Add("hpzl", m_Result_18W06.hpzl);
                            dicRet.Add("hphm", m_Result_18W06.hphm);
                            dicRet.Add("lsh", m_Result_18W06.lsh);
                            dicRet.Add("jycs", m_Result_18W06.jycs);
                            dicRet.Add("jyxm", m_Result_18W06.jyxm);
                            dicRet.Add("clsbdh", m_Result_18W06.clsbdh);
                            dicRet.Add("cllx", m_Result_18W06.cllx);
                            if (m_Result_18W06.zll != null)
                            {
                                dicRet.Add("zll", m_Result_18W06.zll.ToString());
                            }
                            if (m_Result_18W06.zs != null)
                            {
                                dicRet.Add("zs", m_Result_18W06.zs.ToString());
                            }

                            dicRet.Add("success", m_Result_18W06.success);
                            dicRet.Add("bzwkc", m_Result_18W06.bzwkc.ToString());
                            dicRet.Add("bzwkg", m_Result_18W06.bzwkg.ToString());
                            dicRet.Add("bzwkk", m_Result_18W06.bzwkk.ToString());
                            if (m_Result_18W06.clwkc != null)
                            {
                                dicRet.Add("clwkc", m_Result_18W06.clwkc.ToString());
                            }
                            if (m_Result_18W06.clwkg != null)
                            {
                                dicRet.Add("clwkg", m_Result_18W06.clwkg.ToString());
                            }
                            if (m_Result_18W06.clwkk != null)
                            {
                                dicRet.Add("clwkk", m_Result_18W06.clwkk.ToString());
                            }
                            if (m_Result_18W06.wkcjdwc != null)
                            {
                                dicRet.Add("wkcjdwc", m_Result_18W06.wkcjdwc.ToString());
                            }
                            if (m_Result_18W06.wkcxdwc != null)
                            {
                                dicRet.Add("wkcxdwc", m_Result_18W06.wkcxdwc.ToString());
                            }
                            if (m_Result_18W06.wkgjdwc != null)
                            {
                                dicRet.Add("wkgjdwc", m_Result_18W06.wkgjdwc.ToString());
                            }
                            if (m_Result_18W06.wkgxdwc != null)
                            {
                                dicRet.Add("wkgxdwc", m_Result_18W06.wkgxdwc.ToString());
                            }
                            if (m_Result_18W06.wkkjdwc != null)
                            {
                                dicRet.Add("wkkjdwc", m_Result_18W06.wkkjdwc.ToString());
                            }
                            if (m_Result_18W06.wkkxdwc != null)
                            {
                                dicRet.Add("wkkxdwc", m_Result_18W06.wkkxdwc.ToString());
                            }

                            dicRet.Add("clwkcpd", m_Result_18W06.clwkcpd.ToString());
                            dicRet.Add("clwkgpd", m_Result_18W06.clwkgpd.ToString());
                            dicRet.Add("clwkkpd", m_Result_18W06.clwkkpd.ToString());
                            if (m_Result_18W06.bzlbgd != null)
                            {
                                dicRet.Add("bzlbgd", m_Result_18W06.bzlbgd.ToString());
                            }
                            if (m_Result_18W06.cllbgd != null)
                            {
                                dicRet.Add("cllbgd", m_Result_18W06.cllbgd.ToString());
                            }
                            if (m_Result_18W06.lbgdjdwc != null)
                            {
                                dicRet.Add("lbgdjdwc", m_Result_18W06.lbgdjdwc.ToString());
                            }
                            if (m_Result_18W06.lbgdxdwc != null)
                            {
                                dicRet.Add("lbgdxdwc", m_Result_18W06.lbgdxdwc.ToString());
                            }
                            dicRet.Add("lbgdpd", m_Result_18W06.lbgdpd.ToString());
                            if (m_Result_18W06.zj1 != null)
                            {
                                dicRet.Add("zj1", m_Result_18W06.zj1.ToString());
                            }
                            if (m_Result_18W06.zj2 != null)
                            {
                                dicRet.Add("zj2", m_Result_18W06.zj2.ToString());
                            }
                            if (m_Result_18W06.zj3 != null)
                            {
                                dicRet.Add("zj3", m_Result_18W06.zj3.ToString());
                            }
                            if (m_Result_18W06.zj4 != null)
                            {
                                dicRet.Add("zj4", m_Result_18W06.zj4.ToString());
                            }

                            dicRet.Add("qx", m_Result_18W06.qx.ToString());
                            dicRet.Add("hx", m_Result_18W06.hx.ToString());
                            dicRet.Add("jckssj", m_Result_18W06.jckssj.ToString());
                            dicRet.Add("jcjssj", m_Result_18W06.jcjssj.ToString());
                            dicRet.Add("jcrq", m_Result_18W06.jcrq.ToString());
                            dicRet.Add("zcpd", m_Result_18W06.zcpd.ToString());
                            dicRet.Add("wkcwcxz", m_Result_18W06.wkcwcxz.ToString());
                            dicRet.Add("wkkwcxz", m_Result_18W06.wkkwcxz.ToString());
                            dicRet.Add("wkgwcxz", m_Result_18W06.wkgwcxz.ToString());

                            retInfo.DicRet = dicRet;
                        }
                        else
                        {
                            retInfo.Message = m_Result_18W06.message;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                retInfo.IsSucessful = false;
                retInfo.Message = ex.Message;
            }

            return retInfo;
        }

        #region 查询函数
        private Vehicle_18W06_Result Query_18W06(Vehicle_18W06_Para para_18W06)
        {
            AJ_ReadProcess readProcess = new AJ_ReadProcess();
            Vehicle_18W06_Result result_18W06 = readProcess.AJ_Read_18W06(para_18W06);
            return result_18W06;
        }
        #endregion

        #region 得到字典集合
        /// <summary>
        /// Dictionary change to 18C51 Para
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private Vehicle_18W06_Para Get_18W06_FromDic(Dictionary<string, string> dic)
        {
            ModelReflection m_ModelReflection = new ModelReflection();
            Vehicle_18W06_Para m_18W06_Para = new Vehicle_18W06_Para();

            m_18W06_Para = m_ModelReflection.DictionaryToModel(m_18W06_Para, dic);

            return m_18W06_Para;
        }
        #endregion

    }
}
