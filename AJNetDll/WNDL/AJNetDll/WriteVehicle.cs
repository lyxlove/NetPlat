using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AJNetLib;
using gfVehicleLibraryAJ;
using ProcessManage;
using ConvertInfo;

namespace AJNetDll
{
    public class WriteVehicle:IWriteVehicle
    {
        public ReturnInfo WriteByJKId(WriteCondition writeCondition)
        {
            ReturnInfo retInfo = new ReturnInfo();
            try
            {
                string strJKID = writeCondition.DicWritePara["jkid"];
                if (strJKID == "18W05")
                {//登录
                    Vehicle_18W05_Para m_18W05 = Get_18W05_FromDic(writeCondition.DicWritePara);
                    Vehicle_18W05_Result m_18W05_Result = Write_18W05(m_18W05);
                    retInfo.IsSucessful = m_18W05_Result.code == "1" ? true : false;
                    if (!retInfo.IsSucessful)
                    {
                        retInfo.Message = m_18W05_Result.message;
                    }
                }
            }
            catch (Exception ex)
            {
                retInfo.IsSucessful = false;
                retInfo.Message = ex.Message;
            }

            return retInfo;
        }

        #region 得到字典集合
        /// <summary>
        /// 得到字典集合
        /// </summary>
        /// <param name="DicWritePara"></param>
        /// <returns></returns>
        private Vehicle_18W05_Para Get_18W05_FromDic(Dictionary<string, string> DicWritePara)
        {
            ModelReflection m_ModelReflection = new ModelReflection();
            Vehicle_18W05_Para m_18W05_Para = new Vehicle_18W05_Para();

            m_18W05_Para = m_ModelReflection.DictionaryToModel(m_18W05_Para, DicWritePara);

            return m_18W05_Para;
        }
        #endregion

        #region 写入函数
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m_18W05"></param>
        /// <returns></returns>
        private Vehicle_18W05_Result Write_18W05(Vehicle_18W05_Para m_18W05)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            Vehicle_18W05_Result result_18W05 = writeProcess.AJ_Write_18W05(m_18W05);
            return result_18W05;
        }
        #endregion
    }
}
