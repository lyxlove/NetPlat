using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gfVehicleLibraryPF;

namespace ConvertInfo
{
    public class PF_ModelToXML
    {
        public string ModelToXml(string strType, RequestParent Req)
        {
            string strXML = "";
            switch (strType)
            {
                case "Verify":
                    strXML = Req_Verify_ToXml(Req);
                    break;
                case "GetTime":
                    strXML = Req_GetTime_ToXml(Req);
                    break;              
                
            }

            return strXML;
        }

        public string ModelToXml(string strType, ResponseParent Resp)
        {
            string strXML = "";
            switch (strType)
            {
                case "Verify":
                    strXML = Resp_Verify_ToXml(Resp);
                    break;
                case "GetTime":
                    strXML = Resp_GetTime_ToXml(Resp);
                    break;

            }

            return strXML;
        }

        #region Verify
        private string Req_Verify_ToXml(RequestParent req)
        {
            Vehicle_DR001_Login_Request m_Verify_Req = (Vehicle_DR001_Login_Request)req;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ReqModelToXML(m_Verify_Req, "vehispara");
            return strRet;
        }

        private string Resp_Verify_ToXml(ResponseParent resp)
        {
            Vehicle_DR001_Login_Response m_Verify_Resp = (Vehicle_DR001_Login_Response)resp;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.RespModelToXML(m_Verify_Resp, "vehispara");
            return strRet;
        }
        #endregion

        #region GetTime
        private string Req_GetTime_ToXml(RequestParent req)
        {
            Vehicle_DR004_GetTime_Request m_GetTime_Req = (Vehicle_DR004_GetTime_Request)req;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ReqModelToXML(m_GetTime_Req, "???");
            return strRet;

        }

        private string Resp_GetTime_ToXml(ResponseParent resp)
        {
            Vehicle_DR004_GetTime_Response m_GetTime_Resp = (Vehicle_DR004_GetTime_Response)resp;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.RespModelToXML(m_GetTime_Resp, "???");
            return strRet;
        }

        #endregion
    }
}
