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
    public class UploadVehicle:IUploadVehicle
    {
        public ReturnInfo UploadByJKId(UploadCondition uploadCondition)
        {
            ReturnInfo retInfo = new ReturnInfo();
            try
            {
                if (uploadCondition.m_18C82 != null && !string.IsNullOrEmpty(uploadCondition.m_18C82.jkid))
                {
                    Vehicle_18C82_Result m_18C82_Result = Write_18C82(uploadCondition.m_18C82);
                    retInfo.IsSucessful = m_18C82_Result.code == "1" ? true : false;
                    retInfo.Message = m_18C82_Result.message;
                }
                else if (uploadCondition.m_18C59 != null && !string.IsNullOrEmpty(uploadCondition.m_18C59.jkid))
                {
                    Vehicle_18C59_Result m_18C59_Result = Write_18C59(uploadCondition.m_18C59);
                    retInfo.IsSucessful = m_18C59_Result.code == "1" ? true : false;
                    retInfo.Message = m_18C59_Result.message;
                }
                else if (uploadCondition.m_18C62 != null && !string.IsNullOrEmpty(uploadCondition.m_18C62.jkid))
                {
                    Vehicle_18C62_Result m_18C62_Result = Write_18C62(uploadCondition.m_18C62);
                    retInfo.IsSucessful = m_18C62_Result.code == "1" ? true : false;
                    retInfo.Message = m_18C62_Result.message;
                }
            }
            catch (Exception ex)
            {
                retInfo.IsSucessful = false;
                retInfo.Message = ex.Message;
            }

            return retInfo;
        }

        private Vehicle_18C82_Result Write_18C82(Vehicle_18C82_Para para_18C82)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            Vehicle_18C82_Result result_18C82 = writeProcess.AJ_Write_18C82(para_18C82);
            return result_18C82;
        }

        private Vehicle_18C59_Result Write_18C59(Vehicle_18C59_Para para_18C59)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            Vehicle_18C59_Result result_18C59 = writeProcess.AJ_Write_18C59(para_18C59);
            return result_18C59;
        }

        private Vehicle_18C62_Result Write_18C62(Vehicle_18C62_Para para_18C62)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            Vehicle_18C62_Result result_18C62 = writeProcess.AJ_Write_18C62(para_18C62);
            return result_18C62;
        }
    }
}
