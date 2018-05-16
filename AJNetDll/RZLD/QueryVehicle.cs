using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gfVehicleLibraryAJ;
using ConvertInfo;
using ProcessManage;
using AJNetLib;

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
                    case "18C49":
                        Vehicle_18C49_Para m_18C49_Para = Get_18C49_FromDic(queryCondition.DicQueryPara);
                        Vehicle_18C49_Result m_Result_18C49 = Query_18C49(m_18C49_Para);
                        retInfo.IsSucessful = m_Result_18C49.code == "1" ? true : false;
                        if (retInfo.IsSucessful)
                        {
                            Dictionary<string, string> dicRet = new Dictionary<string, string>();
                            dicRet.Add("HPHM", m_Result_18C49.hphm);
                            dicRet.Add("HPZLDH", m_Result_18C49.hpzl);
                            dicRet.Add("VIN", m_Result_18C49.clsbdh);
                            dicRet.Add("CLZLDH", m_Result_18C49.cllx);
                            dicRet.Add("SYR", m_Result_18C49.syr);
                            dicRet.Add("SYXZDH", m_Result_18C49.syxz);
                            dicRet.Add("PP", m_Result_18C49.clpp1);
                            dicRet.Add("XH", m_Result_18C49.clxh);
                            dicRet.Add("FDJH", m_Result_18C49.fdjh);
                            dicRet.Add("FDJZZCS", m_Result_18C49.zzcmc);
                            dicRet.Add("FDJXH", m_Result_18C49.fdjxh);
                            dicRet.Add("YZLJ", m_Result_18C49.qlj.ToString());
                            dicRet.Add("CCDJRQ", m_Result_18C49.ccdjrq.ToString("yyyy-MM-dd"));
                            dicRet.Add("CCRQ", m_Result_18C49.ccrq.ToString("yyyy-MM-dd"));
                            dicRet.Add("CYS", m_Result_18C49.hdzk.ToString());
                            dicRet.Add("ZZL", m_Result_18C49.zzl.ToString());
                            dicRet.Add("ZBZL", m_Result_18C49.zbzl.ToString());
                            dicRet.Add("HDZH", m_Result_18C49.hdzzl.ToString());
                            dicRet.Add("CSC", m_Result_18C49.cwkc.ToString());
                            dicRet.Add("CSG", m_Result_18C49.cwkg.ToString());
                            dicRet.Add("CSK", m_Result_18C49.cwkk.ToString());
                            dicRet.Add("CSYSDH", m_Result_18C49.csys.ToString());
                            dicRet.Add("RLLBDH", m_Result_18C49.rlzl.ToString());
                            dicRet.Add("CLYTDH", m_Result_18C49.clyt.ToString());
                            dicRet.Add("YTSXDH", m_Result_18C49.ytsx.ToString());
                            dicRet.Add("ZZS", m_Result_18C49.zs.ToString());
                            dicRet.Add("ZXZLXDH", m_Result_18C49.zxxs);
                            dicRet.Add("EDGL", m_Result_18C49.gl.ToString());
                            dicRet.Add("FDJPL", m_Result_18C49.pl.ToString());
                            dicRet.Add("CPMC", m_Result_18C49.clpp1.ToString());
                            dicRet.Add("HXNBCD", m_Result_18C49.hxnbcd.ToString());
                            dicRet.Add("HXNBKD", m_Result_18C49.hxnbkd.ToString());
                            dicRet.Add("HXNBGD", m_Result_18C49.hxnbgd.ToString());
                            dicRet.Add("SFMJ", m_Result_18C49.sfmj.ToString());
                            if (string.IsNullOrEmpty(m_Result_18C49.bmjyy) == false)
                            {
                                dicRet.Add("BMJYY", m_Result_18C49.bmjyy.ToString());
                            }
                            dicRet.Add("LWCXWZJL", m_Result_18C49.zt.ToString());
                            dicRet.Add("ZJ", m_Result_18C49.zj.ToString());

                            retInfo.DicRet = dicRet;
                        }
                        else
                        {
                            retInfo.Message = m_Result_18C49.message;
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

        private Vehicle_18C49_Result Query_18C49(Vehicle_18C49_Para para_18C49)
        {
            AJ_ReadProcess readProcess = new AJ_ReadProcess();
            Vehicle_18C49_Result result_18C49 = readProcess.AJ_Read_18C49(para_18C49);
            return result_18C49;
        }

        #region 得到字典集合
        /// <summary>
        /// Dictionary change to 18C51 Para
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private Vehicle_18C49_Para Get_18C49_FromDic(Dictionary<string, string> dic)
        {
            ModelReflection m_ModelReflection = new ModelReflection();
            Vehicle_18C49_Para m_18C49_Para = new Vehicle_18C49_Para();

            m_18C49_Para = m_ModelReflection.DictionaryToModel(m_18C49_Para, dic);

            return m_18C49_Para;
        }
        #endregion
    }
}
