using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gfVehicleLibraryAJ;
using System.Xml;

namespace ConvertInfo
{
    public class AJ_ModelToXML
    {
        public string ModelToXml(string strType, ParaParent para)
        {
            string strXML = "";
            switch(strType)
            {
                case "18C49":
                    strXML = Para_18C49_ToXml(para);
                    break;
                case "18C51":
                    strXML = Para_18C51_ToXml(para);
                    break;
                case "18J52":
                    strXML = Para_18J52_ToXml(para);
                    break;
                case "18C50":
                    strXML = Para_18C50_ToXml(para);
                    break;
                case "18C66":
                    strXML = Para_18C66_ToXml(para);
                    break;
                case "18C82":
                    strXML = Para_18C82_ToXml(para);
                    break;
                case "18J11":
                    strXML = Para_18J11_ToXml(para);
                    break;
                case "18C55":
                    strXML = Para_18C55_ToXml(para);
                    break;
                case "18C58":
                    strXML = Para_18C58_ToXml(para);
                    break;
                case "18C80":
                    strXML = Para_18C80_ToXml(para);
                    break;
                case "18C81":
                    strXML = Para_18C81_ToXml(para);
                    break;
                case "18J31":
                    strXML = Para_18J31_ToXml(para);
                    break;
                case "18C62":
                    strXML = Para_18C62_ToXml(para);
                    break;
                case "18C59":
                    strXML = Para_18C59_ToXml(para);
                    break;
                case "18C65":
                    strXML = Para_18C65_ToXml(para);
                    break;
                case "18C52":
                    strXML = Para_18C52_ToXml(para);
                    break;
                case "18C72":
                    strXML = Para_18C72_ToXml(para);
                    break;
                case "18J80":
                    strXML = Para_18J80_ToXml(para);
                    break;
                case "18X01":
                    strXML = Para_18X01_ToXml(para);
                    break;
                case "18X02":
                    strXML = Para_18X02_ToXml(para);
                    break;
                case "18X03":
                    strXML = Para_18X03_ToXml(para);
                    break;
                case "18C54":
                    strXML = Para_18C54_ToXml(para);
                    break;
                case "18X04":
                    strXML = Para_18X04_ToXml(para);
                    break;
                case "18C63":
                    strXML = Para_18C63_ToXml(para);
                    break;
                case "18X05":
                    strXML = Para_18X05_ToXml(para);
                    break;
                case"18W05":
                    strXML = Para_18W05_ToXml(para);
                    break;
                case "18W06":
                    strXML = Para_18W06_ToXml(para);
                    break;
            }

            return strXML;
        }

        public string ModelToXml(string strType, ResultParent result)
        {
            string strXML = "";
            switch (strType)
            {
                case "18C49":
                    strXML = Result_18C49_ToXml(result);
                    break;
                case "18C50":
                    strXML = Result_18C50_ToXml(result);
                    break;
                case "18C51":
                    strXML = Result_18C51_ToXml(result);
                    break;
                case "18J11":
                    strXML = Result_18J11_ToXml(result);
                    break;
                case "18J52":
                    strXML = Result_18J52_ToXml(result);
                    break;
                case "18C66":
                    strXML = Result_18C66_ToXml(result);
                    break;
                case "18C82":
                    strXML = Result_18C82_ToXml(result);
                    break;
                case "18C55":
                    strXML = Result_18C55_ToXml(result);
                    break;
                case "18C58":
                    strXML = Result_18C58_ToXml(result);
                    break;
                case "18C80":
                    strXML = Result_18C80_ToXml(result);
                    break;
                case "18C81":
                    strXML = Result_18C81_ToXml(result);
                    break;
                case "18J31":
                    strXML = Result_18J31_ToXml(result);
                    break;
                case "18C59":
                    strXML = Result_18C59_ToXml(result);
                    break;
                case "18C62":
                    strXML = Result_18C62_ToXml(result);
                    break;
                case "18C65":
                    strXML = Result_18C65_ToXml(result);
                    break;
                case "18C52":
                    strXML = Result_18C52_ToXml(result);
                    break;
                case "18C72":
                    strXML = Result_18C72_ToXml(result);
                    break;
                case "18J80":
                    strXML = Result_18J80_ToXml(result);
                    break;
                case "18X01":
                    strXML = Result_18X01_ToXml(result);
                    break;
                case "18X02":
                    strXML = Result_18X02_ToXml(result);
                    break;
                case "18X03":
                    strXML = Result_18X03_ToXml(result);
                    break;
                case "18C54":
                    strXML = Result_18C54_ToXml(result);
                    break;
                case "18X04":
                    strXML = Result_18X04_ToXml(result);
                    break;
                case "18C63":
                    strXML = Result_18C63_ToXml(result);
                    break;
                case "18X05":
                    strXML = Result_18X05_ToXml(result);
                    break;
                case"18W05":
                    strXML = Result_18W05_ToXml(result);
                    break;
                case "18W06":
                    strXML = Result_18W06_ToXml(result);
                    break;
            }

            return strXML;
        }

        #region 18J11
        private string Result_18J11_ToXml(ResultParent result)
        {
            Vehicle_18J11_Result m_18J11_Result = (Vehicle_18J11_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18J11_Result, "vehispara");
            return strRet;
        }

        private string Para_18J11_ToXml(ParaParent para)
        {
            Vehicle_18J11_Para m_18J11_Papa = (Vehicle_18J11_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18J11_Papa, "vehispara");
            return strRet;
        }
        #endregion

        #region 18J52
        private string Para_18J52_ToXml(ParaParent para)
        {
            Vehicle_18J52_Para m_18J52_Papa = (Vehicle_18J52_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18J52_Papa, "QueryCondition");
            return strRet;
        }

        private string Result_18J52_ToXml(ResultParent result)
        {
            Vehicle_18J52_Result m_18J52_Result = (Vehicle_18J52_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18J52_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C49
        private string Para_18C49_ToXml(ParaParent para)
        {
            Vehicle_18C49_Para m_18C49_Papa = (Vehicle_18C49_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C49_Papa, "QueryCondition");
            return strRet;
        }

        private string Result_18C49_ToXml(ResultParent result)
        {
            Vehicle_18C49_Result m_18C49_Result = (Vehicle_18C49_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C49_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C50
        private string Para_18C50_ToXml(ParaParent para)
        {
            Vehicle_18C50_Para m_18C50_Para = (Vehicle_18C50_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C50_Para, "QueryCondition");
            return strRet;
        }

        private string Result_18C50_ToXml(ResultParent result)
        {
            Vehicle_18C50_Result m_18C50_Result = (Vehicle_18C50_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C50_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C51
        private string Para_18C51_ToXml(ParaParent para)
        {
            Vehicle_18C51_Para m_18C51_Papa = (Vehicle_18C51_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C51_Papa, "vehispara");
            return strRet;
        }

        private string Result_18C51_ToXml(ResultParent result)
        {
            Vehicle_18C51_Result m_18C51_Result = (Vehicle_18C51_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C51_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C66
        private string Para_18C66_ToXml(ParaParent para)
        {
            Vehicle_18C66_Para m_18C66_Papa = (Vehicle_18C66_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C66_Papa, "vehispara");
            return strRet;
        }

        private string Result_18C66_ToXml(ResultParent result)
        {
            Vehicle_18C66_Result m_18C66_Result = (Vehicle_18C66_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C66_Result, "vehispara", false);
            return strRet;
        }
        #endregion

        #region 18C82
        private string Para_18C82_ToXml(ParaParent para)
        {
            Vehicle_18C82_Para m_18C82_Papa = (Vehicle_18C82_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C82_Papa, "vehispara");
            return strRet;
        }

        private string Result_18C82_ToXml(ResultParent result)
        {
            Vehicle_18C82_Result m_18C82_Result = (Vehicle_18C82_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C82_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C55
        private string Para_18C55_ToXml(ParaParent para)
        {
            Vehicle_18C55_Para m_18C55_Papa = (Vehicle_18C55_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C55_Papa, "vehispara");
            return strRet;
        }

        private string Result_18C55_ToXml(ResultParent result)
        {
            Vehicle_18C55_Result m_18C55_Result = (Vehicle_18C55_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C55_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C58
        private string Para_18C58_ToXml(ParaParent para)
        {
            Vehicle_18C58_Para m_18C58_Papa = (Vehicle_18C58_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C58_Papa, "vehispara");
            return strRet;
        }

        private string Result_18C58_ToXml(ResultParent result)
        {
            Vehicle_18C58_Result m_18C58_Result = (Vehicle_18C58_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C58_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C80
        private string Para_18C80_ToXml(ParaParent para)
        {
            string strRet = "";
            ModelReflection mR = new ModelReflection();
            Vehicle_18C80_Para m_18C80_Papa = (Vehicle_18C80_Para)para;

            switch (m_18C80_Papa.jyxm)
            {
                case "DC"://动态底盘
                    Vehicle_18C80_DTDP_Para m_DTDP_Para = (Vehicle_18C80_DTDP_Para)m_18C80_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_DTDP_Para, "vehispara");
                    break;
                case "C1"://底盘检查
                    Vehicle_18C80_DPJC_Para m_DPJC_Para = (Vehicle_18C80_DPJC_Para)m_18C80_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_DPJC_Para, "vehispara");
                    break;
            }

            return strRet;
        }

        private string Result_18C80_ToXml(ResultParent result)
        {
            Vehicle_18C80_Result m_18C80_Result = (Vehicle_18C80_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C80_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C81
        private string Para_18C81_ToXml(ParaParent para)
        {
            string strRet = "";
            ModelReflection mR = new ModelReflection();
            Vehicle_18C81_Para m_18C81_Papa = (Vehicle_18C81_Para)para;
           
            switch (m_18C81_Papa.jyxm)
            {
                case "B1"://一轴
                    Vehicle_18C81_YZZD_Para m_YZZD_Para = (Vehicle_18C81_YZZD_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_YZZD_Para, "vehispara");
                    break;
                case "B2"://二轴
                    Vehicle_18C81_EZZD_Para m_EZZD_Para = (Vehicle_18C81_EZZD_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_EZZD_Para, "vehispara");
                    break;
                case "B3"://三轴
                    Vehicle_18C81_SZZD_Para m_SZZD_Para = (Vehicle_18C81_SZZD_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_SZZD_Para, "vehispara");
                    break;
                case "B4"://四轴
                    Vehicle_18C81_SIZZD_Para m_SIZZD_Para = (Vehicle_18C81_SIZZD_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_SIZZD_Para, "vehispara");
                    break;
                case "B5"://五轴
                    Vehicle_18C81_WZZD_Para m_WZZD_Para = (Vehicle_18C81_WZZD_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_WZZD_Para, "vehispara");
                    break;
                case "B0"://驻车
                    Vehicle_18C81_ZCZD_Para m_ZCZD_Para = (Vehicle_18C81_ZCZD_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_ZCZD_Para, "vehispara");
                    break;
                case "H1"://左外
                    Vehicle_18C81_ZWD_Para m_ZWD_Para = (Vehicle_18C81_ZWD_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_ZWD_Para, "vehispara");
                    break;
                case "H2"://左内
                    Vehicle_18C81_ZND_Para m_ZND_Para = (Vehicle_18C81_ZND_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_ZND_Para, "vehispara");
                    break;
                case "H3"://右内
                    Vehicle_18C81_YND_Para m_YND_Para = (Vehicle_18C81_YND_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_YND_Para, "vehispara");
                    break;
                case "H4"://右外
                    Vehicle_18C81_YWD_Para m_YWD_Para = (Vehicle_18C81_YWD_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_YWD_Para, "vehispara");
                    break;
                case "S1"://车速表
                    Vehicle_18C81_CSB_Para m_CSB_Para = (Vehicle_18C81_CSB_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_CSB_Para, "vehispara");
                    break;
                case "A1"://侧滑
                    Vehicle_18C81_Sideslip_Para m_Sideslip_Para = (Vehicle_18C81_Sideslip_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_Sideslip_Para, "vehispara");
                    break;
                case "M1"://外廓尺寸
                    Vehicle_18C81_WKCC_Para m_WKCC_Para = (Vehicle_18C81_WKCC_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_WKCC_Para, "vehispara");
                    break;
                case "Z1"://整备质量
                    Vehicle_18C81_ZBZL_Para m_ZBZL_Para = (Vehicle_18C81_ZBZL_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_ZBZL_Para, "vehispara");
                    break;
                case "L1"://一轴
                    Vehicle_18C81_JZZD_Para m_YZJZ_Para = (Vehicle_18C81_JZZD_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_YZJZ_Para, "vehispara");
                    break;
                case "L2"://二轴
                    Vehicle_18C81_JZZD_Para m_EZJZ_Para = (Vehicle_18C81_JZZD_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_EZJZ_Para, "vehispara");
                    break;
                case "L3"://三轴
                    Vehicle_18C81_JZZD_Para m_SZJZ_Para = (Vehicle_18C81_JZZD_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_SZJZ_Para, "vehispara");
                    break;
                case "L4"://四轴
                    Vehicle_18C81_JZZD_Para m_SIZJZ_Para = (Vehicle_18C81_JZZD_Para)m_18C81_Papa;
                    strRet = mR.ParaModelToXML_Ex(m_SIZJZ_Para, "vehispara");
                    break;
            }

            return strRet;
        }

        private string Result_18C81_ToXml(ResultParent result)
        {
            Vehicle_18C81_Result m_18C81_Result = (Vehicle_18C81_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C81_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18J31
        private string Para_18J31_ToXml(ParaParent para)
        {
            Vehicle_18J31_Para m_18J31_Papa = (Vehicle_18J31_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18J31_Papa, "vehispara");
            return strRet;
        }

        private string Result_18J31_ToXml(ResultParent result)
        {
            Vehicle_18J31_Result m_18J31_Result = (Vehicle_18J31_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18J31_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C62
        private string Para_18C62_ToXml(ParaParent para)
        {
            Vehicle_18C62_Para m_18C62_Papa = (Vehicle_18C62_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML_18C62(m_18C62_Papa, "vehispara");
            return strRet;
        }

        private string Result_18C62_ToXml(ResultParent result)
        {
            Vehicle_18C62_Result m_18C62_Result = (Vehicle_18C62_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C62_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C59
        private string Para_18C59_ToXml(ParaParent para)
        {
            Vehicle_18C59_Para m_18C59_Papa = (Vehicle_18C59_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C59_Papa, "vehispara");
            return strRet;
        }

        private string Result_18C59_ToXml(ResultParent result)
        {
            Vehicle_18C59_Result m_18C59_Result = (Vehicle_18C59_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C59_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C65
        private string Para_18C65_ToXml(ParaParent para)
        {
            Vehicle_18C65_Para m_18C65_Papa = (Vehicle_18C65_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C65_Papa, "vehispara");
            return strRet;
        }

        private string Result_18C65_ToXml(ResultParent result)
        {
            Vehicle_18C65_Result m_18C65_Result = (Vehicle_18C65_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C65_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C52
        private string Para_18C52_ToXml(ParaParent para)
        {
            Vehicle_18C52_Para m_18C52_Papa = (Vehicle_18C52_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C52_Papa, "vehispara");
            return strRet;
        }

        private string Result_18C52_ToXml(ResultParent result)
        {
            Vehicle_18C52_Result m_18C52_Result = (Vehicle_18C52_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C52_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C72
        private string Para_18C72_ToXml(ParaParent para)
        {
            Vehicle_18C72_Para m_18C72_Papa = (Vehicle_18C72_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C72_Papa, "vehispara");
            return strRet;
        }

        private string Result_18C72_ToXml(ResultParent result)
        {
            Vehicle_18C72_Result m_18C72_Result = (Vehicle_18C72_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C72_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18J80
        private string Para_18J80_ToXml(ParaParent para)
        {
            Vehicle_18J80_Para m_18J80_Papa = (Vehicle_18J80_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18J80_Papa, "QueryCondition");
            return strRet;
        }

        private string Result_18J80_ToXml(ResultParent result)
        {
            Vehicle_18J80_Result m_18J80_Result = (Vehicle_18J80_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18J80_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18X01
        private string Para_18X01_ToXml(ParaParent para)
        {
            Vehicle_18X01_Para m_18X01_Papa = (Vehicle_18X01_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18X01_Papa, "QueryCondition");
            return strRet;
        }

        private string Result_18X01_ToXml(ResultParent result)
        {
            Vehicle_18X01_Result m_18X01_Result = (Vehicle_18X01_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18X01_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18X02
        private string Para_18X02_ToXml(ParaParent para)
        {
            Vehicle_18X02_Para m_18X02_Papa = (Vehicle_18X02_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18X02_Papa, "QueryCondition");
            return strRet;
        }

        private string Result_18X02_ToXml(ResultParent result)
        {
            Vehicle_18X02_Result m_18X02_Result = (Vehicle_18X02_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18X02_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18X03
        private string Para_18X03_ToXml(ParaParent para)
        {
            Vehicle_18X03_Para m_18X03_Papa = (Vehicle_18X03_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18X03_Papa, "QueryCondition");
            return strRet;
        }

        private string Result_18X03_ToXml(ResultParent result)
        {
            Vehicle_18X03_Result m_18X03_Result = (Vehicle_18X03_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18X03_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C54
        private string Para_18C54_ToXml(ParaParent para)
        {
            Vehicle_18C54_Para m_18C54_Papa = (Vehicle_18C54_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C54_Papa, "vehispara");
            return strRet;
        }

        private string Result_18C54_ToXml(ResultParent result)
        {
            Vehicle_18C54_Result m_18C54_Result = (Vehicle_18C54_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C54_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18X04
        private string Para_18X04_ToXml(ParaParent para)
        {
            Vehicle_18X04_Para m_18X04_Papa = (Vehicle_18X04_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18X04_Papa, "vehispara");
            return strRet;
        }

        private string Result_18X04_ToXml(ResultParent result)
        {
            Vehicle_18X04_Result m_18X04_Result = (Vehicle_18X04_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18X04_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18C63
        private string Para_18C63_ToXml(ParaParent para)
        {
            Vehicle_18C63_Para m_18C63_Papa = (Vehicle_18C63_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18C63_Papa, "vehispara");
            return strRet;
        }

        private string Result_18C63_ToXml(ResultParent result)
        {
            Vehicle_18C63_Result m_18C63_Result = (Vehicle_18C63_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18C63_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18X05
        private string Para_18X05_ToXml(ParaParent para)
        {
            Vehicle_18X05_Para m_18X05_Papa = (Vehicle_18X05_Para)para;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ParaModelToXML(m_18X05_Papa, "vehispara");
            return strRet;
        }

        private string Result_18X05_ToXml(ResultParent result)
        {
            Vehicle_18X05_Result m_18X05_Result = (Vehicle_18X05_Result)result;
            ModelReflection mR = new ModelReflection();
            string strRet = mR.ResultModelToXML(m_18X05_Result, "vehispara");
            return strRet;
        }
        #endregion

        #region 18W05
        private string Para_18W05_ToXml(ParaParent para)
        {
            Vehicle_18W05_Para _18W05_Para = (Vehicle_18W05_Para)para;
            ModelReflection _mr = new ModelReflection();
            string _result = _mr.ParaModelToXML(_18W05_Para, "vehispara");
            return _result;
        }

        private string Result_18W05_ToXml(ResultParent result)
        {
            Vehicle_18W05_Result _18W05_Result = (Vehicle_18W05_Result)result;
            ModelReflection _mr = new ModelReflection();
            string _result = _mr.ResultModelToXML(_18W05_Result, "vehispara");
            return _result;
        }
        #endregion

        #region 18W06
        private string Para_18W06_ToXml(ParaParent para)
        {
            Vehicle_18W06_Para _18W06_Para = (Vehicle_18W06_Para)para;
            ModelReflection _mr = new ModelReflection();
            string _result = _mr.ParaModelToXML(_18W06_Para, "QueryCondition");
            return _result;
        }

        private string Result_18W06_ToXml(ResultParent result)
        {
            Vehicle_18W06_Result _18W06_Result = (Vehicle_18W06_Result)result;
            ModelReflection _mr = new ModelReflection();
            string _result = _mr.ResultModelToXML(_18W06_Result, "QueryCondition");
            return _result;
        }

        #endregion
    }
}
