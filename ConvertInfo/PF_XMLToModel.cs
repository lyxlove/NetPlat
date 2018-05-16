using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gfVehicleLibraryPF;
using System.Xml;

namespace ConvertInfo
{
    public class PF_XMLToModel
    {
        public RequestParent Req_XmlToModel(RequestParent Req, string strReqContent)
        {
            RequestParent reqParent = new RequestParent();
            switch (Req.Name)
            {
                case "Verify":
                    reqParent = Req_Verify_ToModel(Req, strReqContent);
                    break;
                case "GetTime":
                    reqParent = Req_GetTime_ToModel(Req, strReqContent);
                    break;
            }
            return reqParent;
            
        }

        public ResponseParent Resp_XmlToModel(ResponseParent Resp, string strRespContent)
        {
            ResponseParent respParent = new ResponseParent();
            switch (Resp.Name)
            { 
                case "Verify":
                    respParent = Resp_Verify_ToModel(Resp, strRespContent);
                    break;
                case "GetTime":
                      respParent=Resp_GetTime_ToModel(Resp,strRespContent);
                    break;
            }

            return respParent;
        }

        #region Verify
        private Vehicle_DR001_Login_Request Req_Verify_ToModel(RequestParent Req, string strReqContent)
        {
            Vehicle_DR001_Login_Request m_Req = (Vehicle_DR001_Login_Request)Req;
            ModelReflection mR = new ModelReflection();
            m_Req = mR.ReqXMLToModel(m_Req,  "Row", strReqContent);
            return m_Req;
        }

        private Vehicle_DR001_Login_Response Resp_Verify_ToModel(ResponseParent Resp, string strRespContent)
        {
            Vehicle_DR001_Login_Response m_Resp = (Vehicle_DR001_Login_Response)Resp;
            XmlDocument document = new XmlDocument();
            document.LoadXml(strRespContent);
            ModelReflection mR = new ModelReflection();
            m_Resp = mR.RespSetModelValue(m_Resp, "Row", strRespContent);

            return m_Resp;
        }

        #endregion

        #region GetTime
        private Vehicle_DR004_GetTime_Request Req_GetTime_ToModel(RequestParent Req, string strReqContent)
        {

            Vehicle_DR004_GetTime_Request m_Req = (Vehicle_DR004_GetTime_Request)Req;
            ModelReflection mR = new ModelReflection();
            m_Req = mR.ReqXMLToModel(m_Req, "Request", strReqContent);
            return m_Req;


        }

        private Vehicle_DR004_GetTime_Response Resp_GetTime_ToModel(ResponseParent Resp, string strRespContent)
        {
            Vehicle_DR004_GetTime_Response m_Resp = (Vehicle_DR004_GetTime_Response)Resp;
            XmlDocument document = new XmlDocument();
            document.LoadXml(strRespContent);
            ModelReflection mR = new ModelReflection();
            m_Resp = mR.RespSetModelValue(m_Resp, "Row", strRespContent);
            return m_Resp;

        }

        #endregion
    }
}
