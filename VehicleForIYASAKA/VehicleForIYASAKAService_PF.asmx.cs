using ConvertInfo;
using ProcessManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using gfVehicleLibraryPF;

namespace VehicleForIYASAKA
{
    /// <summary>
    /// Summary description for VehicleForIYASAKAService_PF
    /// </summary>
    [WebService(Namespace = "http://tempuri.org1/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class VehicleForIYASAKAService_PF : System.Web.Services.WebService
    {
        [WebMethod]
        public string queryObjectOut(string name,string device, string xmlDoc)
        {
            string strXML = "";
            PF_ReadProcess readProcess = new PF_ReadProcess();
            PF_XMLToModel xmlToModel = new PF_XMLToModel();
            PF_ModelToXML modelToXML = new PF_ModelToXML();
            switch (name)
            {
                case "Verify":
                    Vehicle_DR001_Login_Request req_Verify = new Vehicle_DR001_Login_Request();
                    req_Verify.Name = name;
                    req_Verify.Device = device;
                    req_Verify = (Vehicle_DR001_Login_Request)xmlToModel.Req_XmlToModel(req_Verify, xmlDoc);
                    Vehicle_DR001_Login_Response resp_Verify = readProcess.PF_Read_Verify(req_Verify);
                    strXML = modelToXML.ModelToXml("Verify", resp_Verify);
                    break;

                case "GetTime":
                    Vehicle_DR004_GetTime_Request req_GetTime = new Vehicle_DR004_GetTime_Request();
                    req_GetTime.Name = name;
                    req_GetTime.Device = device;
                    req_GetTime = (Vehicle_DR004_GetTime_Request)xmlToModel.Req_XmlToModel(req_GetTime, xmlDoc);
                    Vehicle_DR004_GetTime_Response resp_GetTime = readProcess.PF_Read_GetTime(req_GetTime);
                    strXML = modelToXML.ModelToXml("GetTime", resp_GetTime);
                    break;
            }

            return strXML; 
        }
    }
}
