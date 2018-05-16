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
    public class WriteVehicle:IWriteVehicle
    {
        public ReturnInfo WriteByJKId(WriteCondition writeCondition)
        {
            ReturnInfo retInfo = new ReturnInfo();
            try
            {
                string strJKID = writeCondition.DicWritePara["jkid"];
                if (strJKID == "18C51")
                {//登录
                    Vehicle_18C51_Para m_18C51 = Get_18C51_FromDic(writeCondition.DicWritePara);
                    Vehicle_18C51_Result m_18C51_Result = Write_18C51(m_18C51);
                    retInfo.IsSucessful = m_18C51_Result.code == "1" ? true : false;
                    if (!retInfo.IsSucessful)
                    {
                        retInfo.Message = m_18C51_Result.message;
                    }
                    else
                    {
                        Vehicle_18C52_Para m_18C52 = Get_18C52_FromDic(writeCondition.DicWritePara);
                        m_18C52.jkid = "18C52";
                        Vehicle_18C52_Result m_18C52_Result = Write_18C52(m_18C52);
                        retInfo.IsSucessful = m_18C52_Result.code == "1" ? true : false;
                        if (!retInfo.IsSucessful)
                        {
                            retInfo.Message = m_18C52_Result.message;
                        }
                    }
                }
                else if (strJKID == "18C66")
                {//更新
                    Vehicle_18C66_Para m_18C66 = Get_18C66_FromDic(writeCondition.DicWritePara);
                    Vehicle_18C66_Result m_18C66_Result = Write_18C66(m_18C66);
                    retInfo.IsSucessful = m_18C66_Result.code == "1" ? true : false;
                    if (!retInfo.IsSucessful)
                    {
                        retInfo.Message = m_18C66_Result.message;
                    }
                }
                else if (strJKID == "18C65")
                {//复检
                    Vehicle_18C65_Para m_18C65 = Get_18C65_FromDic(writeCondition.DicWritePara);
                    Vehicle_18C65_Result m_18C65_Result = Write_18C65(m_18C65);
                    retInfo.IsSucessful = m_18C65_Result.code == "1" ? true : false;
                    if (!retInfo.IsSucessful)
                    {
                        retInfo.Message = m_18C65_Result.message;
                    }
                    else
                    {
                        Vehicle_18C52_Para m_18C52 = Get_18C52_FromDic(writeCondition.DicWritePara);
                        m_18C52.jkid = "18C52";
                        Vehicle_18C52_Result m_18C52_Result = Write_18C52(m_18C52);
                        retInfo.IsSucessful = m_18C52_Result.code == "1" ? true : false;
                        if (!retInfo.IsSucessful)
                        {
                            retInfo.Message = m_18C52_Result.message;
                        }
                    }
                }
                else if (strJKID == "18C72")
                {//退办
                    Vehicle_18C72_Para m_18C72 = Get_18C72_FromDic(writeCondition.DicWritePara);
                    Vehicle_18C72_Result m_18C72_Result = Write_18C72(m_18C72);
                    retInfo.IsSucessful = m_18C72_Result.code == "1" ? true : false;
                    if (!retInfo.IsSucessful)
                    {
                        retInfo.Message = m_18C72_Result.message;
                    }
                }
                else if (strJKID == "18C54")
                {//路试结果录入
                    Vehicle_18C54_Para m_18C54 = Get_18C54_FromDic(writeCondition.DicWritePara);
                    Vehicle_18C54_Result m_18C54_Result = Write_18C54(m_18C54);
                    retInfo.IsSucessful = m_18C54_Result.code == "1" ? true : false;
                    if (!retInfo.IsSucessful)
                    {
                        retInfo.Message = m_18C54_Result.message;
                    }
                }
                else if (strJKID == "18C58")
                {
                    Vehicle_18C58_Para m_18C58 = Get_18C58_FromDic(writeCondition.DicWritePara);
                    Vehicle_18C58_Result m_18C58_Result = Write_18C58(m_18C58);
                    retInfo.IsSucessful = m_18C58_Result.code == "1" ? true : false;
                    if (!retInfo.IsSucessful)
                    {
                        retInfo.Message = m_18C58_Result.message;
                    }
                }
                else if (strJKID == "18C55")
                {
                    Vehicle_18C55_Para m_18C55 = Get_18C55_FromDic(writeCondition.DicWritePara);
                    m_18C55.jkid = "18C55";
                    Vehicle_18C55_Result m_18C55_Result = Write_18C55(m_18C55);
                    retInfo.IsSucessful = m_18C55_Result.code == "1" ? true : false;
                    if (!retInfo.IsSucessful)
                    {
                        retInfo.Message = m_18C55_Result.message;
                    }
                }
                else if (strJKID == "18C52")
                {//登录开始信息
                    Vehicle_18C52_Para m_18C52 = Get_18C52_FromDic(writeCondition.DicWritePara);
                    m_18C52.jkid = "18C52";
                    Vehicle_18C52_Result m_18C52_Result = Write_18C52(m_18C52);
                    retInfo.IsSucessful = m_18C52_Result.code == "1" ? true : false;
                    if (!retInfo.IsSucessful)
                    {
                        retInfo.Message = m_18C52_Result.message;
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

        #region 写入函数
        private Vehicle_18C51_Result Write_18C51(Vehicle_18C51_Para para_18C51)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            Vehicle_18C51_Result result_18C51 = writeProcess.AJ_Write_18C51(para_18C51);
            return result_18C51;
        }

        private Vehicle_18C66_Result Write_18C66(Vehicle_18C66_Para para_18C66)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            Vehicle_18C66_Result result_18C66 = writeProcess.AJ_Write_18C66(para_18C66);
            return result_18C66;
        }

        private Vehicle_18C65_Result Write_18C65(Vehicle_18C65_Para para_18C65)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            Vehicle_18C65_Result result_18C65 = writeProcess.AJ_Write_18C65(para_18C65);
            return result_18C65;
        }

        private Vehicle_18C52_Result Write_18C52(Vehicle_18C52_Para para_18C52)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            Vehicle_18C52_Result result_18C52 = writeProcess.AJ_Write_18C52(para_18C52);
            return result_18C52;
        }

        private Vehicle_18C55_Result Write_18C55(Vehicle_18C55_Para para_18C55)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            Vehicle_18C55_Result result_18C55 = writeProcess.AJ_Write_18C55(para_18C55);
            return result_18C55;
        }

        private Vehicle_18C72_Result Write_18C72(Vehicle_18C72_Para para_18C72)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            Vehicle_18C72_Result result_18C72 = writeProcess.AJ_Write_18C72(para_18C72);
            return result_18C72;
        }

        private Vehicle_18C54_Result Write_18C54(Vehicle_18C54_Para para_18C54)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            Vehicle_18C54_Result result_18C54 = writeProcess.AJ_Write_18C54(para_18C54);
            return result_18C54;
        }

        private Vehicle_18C58_Result Write_18C58(Vehicle_18C58_Para para_18C58)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            Vehicle_18C58_Result result_18C58 = writeProcess.AJ_Write_18C58(para_18C58);
            return result_18C58;
        }
        #endregion

        #region 得到字典集合
        /*主要接收页面发送过来的字典集合，字典集合中包括了很多字段，
         * 通过下面的函数，可以把字典中的字段转换成实体类，在对实体类进行操作
         * 如何集合中没有对应的字段，需要页面端进行添加
         */

        /// <summary>
        /// Dictionary change to 18C51 Para
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private Vehicle_18C51_Para Get_18C51_FromDic(Dictionary<string, string> dic)
        {
            ModelReflection m_ModelReflection = new ModelReflection();
            Vehicle_18C51_Para m_18C51_Para = new Vehicle_18C51_Para();

            m_18C51_Para = m_ModelReflection.DictionaryToModel(m_18C51_Para, dic);

            return m_18C51_Para;
        }

        /// <summary>
        /// Dictionary change to 18C66 Para
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private Vehicle_18C66_Para Get_18C66_FromDic(Dictionary<string, string> dic)
        {
            ModelReflection m_ModelReflection = new ModelReflection();
            Vehicle_18C66_Para m_18C66_Para = new Vehicle_18C66_Para();

            m_18C66_Para = m_ModelReflection.DictionaryToModel(m_18C66_Para, dic);

            return m_18C66_Para;
        }

        /// <summary>
        /// Dictionary change to 18C65 Para
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private Vehicle_18C65_Para Get_18C65_FromDic(Dictionary<string, string> dic)
        {
            ModelReflection m_ModelReflection = new ModelReflection();
            Vehicle_18C65_Para m_18C65_Para = new Vehicle_18C65_Para();

            m_18C65_Para = m_ModelReflection.DictionaryToModel(m_18C65_Para, dic);

            return m_18C65_Para;
        }

        /// <summary>
        ///  Dictionary change to 18C52 Para
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private Vehicle_18C52_Para Get_18C52_FromDic(Dictionary<string, string> dic)
        {
            ModelReflection m_ModelReflection = new ModelReflection();
            Vehicle_18C52_Para m_18C52_Para = new Vehicle_18C52_Para();

            m_18C52_Para = m_ModelReflection.DictionaryToModel(m_18C52_Para, dic);
            m_18C52_Para.kssj = DateTime.Now;

            return m_18C52_Para;
        }

        /// <summary>
        ///  Dictionary change to 18C55 Para
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private Vehicle_18C55_Para Get_18C55_FromDic(Dictionary<string, string> dic)
        {
            ModelReflection m_ModelReflection = new ModelReflection();
            Vehicle_18C55_Para m_18C55_Para = new Vehicle_18C55_Para();

            m_18C55_Para = m_ModelReflection.DictionaryToModel(m_18C55_Para, dic);

            return m_18C55_Para;
        }
        

        /// <summary>
        ///  Dictionary change to 18C72 Para
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private Vehicle_18C72_Para Get_18C72_FromDic(Dictionary<string, string> dic)
        {
            ModelReflection m_ModelReflection = new ModelReflection();
            Vehicle_18C72_Para m_18C72_Para = new Vehicle_18C72_Para();

            m_18C72_Para = m_ModelReflection.DictionaryToModel(m_18C72_Para, dic);

            return m_18C72_Para;
        }

        /// <summary>
        ///  Dictionary change to 18C54 Para
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private Vehicle_18C54_Para Get_18C54_FromDic(Dictionary<string, string> dic)
        {
            ModelReflection m_ModelReflection = new ModelReflection();
            Vehicle_18C54_Para m_18C54_Para = new Vehicle_18C54_Para();

            m_18C54_Para = m_ModelReflection.DictionaryToModel(m_18C54_Para, dic);

            return m_18C54_Para;
        }


        /// <summary>
        ///  Dictionary change to 18C58 Para
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private Vehicle_18C58_Para Get_18C58_FromDic(Dictionary<string, string> dic)
        {
            ModelReflection m_ModelReflection = new ModelReflection();
            Vehicle_18C58_Para m_18C58_Para = new Vehicle_18C58_Para();

            m_18C58_Para = m_ModelReflection.DictionaryToModel(m_18C58_Para, dic);

            return m_18C58_Para;
        }
        #endregion
    }
}
