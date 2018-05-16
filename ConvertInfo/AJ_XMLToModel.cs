using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gfVehicleLibraryAJ;
using System.Xml;

namespace ConvertInfo
{
    public class AJ_XMLToModel
    {
        public ParaParent Para_XmlToModel(ParaParent para, string strParaContent)
        {
            switch (para.jkid)
            {
                case "18C49":
                    para = Para_18C49_ToModel(para, strParaContent);
                    return para;
                case "18C50":
                    para = Para_18C50_ToModel(para, strParaContent);
                    return para;
                case "18C51":
                    para = Para_18C51_ToModel(para, strParaContent);
                    return para;
                case "18J52":
                    para = Para_18J52_ToModel(para, strParaContent);
                    return para;
                case "18C66":
                    para = Para_18C66_ToModel(para, strParaContent);
                    return para;
                case "18J11":
                    para = Para_18J11_ToModel(para, strParaContent);
                    return para;
                case "18J12":
                    para = Para_18J12_ToModel(para, strParaContent);
                    return para;
                case "18C82":
                    para = Para_18C82_ToModel(para, strParaContent);
                    return para;
                case "18C55":
                    para = Para_18C55_ToModel(para, strParaContent);
                    return para;
                case "18C58":
                    para = Para_18C58_ToModel(para, strParaContent);
                    return para;
                case "18C80":
                    para = Para_18C80_ToModel(para, strParaContent);
                    return para;
                case "18C81":
                    para = Para_18C81_ToModel(para, strParaContent);
                    return para;
                case "18J31":
                    para = Para_18J31_ToModel(para, strParaContent);
                    return para;
                case "18C62":
                    para = Para_18C62_ToModel(para, strParaContent);
                    return para;
                case "18C59":
                    para = Para_18C59_ToModel(para, strParaContent);
                    return para;
                case "18C65":
                    para = Para_18C65_ToModel(para, strParaContent);
                    return para;
                case "18C52":
                    para = Para_18C52_ToModel(para, strParaContent);
                    return para;
                case "18C72":
                    para = Para_18C72_ToModel(para, strParaContent);
                    return para;
                case "18J80":
                    para = Para_18J80_ToModel(para, strParaContent);
                    return para;
                case "18X01":
                    para = Para_18X01_ToModel(para, strParaContent);
                    return para;
                case "18X02":
                    para = Para_18X02_ToModel(para, strParaContent);
                    return para;
                case "18X03":
                    para = Para_18X03_ToModel(para, strParaContent);
                    return para;
                case "18C54":
                    para = Para_18C54_ToModel(para, strParaContent);
                    return para;
                case "18X04":
                    para = Para_18X04_ToModel(para, strParaContent);
                    return para;
                case "18C63":
                    para = Para_18C63_ToModel(para, strParaContent);
                    return para;
                case "18X05":
                    para = Para_18X05_ToModel(para, strParaContent);
                    return para;
                case "18W05":
                    para = Para_18W05_ToModel(para, strParaContent);
                    return para;
                case "18W06":
                    para = Para_18W06_ToModel(para, strParaContent);
                    return para;
                    
            }

            return null;
        }

        public ResultParent Result_XmlToModel(string strType, string strResultContent)
        {
            switch (strType)
            {
                case "18C49":
                    Vehicle_18C49_Result m_18C49_result = new Vehicle_18C49_Result();
                    m_18C49_result = Result_18C49_ToModel(m_18C49_result, strResultContent);
                    return m_18C49_result;
                case "18C50":
                    Vehicle_18C50_Result m_18C50_result = new Vehicle_18C50_Result();
                    m_18C50_result = Result_18C50_ToModel(m_18C50_result, strResultContent);
                    return m_18C50_result;
                case "18J11":
                    Vehicle_18J11_Result m_18J11_result = new Vehicle_18J11_Result();
                    m_18J11_result = Result_18J11_ToModel(m_18J11_result, strResultContent);
                    return m_18J11_result;
                case "18J12":
                    Vehicle_18J12_Result m_18J12_result = new Vehicle_18J12_Result();
                    m_18J12_result = Result_18J12_ToModel(m_18J12_result, strResultContent);
                    return m_18J12_result;
                case "18J52":
                    Vehicle_18J52_Result m_18J52_result = new Vehicle_18J52_Result();
                    m_18J52_result = Result_18J52_ToModel(m_18J52_result, strResultContent);
                    return m_18J52_result;
                case "18C66":
                    Vehicle_18C66_Result m_18C66_result = new Vehicle_18C66_Result();
                    m_18C66_result = Result_18C66_ToModel(m_18C66_result, strResultContent);
                    return m_18C66_result;
                case "18C82":
                    Vehicle_18C82_Result m_18C82_result = new Vehicle_18C82_Result();
                    m_18C82_result = Result_18C82_ToModel(m_18C82_result, strResultContent);
                    return m_18C82_result;
                case "18C55":
                    Vehicle_18C55_Result m_18C55_result = new Vehicle_18C55_Result();
                    m_18C55_result = Result_18C55_ToModel(m_18C55_result, strResultContent);
                    return m_18C55_result;
                case "18C58":
                    Vehicle_18C58_Result m_18C58_result = new Vehicle_18C58_Result();
                    m_18C58_result = Result_18C58_ToModel(m_18C58_result, strResultContent);
                    return m_18C58_result;
                case "18C80":
                    Vehicle_18C80_Result m_18C80_result = new Vehicle_18C80_Result();
                    m_18C80_result = Result_18C80_ToModel(m_18C80_result, strResultContent);
                    return m_18C80_result;
                case "18C81":
                    Vehicle_18C81_Result m_18C81_result = new Vehicle_18C81_Result();
                    m_18C81_result = Result_18C81_ToModel(m_18C81_result, strResultContent);
                    return m_18C81_result;
                case "18J31":
                    Vehicle_18J31_Result m_18J31_result = new Vehicle_18J31_Result();
                    m_18J31_result = Result_18J31_ToModel(m_18J31_result, strResultContent);
                    return m_18J31_result;
                case "18C62":
                    Vehicle_18C62_Result m_18C62_result = new Vehicle_18C62_Result();
                    m_18C62_result = Result_18C62_ToModel(m_18C62_result, strResultContent);
                    return m_18C62_result;
                case "18C59":
                    Vehicle_18C59_Result m_18C59_result = new Vehicle_18C59_Result();
                    m_18C59_result = Result_18C59_ToModel(m_18C59_result, strResultContent);
                    return m_18C59_result;
                case "18C65":
                    Vehicle_18C65_Result m_18C65_result = new Vehicle_18C65_Result();
                    m_18C65_result = Result_18C65_ToModel(m_18C65_result, strResultContent);
                    return m_18C65_result;
                case "18C51":
                    Vehicle_18C51_Result m_18C51_result = new Vehicle_18C51_Result();
                    m_18C51_result = Result_18C51_ToModel(m_18C51_result, strResultContent);
                    return m_18C51_result;
                case "18C52":
                    Vehicle_18C52_Result m_18C52_result = new Vehicle_18C52_Result();
                    m_18C52_result = Result_18C52_ToModel(m_18C52_result, strResultContent);
                    return m_18C52_result;
                case "18C72":
                    Vehicle_18C72_Result m_18C72_result = new Vehicle_18C72_Result();
                    m_18C72_result = Result_18C72_ToModel(m_18C72_result, strResultContent);
                    return m_18C72_result;
                case "18J80":
                    Vehicle_18J80_Result m_18J80_result = new Vehicle_18J80_Result();
                    m_18J80_result = Result_18J80_ToModel(m_18J80_result, strResultContent);
                    return m_18J80_result;
                case "18X01":
                    Vehicle_18X01_Result m_18X01_result = new Vehicle_18X01_Result();
                    m_18X01_result = Result_18X01_ToModel(m_18X01_result, strResultContent);
                    return m_18X01_result;
                case "18X02":
                    Vehicle_18X02_Result m_18X02_result = new Vehicle_18X02_Result();
                    m_18X02_result = Result_18X02_ToModel(m_18X02_result, strResultContent);
                    return m_18X02_result;
                case "18X03":
                    Vehicle_18X03_Result m_18X03_result = new Vehicle_18X03_Result();
                    m_18X03_result = Result_18X03_ToModel(m_18X03_result, strResultContent);
                    return m_18X03_result;
                case "18C54":
                    Vehicle_18C54_Result m_18C54_result = new Vehicle_18C54_Result();
                    m_18C54_result = Result_18C54_ToModel(m_18C54_result, strResultContent);
                    return m_18C54_result;
                case "18X04":
                    Vehicle_18X04_Result m_18X04_result = new Vehicle_18X04_Result();
                    m_18X04_result = Result_18X04_ToModel(m_18X04_result, strResultContent);
                    return m_18X04_result;
                case "18C63":
                    Vehicle_18C63_Result m_18C63_result = new Vehicle_18C63_Result();
                    m_18C63_result = Result_18C63_ToModel(m_18C63_result, strResultContent);
                    return m_18C63_result;
                case "18X05":
                    Vehicle_18X05_Result m_18X05_result = new Vehicle_18X05_Result();
                    m_18X05_result = Result_18X05_ToModel(m_18X05_result, strResultContent);
                    return m_18X05_result;
                case"18W05":
                    Vehicle_18W05_Result m_18W05_result = new Vehicle_18W05_Result();
                    m_18W05_result = Result_18W05_ToModel(m_18W05_result, strResultContent);
                    return m_18W05_result;
                case"18W06":
                     Vehicle_18W06_Result m_18W06_result = new Vehicle_18W06_Result();
                    m_18W06_result = Result_18W06_ToModel(m_18W06_result, strResultContent);
                    return m_18W06_result;
            }

            return null;
        }

        #region 18C49
        /// <summary>
        /// 18C49
        /// </summary>
        /// <param name="strParaContent"></param>
        /// <returns></returns>
        private Vehicle_18C49_Para Para_18C49_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C49_Para m_para = (Vehicle_18C49_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "QueryCondition", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18C49
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C49_Result Result_18C49_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C49_Result m_Result = (Vehicle_18C49_Result)result;
            if(string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C50
        /// <summary>
        /// 18C50 Para
        /// </summary>
        /// <param name="para"></param>
        /// <param name="strParaContent"></param>
        /// <returns></returns>
        private Vehicle_18C50_Para Para_18C50_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C50_Para m_para = (Vehicle_18C50_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "QueryCondition", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18C50 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C50_Result Result_18C50_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C50_Result m_Result = (Vehicle_18C50_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C51
        /// <summary>
        /// 18C51
        /// </summary>
        /// <param name="strParaContent"></param>
        /// <returns></returns>
        private Vehicle_18C51_Para Para_18C51_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C51_Para m_para = (Vehicle_18C51_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18C51 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C51_Result Result_18C51_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C51_Result m_Result = (Vehicle_18C51_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C52
        /// <summary>
        /// 18C52
        /// </summary>
        /// <param name="strParaContent"></param>
        /// <returns></returns>
        private Vehicle_18C52_Para Para_18C52_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C52_Para m_para = (Vehicle_18C52_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18C52 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C52_Result Result_18C52_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C52_Result m_Result = (Vehicle_18C52_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18J52
        /// <summary>
        /// 18J52 Para
        /// </summary>
        /// <param name="strParaContent"></param>
        /// <returns></returns>
        private Vehicle_18J52_Para Para_18J52_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18J52_Para m_para = (Vehicle_18J52_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "QueryCondition", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18J52 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18J52_Result Result_18J52_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18J52_Result m_Result = (Vehicle_18J52_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C66
        private Vehicle_18C66_Para Para_18C66_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C66_Para m_Para = (Vehicle_18C66_Para)para;
            ModelReflection mR = new ModelReflection();
            m_Para = mR.ParaSetModelValue(m_Para, "vehispara", strParaContent);

            return m_Para;
        }

        /// <summary>
        /// 18C66 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C66_Result Result_18C66_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C66_Result m_Result = (Vehicle_18C66_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18J11
        private Vehicle_18J11_Para Para_18J11_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18J11_Para m_para = (Vehicle_18J11_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18J11 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18J11_Result Result_18J11_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18J11_Result m_Result = (Vehicle_18J11_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18J12
        private Vehicle_18J12_Para Para_18J12_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18J12_Para m_para = (Vehicle_18J12_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18J12 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18J12_Result Result_18J12_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18J12_Result m_Result = (Vehicle_18J12_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C82
        private Vehicle_18C82_Para Para_18C82_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C82_Para m_para = (Vehicle_18C82_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18C82 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C82_Result Result_18C82_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C82_Result m_Result = (Vehicle_18C82_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C55
        private Vehicle_18C55_Para Para_18C55_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C55_Para m_para = (Vehicle_18C55_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18C55 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C55_Result Result_18C55_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C55_Result m_Result = (Vehicle_18C55_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C58
        private Vehicle_18C58_Para Para_18C58_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C58_Para m_para = (Vehicle_18C58_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18C58 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C58_Result Result_18C58_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C58_Result m_Result = (Vehicle_18C58_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C80
        private Vehicle_18C80_Para Para_18C80_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C80_Para m_para = (Vehicle_18C80_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);
            switch (m_para.jyxm)
            {
                case "DC":
                    Vehicle_18C80_DTDP_Para m_DTDP = new Vehicle_18C80_DTDP_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_DTDP = mR.ParaSetModelValue(m_DTDP, "vehispara", strParaContent);
                    m_para = (Vehicle_18C80_Para)m_DTDP;
                    break;
                case "C1":
                    Vehicle_18C80_DPJC_Para m_DPJC = new Vehicle_18C80_DPJC_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_DPJC = mR.ParaSetModelValue(m_DPJC, "vehispara", strParaContent);
                    m_para = (Vehicle_18C80_Para)m_DPJC;
                    break;
            }

            return m_para;
        }

        /// <summary>
        /// 18C80 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C80_Result Result_18C80_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C80_Result m_Result = (Vehicle_18C80_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C81
        private Vehicle_18C81_Para Para_18C81_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C81_Para m_para = (Vehicle_18C81_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);
            switch (m_para.jyxm)
            {
                case "B1":
                    Vehicle_18C81_YZZD_Para m_YZZD = new Vehicle_18C81_YZZD_Para(m_para.jkid,m_para.jkxlh,m_para.xtlb);
                    m_YZZD = mR.ParaSetModelValue(m_YZZD, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_YZZD;
                    break;
                case "B2":
                    Vehicle_18C81_EZZD_Para m_EZZD = new Vehicle_18C81_EZZD_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_EZZD = mR.ParaSetModelValue(m_EZZD, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_EZZD;
                    break;
                case "B3":
                    Vehicle_18C81_SZZD_Para m_SZZD = new Vehicle_18C81_SZZD_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_SZZD = mR.ParaSetModelValue(m_SZZD, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_SZZD;
                    break;
                case "B4":
                    Vehicle_18C81_SIZZD_Para m_SIZZD = new Vehicle_18C81_SIZZD_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_SIZZD = mR.ParaSetModelValue(m_SIZZD, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_SIZZD;
                    break;
                case "B5":
                    Vehicle_18C81_WZZD_Para m_WZZD = new Vehicle_18C81_WZZD_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_WZZD = mR.ParaSetModelValue(m_WZZD, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_WZZD;
                    break;
                case "B0":
                    Vehicle_18C81_ZCZD_Para m_ZCZD = new Vehicle_18C81_ZCZD_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_ZCZD = mR.ParaSetModelValue(m_ZCZD, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_ZCZD;
                    break;
                case "H1":
                    Vehicle_18C81_ZWD_Para m_ZWD = new Vehicle_18C81_ZWD_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_ZWD = mR.ParaSetModelValue(m_ZWD, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_ZWD;
                    break;
                case "H2":
                    Vehicle_18C81_ZND_Para m_ZND = new Vehicle_18C81_ZND_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_ZND = mR.ParaSetModelValue(m_ZND, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_ZND;
                    break;
                case "H3":
                    Vehicle_18C81_YND_Para m_YND = new Vehicle_18C81_YND_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_YND = mR.ParaSetModelValue(m_YND, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_YND;
                    break;
                case "H4":
                    Vehicle_18C81_YWD_Para m_YWD = new Vehicle_18C81_YWD_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_YWD = mR.ParaSetModelValue(m_YWD, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_YWD;
                    break;
                case "S1":
                    Vehicle_18C81_CSB_Para m_CSB = new Vehicle_18C81_CSB_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_CSB = mR.ParaSetModelValue(m_CSB, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_CSB;
                    break;
                case "A1":
                    Vehicle_18C81_Sideslip_Para m_Sideslip = new Vehicle_18C81_Sideslip_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_Sideslip = mR.ParaSetModelValue(m_Sideslip, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_Sideslip;
                    break;
                case "M1":
                    Vehicle_18C81_WKCC_Para m_WKCC = new Vehicle_18C81_WKCC_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_WKCC = mR.ParaSetModelValue(m_WKCC, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_WKCC;
                    break;
                case "Z1":
                    Vehicle_18C81_ZBZL_Para m_ZBZL = new Vehicle_18C81_ZBZL_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_ZBZL = mR.ParaSetModelValue(m_ZBZL, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_ZBZL;
                    break;
                case "L1":
                    Vehicle_18C81_JZZD_Para m_YZJZ = new Vehicle_18C81_JZZD_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_YZJZ = mR.ParaSetModelValue(m_YZJZ, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_YZJZ;
                    break;
                case "L2":
                    Vehicle_18C81_JZZD_Para m_EZJZ = new Vehicle_18C81_JZZD_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_EZJZ = mR.ParaSetModelValue(m_EZJZ, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_EZJZ;
                    break;
                case "L3":
                    Vehicle_18C81_JZZD_Para m_SZJZ = new Vehicle_18C81_JZZD_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_SZJZ = mR.ParaSetModelValue(m_SZJZ, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_SZJZ;
                    break;
                case "L4":
                    Vehicle_18C81_JZZD_Para m_SIZJZ = new Vehicle_18C81_JZZD_Para(m_para.jkid, m_para.jkxlh, m_para.xtlb);
                    m_SIZJZ = mR.ParaSetModelValue(m_SIZJZ, "vehispara", strParaContent);
                    m_para = (Vehicle_18C81_Para)m_SIZJZ;
                    break;
            }

            

            return m_para;
        }

        /// <summary>
        /// 18C81 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C81_Result Result_18C81_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C81_Result m_Result = (Vehicle_18C81_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18J31
        private Vehicle_18J31_Para Para_18J31_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18J31_Para m_para = (Vehicle_18J31_Para)para;
            ModelReflection mR = new ModelReflection();

            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18J31 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18J31_Result Result_18J31_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18J31_Result m_Result = (Vehicle_18J31_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C62
        private Vehicle_18C62_Para Para_18C62_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C62_Para m_para = (Vehicle_18C62_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue_18C62(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18J31 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C62_Result Result_18C62_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C62_Result m_Result = (Vehicle_18C62_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C59
        private Vehicle_18C59_Para Para_18C59_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C59_Para m_para = (Vehicle_18C59_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18C59 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C59_Result Result_18C59_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C59_Result m_Result = (Vehicle_18C59_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C65
        private Vehicle_18C65_Para Para_18C65_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C65_Para m_para = (Vehicle_18C65_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18C65 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C65_Result Result_18C65_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C65_Result m_Result = (Vehicle_18C65_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C72
        private Vehicle_18C72_Para Para_18C72_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C72_Para m_para = (Vehicle_18C72_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18C72 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C72_Result Result_18C72_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C72_Result m_Result = (Vehicle_18C72_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18J80
        private Vehicle_18J80_Para Para_18J80_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18J80_Para m_para = (Vehicle_18J80_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "QueryCondition", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18J80 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18J80_Result Result_18J80_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18J80_Result m_Result = (Vehicle_18J80_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18X01
        private Vehicle_18X01_Para Para_18X01_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18X01_Para m_para = (Vehicle_18X01_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "QueryCondition", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18X01 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18X01_Result Result_18X01_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18X01_Result m_Result = (Vehicle_18X01_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValueEx(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18X02
        private Vehicle_18X02_Para Para_18X02_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18X02_Para m_para = (Vehicle_18X02_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "QueryCondition", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18X01 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18X02_Result Result_18X02_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18X02_Result m_Result = (Vehicle_18X02_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValueEx(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18X03
        private Vehicle_18X03_Para Para_18X03_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18X03_Para m_para = (Vehicle_18X03_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "QueryCondition", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18X03 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18X03_Result Result_18X03_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18X03_Result m_Result = (Vehicle_18X03_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValueEx(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C54
        private Vehicle_18C54_Para Para_18C54_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C54_Para m_para = (Vehicle_18C54_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18C54 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C54_Result Result_18C54_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C54_Result m_Result = (Vehicle_18C54_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18X04
        private Vehicle_18X04_Para Para_18X04_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18X04_Para m_para = (Vehicle_18X04_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18X04 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18X04_Result Result_18X04_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18X04_Result m_Result = (Vehicle_18X04_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18C63
        private Vehicle_18C63_Para Para_18C63_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18C63_Para m_para = (Vehicle_18C63_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18C63 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18C63_Result Result_18C63_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18C63_Result m_Result = (Vehicle_18C63_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18X05
        private Vehicle_18X05_Para Para_18X05_ToModel(ParaParent para, string strParaContent)
        {
            Vehicle_18X05_Para m_para = (Vehicle_18X05_Para)para;
            ModelReflection mR = new ModelReflection();
            m_para = mR.ParaSetModelValue(m_para, "vehispara", strParaContent);

            return m_para;
        }

        /// <summary>
        /// 18X05 Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strResultContent"></param>
        /// <returns></returns>
        private Vehicle_18X05_Result Result_18X05_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18X05_Result m_Result = (Vehicle_18X05_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                m_Result.code = "0";
                m_Result.message = "";
                return m_Result;
            }
            ModelReflection mR = new ModelReflection();
            m_Result = mR.ResultSetModelValue(m_Result, "vehispara", strResultContent);

            return m_Result;
        }
        #endregion

        #region 18W05
        private Vehicle_18W05_Para Para_18W05_ToModel(ParaParent para, string strPataContent)
        {
            Vehicle_18W05_Para _para = (Vehicle_18W05_Para)para;
            ModelReflection _mr = new ModelReflection();
            _para = _mr.ParaSetModelValue(_para, "vehispara", strPataContent);
            return _para;
        }

        private Vehicle_18W05_Result Result_18W05_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18W05_Result _result = (Vehicle_18W05_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                _result.code = "$E";
                _result.message = "Result is nullptr or Empty string";
                return _result;
            }
            ModelReflection _mr = new ModelReflection();
            _result = _mr.ResultSetModelValue(_result, "vehispara", strResultContent);
            return _result;
        }
        #endregion

        #region 18W06
        private Vehicle_18W06_Para Para_18W06_ToModel(ParaParent para, string strPataContent)
        {
            Vehicle_18W06_Para _para = (Vehicle_18W06_Para)para;
            ModelReflection _mr = new ModelReflection();
            _para = _mr.ParaSetModelValue(_para, "QueryCondition", strPataContent);
            return _para;
        }

        private Vehicle_18W06_Result Result_18W06_ToModel(ResultParent result, string strResultContent)
        {
            Vehicle_18W06_Result _result = (Vehicle_18W06_Result)result;
            if (string.IsNullOrEmpty(strResultContent))
            {
                _result.code = "$E";
                _result.message = "Result is nullptr or Empty string";
                return _result;
            }
            ModelReflection _mr = new ModelReflection();
            _result = _mr.ResultSetModelValue(_result, "vehispara", strResultContent);
            return _result;
        }
        #endregion 
    }
}
