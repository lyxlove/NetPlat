using ConvertInfo;
using gfVehicleLibraryAJ;
using ProcessManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using LogHelper;

namespace VehicleForIYASAKA
{
    /// <summary>
    /// myWebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class VehicleForIYASAKAService_AJ : System.Web.Services.WebService
    {
        [WebMethod]
        public string queryObjectOut(string xtlb, string jkxlh, string jkid, string xmlDoc)
        {
            AJ_ReadProcess readProcess = new AJ_ReadProcess();
            AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
            AJ_ModelToXML modelToXML = new AJ_ModelToXML();
            switch (jkid)
            {
                case "18J52":
                    Vehicle_18J52_Para para_18J52 = new Vehicle_18J52_Para(jkid,jkxlh,xtlb);
                    para_18J52 = (Vehicle_18J52_Para)xmlToModel.Para_XmlToModel(para_18J52, xmlDoc);

                    Vehicle_18J52_Result result_18J52 = readProcess.AJ_Read_18J52(para_18J52);

                    string strRet_18J52 = modelToXML.ModelToXml("18J52", result_18J52);
                    return strRet_18J52;
                case "18C49":
                    Vehicle_18C49_Para para_18C49 = new Vehicle_18C49_Para(jkid, jkxlh, xtlb);
                    para_18C49 = (Vehicle_18C49_Para)xmlToModel.Para_XmlToModel(para_18C49, xmlDoc);

                    Vehicle_18C49_Result result_18C49 = readProcess.AJ_Read_18C49(para_18C49);

                    string strRet_18C49 = modelToXML.ModelToXml("18C49", result_18C49);
                    return strRet_18C49;
                case "18C50":
                    Vehicle_18C50_Para para_18C50 = new Vehicle_18C50_Para(jkid, jkxlh, xtlb);
                    para_18C50 = (Vehicle_18C50_Para)xmlToModel.Para_XmlToModel(para_18C50, xmlDoc);

                    Vehicle_18C50_Result result_18C50 = readProcess.AJ_Read_18C50(para_18C50);

                    string strRet_18C50 = modelToXML.ModelToXml("18C50", result_18C50);
                    return strRet_18C50;
                case "18J80":
                    Vehicle_18J80_Para para_18J80 = new Vehicle_18J80_Para(jkid, jkxlh, xtlb);
                    para_18J80 = (Vehicle_18J80_Para)xmlToModel.Para_XmlToModel(para_18J80, xmlDoc);

                    Vehicle_18J80_Result result_18J80 = readProcess.AJ_Read_18J80(para_18J80);

                    string strRet_18J80 = modelToXML.ModelToXml("18J80", result_18J80);
                    return strRet_18J80;
                case "18W06":
                    Vehicle_18W06_Para para_18W06 = new Vehicle_18W06_Para();
                    para_18W06 = (Vehicle_18W06_Para)xmlToModel.Para_XmlToModel(para_18W06, xmlDoc);
                    Vehicle_18W06_Result result_18W06 = readProcess.AJ_Read_18W06(para_18W06);
                    string strRet_18W06 = modelToXML.ModelToXml("18W06", result_18W06);
                    return strRet_18W06;
                default:
                    break;
            }

            return "";
        }


        [WebMethod]
        public string writeObjectOut(string xtlb, string jkxlh, string jkid, string xmlDoc)
        {
            AJ_WriteProcess writeProcess = new AJ_WriteProcess();
            AJ_XMLToModel xmlToModel = new AJ_XMLToModel();
            AJ_ModelToXML modelToXML = new AJ_ModelToXML();
            switch (jkid)
            {
                case "18C51":
                    Vehicle_18C51_Para para_18C51 = new Vehicle_18C51_Para(jkid, jkxlh, xtlb);
                    para_18C51 = (Vehicle_18C51_Para)xmlToModel.Para_XmlToModel(para_18C51, xmlDoc);

                    Vehicle_18C51_Result result_18C51 = writeProcess.AJ_Write_18C51(para_18C51);

                    string strRet_18C51 = modelToXML.ModelToXml("18C51", result_18C51);
                    return strRet_18C51;
                case "18C66":
                    Vehicle_18C66_Para para_18C66 = new Vehicle_18C66_Para(jkid, jkxlh, xtlb);
                    para_18C66 = (Vehicle_18C66_Para)xmlToModel.Para_XmlToModel(para_18C66, xmlDoc);

                    Vehicle_18C66_Result result_18C66 = writeProcess.AJ_Write_18C66(para_18C66);

                    string strRet_18C66 = modelToXML.ModelToXml("18C66", result_18C66);
                    return strRet_18C66;
                case "18J11":
                    Vehicle_18J11_Para para_18J11 = new Vehicle_18J11_Para(jkid, jkxlh, xtlb);
                    para_18J11 = (Vehicle_18J11_Para)xmlToModel.Para_XmlToModel(para_18J11, xmlDoc);

                    Vehicle_18J11_Result result_18J11 = writeProcess.AJ_Write_18J11(para_18J11);

                    string strRet_18J11 = modelToXML.ModelToXml("18J11", result_18J11);
                    return strRet_18J11;
                case "18J12":
                    Vehicle_18J12_Para para_18J12 = new Vehicle_18J12_Para(jkid, jkxlh, xtlb);
                    para_18J12 = (Vehicle_18J12_Para)xmlToModel.Para_XmlToModel(para_18J12, xmlDoc);

                    Vehicle_18J12_Result result_18J12 = writeProcess.AJ_Write_18J12(para_18J12);

                    string strRet_18J12 = modelToXML.ModelToXml("18J12", result_18J12);
                    return strRet_18J12;
                case "18C82":
                    Vehicle_18C82_Para para_18C82 = new Vehicle_18C82_Para(jkid, jkxlh, xtlb);
                    para_18C82 = (Vehicle_18C82_Para)xmlToModel.Para_XmlToModel(para_18C82, xmlDoc);

                    Vehicle_18C82_Result result_18C82 = writeProcess.AJ_Write_18C82(para_18C82);

                    string strRet_18C82 = modelToXML.ModelToXml("18C82", result_18C82);
                    return strRet_18C82;
                case "18C59":
                    Vehicle_18C59_Para para_18C59 = new Vehicle_18C59_Para(jkid, jkxlh, xtlb);
                    para_18C59 = (Vehicle_18C59_Para)xmlToModel.Para_XmlToModel(para_18C59, xmlDoc);

                    Vehicle_18C59_Result result_18C59 = writeProcess.AJ_Write_18C59(para_18C59);

                    string strRet_18C59 = modelToXML.ModelToXml("18C59", result_18C59);
                    return strRet_18C59;
                case "18C55":
                    Vehicle_18C55_Para para_18C55 = new Vehicle_18C55_Para(jkid, jkxlh, xtlb);
                    para_18C55 = (Vehicle_18C55_Para)xmlToModel.Para_XmlToModel(para_18C55, xmlDoc);

                    Vehicle_18C55_Result result_18C55 = writeProcess.AJ_Write_18C55(para_18C55);

                    string strRet_18C55 = modelToXML.ModelToXml("18C55", result_18C55);
                    return strRet_18C55;
                case "18C58":
                    Vehicle_18C58_Para para_18C58 = new Vehicle_18C58_Para(jkid, jkxlh, xtlb);
                    para_18C58 = (Vehicle_18C58_Para)xmlToModel.Para_XmlToModel(para_18C58, xmlDoc);

                    Vehicle_18C58_Result result_18C58 = writeProcess.AJ_Write_18C58(para_18C58);

                    string strRet_18C58 = modelToXML.ModelToXml("18C58", result_18C58);
                    return strRet_18C58;
                case "18C80":
                    Vehicle_18C80_Para para_18C80 = new Vehicle_18C80_Para();
                    para_18C80.jkid = jkid;
                    para_18C80.xtlb = xtlb;
                    para_18C80.jkxlh = jkxlh;
                    para_18C80 = (Vehicle_18C80_Para)xmlToModel.Para_XmlToModel(para_18C80, xmlDoc);

                    Vehicle_18C80_Result result_18C80 = writeProcess.AJ_Write_18C80(para_18C80);

                    string strRet_18C80 = modelToXML.ModelToXml("18C80", result_18C80);
                    return strRet_18C80;
                case "18C81":
                    Vehicle_18C81_Para para_18C81 = new Vehicle_18C81_Para();
                    para_18C81.jkid = jkid;
                    para_18C81.xtlb = xtlb;
                    para_18C81.jkxlh = jkxlh;
                    para_18C81 = (Vehicle_18C81_Para)xmlToModel.Para_XmlToModel(para_18C81, xmlDoc);

                    Vehicle_18C81_Result result_18C81 = writeProcess.AJ_Write_18C81(para_18C81);

                    string strRet_18C81 = modelToXML.ModelToXml("18C81", result_18C81);
                    return strRet_18C81;
                case "18J31":
                    Vehicle_18J31_Para para_18J31 = new Vehicle_18J31_Para(jkid, jkxlh, xtlb);
                    para_18J31 = (Vehicle_18J31_Para)xmlToModel.Para_XmlToModel(para_18J31, xmlDoc);

                    Vehicle_18J31_Result result_18J31 = writeProcess.AJ_Write_18J31(para_18J31);

                    string strRet_18J31 = modelToXML.ModelToXml("18J31", result_18J31);
                    return strRet_18J31;
                case "18C62":
                    Vehicle_18C62_Para para_18C62 = new Vehicle_18C62_Para(jkid, jkxlh, xtlb);
                    para_18C62 = (Vehicle_18C62_Para)xmlToModel.Para_XmlToModel(para_18C62, xmlDoc);

                    Vehicle_18C62_Result result_18C62 = writeProcess.AJ_Write_18C62(para_18C62);

                    string strRet_18C62 = modelToXML.ModelToXml("18C62", result_18C62);
                    return strRet_18C62;
                case "18C65":
                    Vehicle_18C65_Para para_18C65 = new Vehicle_18C65_Para(jkid, jkxlh, xtlb);
                    para_18C65 = (Vehicle_18C65_Para)xmlToModel.Para_XmlToModel(para_18C65, xmlDoc);

                    Vehicle_18C65_Result result_18C65 = writeProcess.AJ_Write_18C65(para_18C65);

                    string strRet_18C65 = modelToXML.ModelToXml("18C65", result_18C65);
                    return strRet_18C65;
                case "18C52":
                    Vehicle_18C52_Para para_18C52 = new Vehicle_18C52_Para(jkid, jkxlh, xtlb);
                    para_18C52 = (Vehicle_18C52_Para)xmlToModel.Para_XmlToModel(para_18C52, xmlDoc);

                    Vehicle_18C52_Result result_18C52 = writeProcess.AJ_Write_18C52(para_18C52);

                    string strRet_18C52 = modelToXML.ModelToXml("18C52", result_18C52);
                    return strRet_18C52;
                case "18C72":
                    Vehicle_18C72_Para para_18C72 = new Vehicle_18C72_Para(jkid, jkxlh, xtlb);
                    para_18C72 = (Vehicle_18C72_Para)xmlToModel.Para_XmlToModel(para_18C72, xmlDoc);

                    Vehicle_18C72_Result result_18C72 = writeProcess.AJ_Write_18C72(para_18C72);

                    string strRet_18C72 = modelToXML.ModelToXml("18C72", result_18C72);
                    return strRet_18C72;
                case "18C54":
                    Vehicle_18C54_Para para_18C54 = new Vehicle_18C54_Para(jkid, jkxlh, xtlb);
                    para_18C54 = (Vehicle_18C54_Para)xmlToModel.Para_XmlToModel(para_18C54, xmlDoc);

                    Vehicle_18C54_Result result_18C54 = writeProcess.AJ_Write_18C54(para_18C54);

                    string strRet_18C54 = modelToXML.ModelToXml("18C54", result_18C54);
                    return strRet_18C54;
                case "18C63":
                    Vehicle_18C63_Para para_18C63 = new Vehicle_18C63_Para(jkid, jkxlh, xtlb);
                    para_18C63 = (Vehicle_18C63_Para)xmlToModel.Para_XmlToModel(para_18C63, xmlDoc);

                    Vehicle_18C63_Result result_18C63 = writeProcess.AJ_Write_18C63(para_18C63);

                    string strRet_18C63 = modelToXML.ModelToXml("18C63", result_18C63);
                    return strRet_18C63;
                case "18X05":
                    Vehicle_18X05_Para para_18X05 = new Vehicle_18X05_Para(jkid, jkxlh, xtlb);
                    para_18X05 = (Vehicle_18X05_Para)xmlToModel.Para_XmlToModel(para_18X05, xmlDoc);

                    Vehicle_18X05_Result result_18X05 = writeProcess.AJ_Write_18X05(para_18X05);

                    string strRet_18X05 = modelToXML.ModelToXml("18X05", result_18X05);
                    return strRet_18X05;
                case"18W05":
                    Vehicle_18W05_Para para_18W05 = new Vehicle_18W05_Para();
                    para_18W05 = (Vehicle_18W05_Para)xmlToModel.Para_XmlToModel(para_18W05, xmlDoc);

                    Vehicle_18W05_Result result_18W05 = writeProcess.AJ_Write_18W05(para_18W05);

                    string strRet_18W05 = modelToXML.ModelToXml("18W05", result_18W05);
                    return strRet_18W05;
                default:
                    break;
            }

            return "";
        }
    }
}


